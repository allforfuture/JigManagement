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
    public partial class JigMaintenance : Form
    {
        public JigMaintenance()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (txtJigID.Text == "")
            {
                MessageBox.Show("需要添加的信息没填满", "添加", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] jigs = txtJigID.Text.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string jig in jigs)
            {
                #region POST
                string APIbody = @"{
	                                ""serial_cd"": """ + jig + @""",
	                                ""status"": ""0"",
	                                ""reason_cd"": """"
                                }";
                if (!API.API.HttpResponse(APIbody, "POST"))
                {
                    MessageBox.Show($"{jig}\r\n网页响应失败", "网页POST", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                #region 数据库
                StringBuilder sql = new StringBuilder();
                foreach (KeyValuePair<string, string> kvp in Config.Control.ComboBox_Reason)
                {
                    sql.AppendLine($@"INSERT INTO jig_status(serial_cd,created_at,reason_cd,status_cd,comment_text)
VALUES('{jig}',NOW(),'{kvp.Key}','0','');");
                }
                sql.AppendFormat(@"INSERT INTO jig_mainte_history (id, serial_cd, created_at, work_type, user_id,comments)
VALUES (Nextval('jig_mainte_history_id_seq'), '{0}', now(), 'MAINTENANCE', '{1}','{2}')"
    , jig, Login.User, txtComments.Text);

                try
                { new DBhelp().ExecuteSQL(sql.ToString()); }
                catch (Exception ex)
                { 
                    MessageBox.Show(jig + "\r\n" + ex.Message, "数据库", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion
            }
            MessageBox.Show("提交维修信息成功");
            this.Close();
        }
    }
}
