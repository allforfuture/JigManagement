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
    public partial class MaintenanceHistory : Form
    {
        public MaintenanceHistory()
        {
            InitializeComponent();
            cboDataTypeID.Items.AddRange(Config.Control.ComboBox_DataTypeID);
            cboLine.Items.AddRange(Config.Control.ComboBox_Line);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!chkJigID.Checked && !chkTime.Checked && !chkWorkType.Checked &&
                !chkUser.Checked && !chkComments.Checked &&
                !chkDataTypeID.Checked && !chkLine.Checked)
            {
                MessageBox.Show("没有勾选搜索条件");
                return;
            }

            dgvData.Columns.Clear();
            #region sql语句
            StringBuilder sql = new StringBuilder();
            sql.AppendLine(
@"SELECT his.serial_cd,his.created_at,his.work_type,his.user_id,his.comments,jig.datatype_id,jig.line_cd
FROM jig_mainte_history his
LEFT JOIN m_jig jig ON his.serial_cd=jig.serial_cd
WHERE his.id IS NOT NULL"
);
            if (chkJigID.Checked)
            {
                sql.AppendLine("AND his.serial_cd='" + txtJigID.Text + "'");
            }
            if (chkTime.Checked)
            {
                sql.AppendLine(string.Format("AND '{0}'<=his.created_at AND his.created_at<'{1}'::timestamp+ '1D'",
                    dtpStart.Value.ToString("yyyyMMdd"), dtpEnd.Value.ToString("yyyyMMdd")));
            }
            if (chkWorkType.Checked)
            {
                sql.AppendLine("AND his.work_type='" + cboWorkType.Text + "'");
            }
            if (chkUser.Checked)
            {
                sql.AppendLine("AND his.user_id='" + txtUser.Text + "'");
            }
            if (chkComments.Checked)
            {
                sql.AppendLine("AND his.comments LIKE '%" + txtComments.Text + "%'");
            }
            if (chkDataTypeID.Checked)
            {
                sql.AppendLine("AND jig.datatype_id='" + cboDataTypeID.Text + "'");
            }
            if (chkLine.Checked)
            {
                sql.AppendLine("AND jig.line_cd='" + cboLine.Text + "'");
            }
            sql.AppendLine("ORDER BY his.created_at DESC");
            #endregion

            DataTable dt = new DataTable();
            new DBhelp().ExecuteDataTable(sql.ToString(), ref dt);
            dgvData.DataSource = dt;
            dgvData.AutoResizeColumns();
        }
    }
}
