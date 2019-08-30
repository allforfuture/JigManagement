using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JigManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string User
        {
            get; set;
            //get => default;
            //set { }
        }

        public static string Role
        {
            get; set;
            //get => default;
            //set { }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = txtPassword.Text = "";
            //Environment.Exit(0);
        }

        private void TxtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            BtnLogin_Click(sender, new EventArgs());
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            BtnLogin_Click(sender, new EventArgs());
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("用户名不能为空", "登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CheckUser();
            if (JigManagement.jigManagement != null)
            {
                switch (Login.Role)
                {
                    case "admin":
                        JigManagement.jigManagement.jig添加ToolStripMenuItem.Enabled = true;
                        JigManagement.jigManagement.jig报废ToolStripMenuItem.Enabled = true;
                        JigManagement.jigManagement.jig变更ToolStripMenuItem.Enabled = true;
                        JigManagement.jigManagement.jig维护ToolStripMenuItem.Enabled = true;
                        break;
                    case "new":
                        JigManagement.jigManagement.jig添加ToolStripMenuItem.Enabled = true;
                        JigManagement.jigManagement.jig报废ToolStripMenuItem.Enabled = true;
                        JigManagement.jigManagement.jig变更ToolStripMenuItem.Enabled = true;
                        JigManagement.jigManagement.jig维护ToolStripMenuItem.Enabled = false;
                        break;
                    case "mainte":
                        JigManagement.jigManagement.jig添加ToolStripMenuItem.Enabled = false;
                        JigManagement.jigManagement.jig报废ToolStripMenuItem.Enabled = false;
                        JigManagement.jigManagement.jig变更ToolStripMenuItem.Enabled = false;
                        JigManagement.jigManagement.jig维护ToolStripMenuItem.Enabled = true;
                        break;
                    default:
                        JigManagement.jigManagement.jig添加ToolStripMenuItem.Enabled = false;
                        JigManagement.jigManagement.jig报废ToolStripMenuItem.Enabled = false;
                        JigManagement.jigManagement.jig变更ToolStripMenuItem.Enabled = false;
                        JigManagement.jigManagement.jig维护ToolStripMenuItem.Enabled = false;
                        break;
                }
            }
        }

        void CheckUser()
        {
            string sql = "Select user_id,role_text From m_user Where user_id='" + txtUser.Text + "' and pass_wd='" + txtPassword.Text + "'";
            DataTable dt = new DataTable();
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                //登陆成功
                User = dt.Rows[0]["user_id"].ToString();
                Role = dt.Rows[0]["role_text"].ToString();
                DialogResult = DialogResult.OK;
            }
            else
            {
                //登陆失败
                MessageBox.Show("用户名或密码错误!", "登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
