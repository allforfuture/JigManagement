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
        public JigMaintenance(string jigID)
        {
            InitializeComponent();
            txtJigID.Text = jigID;
            txtJigID.ReadOnly = true;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (txtJigID.Text == "")
            {

                MessageBox.Show("需要添加的信息没填满", "添加", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            string APIbody = @"{
	                                ""serial_cd"": """ + txtJigID.Text + @""",
	                                ""status"": ""0"",
	                                ""reason_cd"": """"
                                }";


            if (!API.API.HttpResponse(APIbody, "POST"))
            {
                { MessageBox.Show("网页PUT失败", "网页POST", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                return;
            }
            
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($@"INSERT INTO jig_status(serial_cd,created_at,reason_cd,status_cd,comment_text)
VALUES('{txtJigID.Text}',NOW(),'001','0',''),('{txtJigID.Text}',NOW(),'002','0','')");
            sql.AppendFormat(@";INSERT INTO jig_mainte_history (id, serial_cd, created_at, work_type, user_id,comments)
VALUES (Nextval('jig_mainte_history_id_seq'), '{0}', now(), 'MAINTENANCE', '{1}','{2}')"
, txtJigID.Text, Login.User, txtComments.Text);

            try
            {
                new DBFactory().ExecuteSQL(sql.ToString());
                MessageBox.Show("提交维修信息成功");
                this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "数据库", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
