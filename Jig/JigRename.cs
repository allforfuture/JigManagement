using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JigManagement.Jig
{
    public partial class JigRename : Form
    {
        public JigRename()
        {
            InitializeComponent();
        }

        private void BtnRename_Click(object sender, EventArgs e)
        {
            if (txtJigID_old.Text == ""||txtJigID_new.Text=="")
            {

                MessageBox.Show("需要添加的信息没填满", "添加", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = string.Format(
@"UPDATE m_jig SET exist_flag=False WHERE serial_cd='{0}';
INSERT INTO m_jig (serial_cd, created_at, datatype_id,line_cd, user_id,exist_flag)
VALUES ('{1}',  NOW()
, (select datatype_id
from m_jig
where serial_cd='{0}')
,(select line_cd
from m_jig
where serial_cd='{0}')
,'{2}',True)
RETURNING serial_cd,datatype_id,line_cd"
, txtJigID_old.Text,txtJigID_new.Text,Login.User
);

            try
            {
                DataTable dt = new DataTable();
                new DBhelp().ExecuteDataTable(sql, ref dt);
                if (dt.Rows.Count > 0)
                {
                    string APIbody = @"{
	                                ""serial_cd"": """ + dt.Rows[0]["serial_cd"].ToString() + @""",
                                    ""datatype_id"": """ + dt.Rows[0]["datatype_id"].ToString() + @""",
                                    ""line_cd"": """ + dt.Rows[0]["line_cd"].ToString() + @""",
	                                ""status"": ""0"",
	                                ""reason_cd"": """"
                                }";

                    if (!API.API.HttpResponse(APIbody, "PUT"))
                    {
                        { MessageBox.Show("网页响应失败", "网页PUT", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        return;
                    }
                    MessageBox.Show("变更成功");
                }
                else { MessageBox.Show("变更失败"); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "数据库", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
