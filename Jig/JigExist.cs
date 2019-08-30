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
    public partial class JigExist : Form
    {
        public JigExist()
        {
            InitializeComponent();
        }

        private void BtnNotExist_Click(object sender, EventArgs e)
        {
            if (txtJigID.Text == "")
            {

                MessageBox.Show("需要添加的信息没填满", "添加", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = string.Format(@"UPDATE m_jig SET exist_flag=False WHERE serial_cd='{0}'", txtJigID.Text);

            try
            {
                new DBFactory().ExecuteSQL(sql);
                MessageBox.Show("报废成功");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "数据库", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
