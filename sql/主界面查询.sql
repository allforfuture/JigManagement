新：status关联jig
SELECT serial_cd,created_at,reason_text_cn,comment_text,datatype_id,line_cd,exist_flag
FROM
(select ROW_NUMBER() OVER (PARTITION BY Status.serial_cd ORDER BY Status.created_at DESC),
Status.serial_cd,Status.created_at,Reason.reason_text_cn,Status.status_cd,Status.comment_text,
Jig.datatype_id,Jig.line_cd,Jig.exist_flag
from jig_status Status
LEFT JOIN m_reason Reason ON Status.reason_cd=Reason.reason_cd
LEFT JOIN m_jig Jig ON Status.serial_cd=Jig.serial_cd) Table1
Where row_number=1 AND status_cd='1'--时间最近的记录（row_number=1）而且是坏的（status_cd='1'）
AND serial_cd='JST9225-037I9GK09-ENGA0300E'
AND '20190601'<=created_at and created_at<'20190828'::timestamp+ '1D'
AND reason_text_cn='Yiled判定'
AND datatype_id='JIG_INNER'
AND line_cd='L04'
AND exist_flag=TRUE


旧：history记录关联jig
SELECT serial_cd,latest_history,work_type,datatype_id,line_cd,exist_flag FROM
(SELECT ROW_NUMBER() OVER (PARTITION BY History.serial_cd ORDER BY History.created_at DESC),
History.serial_cd,History.created_at AS latest_history,History.work_type,
Jig.datatype_id,Jig.line_cd,Jig.exist_flag
FROM jig_mainte_history History
LEFT JOIN m_jig Jig ON History.serial_cd=Jig.serial_cd) Table1
Where row_number=1
--AND serial_cd='JST9211-009I9GK09-ENGA0300E'
--AND '20190601'<=latest_history and latest_history<'20190828'::timestamp+ '1D'
--AND work_type='MAINTENANCE'
--AND datatype_id='JIG_INNER'
--AND line_cd='L13'
--AND exist_flag=FALSE