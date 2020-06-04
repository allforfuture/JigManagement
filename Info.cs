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

namespace JigManagement
{
    public partial class Info : Form
    {
        public Info(DataGridViewRow row, DataGridViewColumnCollection columns)
        {
            InitializeComponent();

            string[] strArr = ConfigurationManager.AppSettings["DataTypeID"].Split(',');
            cboDataTypeID_Update.Items.AddRange(strArr);
            strArr = ConfigurationManager.AppSettings["Line"].Split(',');
            cboLine_Update.Items.AddRange(strArr);

            dgvData.AutoResizeColumns();
            DataTable dt = new DataTable();
            DataRow dr = dt.NewRow();
            for (int i = 0; i < columns.Count - 1; i++)
            {
                dt.Columns.Add(columns[i].HeaderText);
                dr[i] = row.Cells[i].Value;
            }
            dt.Rows.Add(dr);
            dgvData.DataSource = dt;
            txtJigID.Text = dt.Rows[0]["serial_cd"].ToString();
            cboDataTypeID_Update.Text = dt.Rows[0]["datatype_id"].ToString();
            cboLine_Update.Text = dt.Rows[0]["line_cd"].ToString();
            //cboExist_Update.Text = dt.Rows[0]["exist_flag"].ToString();
            cboExist_Update.Text = "True";
        }

        private void Info_Load(object sender, EventArgs e)
        {
            dgvData.AutoResizeColumns();
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (cboDataTypeID_Update.Text==""||cboLine_Update.Text==""|| cboExist_Update.Text=="")
            {
                MessageBox.Show("需要添加的信息没填满", "修改", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = string.Format(
                                    @"UPDATE m_jig
                                    SET datatype_id = '{0}'
                                    ,line_cd='{1}'
                                    ,user_id='{2}'
                                    ,exist_flag={3}
                                    WHERE serial_cd='{4}'"
, cboDataTypeID_Update.Text, cboLine_Update.Text, Login.User, cboExist_Update.Text, txtJigID.Text);
            new DBhelp().ExecuteSQL(sql);
            Close();
        }
    }
}
