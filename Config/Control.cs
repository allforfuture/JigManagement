using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

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
    }
}
