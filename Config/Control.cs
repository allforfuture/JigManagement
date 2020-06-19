using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;

namespace JigManagement.Config
{
    /// <summary>
    /// 控件列表
    /// </summary>
    class Control
    {
        public static string[] ComboBox_DataTypeID
        {
            get
            {
                return ConfigurationManager.AppSettings["DataTypeID"].Split(',');
            }
        }

        public static string[] ComboBox_Line
        {
            get
            {
                return ConfigurationManager.AppSettings["Line"].Split(',');
            }
        }

        static Dictionary<string, string> ReasonDic = new Dictionary<string, string>();
        public static Dictionary<string, string> ComboBox_Reason
        {
            get
            {
                return ReasonDic;
            }
        }
        public static void GetReasonValue()
        {
            string sql = "SELECT reason_cd,reason_text_cn FROM m_reason";
            DataTable dt = new DataTable();
            new DBhelp().ExecuteDataTable(sql, ref dt);
            foreach (DataRow dr in dt.Rows)
            {
                ReasonDic.Add(dr["reason_cd"].ToString(), dr["reason_text_cn"].ToString());
            }
        }
    }
}
