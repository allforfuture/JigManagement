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
VALUES ('{1}',  Now()
, (select datatype_id
from m_jig
where serial_cd='{0}')
,(select line_cd
from m_jig
where serial_cd='{0}')
,'{2}',True)"
,txtJigID_old.Text,txtJigID_new.Text,Login.User
);


            try
            {
                new DBFactory().ExecuteSQL(sql);
                MessageBox.Show("变更成功");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "数据库", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
