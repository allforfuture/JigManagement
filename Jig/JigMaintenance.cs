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


            if (!API.API.PostHttp(APIbody))
            {
                return;
            }

            string sql = string.Format(@"INSERT INTO jig_mainte_history (id, serial_cd, created_at, work_type, user_id,comments)
                                        VALUES (Nextval('jig_mainte_history_id_seq'), '{0}', now(), 'MAINTENANCE', '{1}','{2}')"
                           , txtJigID.Text, Login.User, txtComments.Text);
            try
            {
                new DBFactory().ExecuteSQL(sql);
                MessageBox.Show("提交维修信息成功");
                this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "数据库", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
