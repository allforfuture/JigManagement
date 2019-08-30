using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace JigManagement.Jig
{
    public partial class JigAdd : Form
    {
        public JigAdd()
        {
            InitializeComponent();

            string[] strArr = ConfigurationManager.AppSettings["DataTypeID"].Split(',');
            cboDataTypeID_Add.Items.AddRange(strArr);
            strArr = ConfigurationManager.AppSettings["Line"].Split(',');
            cboLine_Add.Items.AddRange(strArr);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtJigID_Add.Text==""|| cboDataTypeID_Add.Text==""|| cboLine_Add.Text=="")
            {

                MessageBox.Show("需要添加的信息没填满", "添加", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = string.Format(@"INSERT INTO m_jig (serial_cd, created_at, datatype_id,line_cd, user_id,exist_flag)
                            VALUES ('{0}',  Now(), '{1}', '{2}','{3}',True)"
                       , txtJigID_Add.Text, cboDataTypeID_Add.Text, cboLine_Add.Text, Login.User);

            try
            {
                new DBFactory().ExecuteSQL(sql);
                MessageBox.Show("添加成功");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message,"数据库",MessageBoxButtons.OK,MessageBoxIcon.Error); }           
        }
    }
}
