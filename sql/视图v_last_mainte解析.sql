--视图v_last_mainte 是 m_jig对应jig_mainte_history的最近记录或NoHistoryData的话是现在时间-7天
--select * from v_last_mainte

WITH v_target_history AS (
	--表v_target_history 是 m_jig对应jig_mainte_history的记录
	SELECT t.serial_cd,
	t.line_cd,
	t.datatype_id,
	--COALESCE是一个函数， (expression_1, expression_2, ...,expression_n)依次参考各参数表达式，遇到非null值即停止并返回该值
	COALESCE(h.work_type, 'NoHistoryData'::text) AS work_type,
	--输出非空的时间或现在时间Now()-7天
	COALESCE(h.created_at, now() - 7::double precision * '1 day'::interval) AS log_at
	FROM m_jig t
	LEFT JOIN jig_mainte_history h ON h.serial_cd = t.serial_cd
	WHERE t.exist_flag = true
)
--表v_last_mainte 是 v_target_history是每个serial_cd最近时间且work_type是MAINTENANCE或NoHistoryData的记录
, v_last_mainte AS (
	SELECT tmp.serial_cd,
	tmp.line_cd,
	tmp.datatype_id,
	tmp.work_type,
	tmp.log_at
	--表tmp 是 按log_at倒序，给serial_cd加行数，1是serial_cd最新的记录
	FROM ( SELECT row_number() OVER (PARTITION BY v_target_history.serial_cd ORDER BY v_target_history.log_at DESC) AS row_number,
		  v_target_history.serial_cd,
		  v_target_history.line_cd,
		  v_target_history.datatype_id,
		  v_target_history.work_type,
		  v_target_history.log_at
		  FROM v_target_history) tmp
	--any表示有任何一个满足就返回true，all表示全部都满足才返回true
	WHERE tmp.row_number = 1 AND (tmp.work_type = ANY (ARRAY['MAINTENANCE'::text, 'NoHistoryData'::text]))
)
SELECT v_last_mainte.serial_cd,
v_last_mainte.line_cd,
v_last_mainte.datatype_id,
v_last_mainte.work_type,
v_last_mainte.log_at AS last_log
FROM v_last_mainte