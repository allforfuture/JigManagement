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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!chkJigID.Checked && !chkTime.Checked && !chkWorkType.Checked &&
                !chkUser.Checked && !chkComments.Checked)
            {
                MessageBox.Show("没有勾选搜索条件");
                return;
            }

            dgvData.Columns.Clear();
            #region sql语句
            StringBuilder sql = new StringBuilder();
            sql.AppendLine(
@"SELECT serial_cd,created_at,work_type,user_id,comments
FROM jig_mainte_history
WHERE id IS NOT NULL"
);
            if (chkJigID.Checked)
            {
                sql.AppendLine("AND serial_cd='" + txtJigID.Text + "'");
            }
            if (chkTime.Checked)
            {
                sql.AppendLine(string.Format("AND '{0}'<=created_at AND created_at<'{1}'::timestamp+ '1D'",
                    dtpStart.Value.ToString("yyyyMMdd"), dtpEnd.Value.ToString("yyyyMMdd")));
            }
            if (chkWorkType.Checked)
            {
                sql.AppendLine("AND work_type='" + cboWorkType.Text + "'");
            }
            if (chkUser.Checked)
            {
                sql.AppendLine("AND user_id='" + txtUser.Text + "'");
            }
            if (chkComments.Checked)
            {
                sql.AppendLine("AND comments LIKE '%" + txtComments.Text + "%'");
            }
            sql.AppendLine("ORDER BY created_at DESC");
            #endregion

            DataTable dt = new DataTable();
            new DBhelp().ExecuteDataTable(sql.ToString(), ref dt);
            dgvData.DataSource = dt;
            dgvData.AutoResizeColumns();
        }
    }
}
