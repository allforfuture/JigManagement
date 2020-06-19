using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using JigManagement.Jig;

namespace JigManagement
{
    public partial class JigManagement : Form
    {
        public static JigManagement jigManagement;
        char separator = '：';
        public JigManagement()
        {
            InitializeComponent();
            this.Text += "_" + Application.ProductVersion.ToString();

            #region 下拉框选项加载
            foreach (KeyValuePair<string, string> kvp in Config.Control.ComboBox_Reason)
            {
                cboReason.Items.Add(kvp.Key + separator + kvp.Value);
            }
            cboDataTypeID.Items.AddRange(Config.Control.ComboBox_DataTypeID);
            cboLine.Items.AddRange(Config.Control.ComboBox_Line);
            cboExist.Text = "TRUE";
            #endregion

            switch (Login.Role)
            {
                case "admin":
                    jig添加ToolStripMenuItem.Enabled = jig报废ToolStripMenuItem.Enabled =
                        jig变更ToolStripMenuItem.Enabled = jig维护ToolStripMenuItem.Enabled = true;
                    break;
                case "new":
                    jig添加ToolStripMenuItem.Enabled = jig报废ToolStripMenuItem.Enabled =
                        jig变更ToolStripMenuItem.Enabled = true;
                    break;
                case "mainte":
                    jig维护ToolStripMenuItem.Enabled = true;
                    break;
            }
            jigManagement = this;
        }


        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!chkJigID.Checked && !chkDataTypeID.Checked && !chkLine.Checked && !chkExist.Checked)
            {
                MessageBox.Show("没有勾选搜索条件");
                return;
            }

            dgvData.Columns.Clear();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine(
@"WITH All_data AS(
	SELECT ROW_NUMBER() OVER (PARTITION BY serial_cd,reason_cd ORDER BY created_at DESC) AS grouplist,*
	FROM jig_status
)
,Bad_jig AS(
	SELECT serial_cd,ARRAY_AGG(reason_cd) reason_arr,ARRAY_AGG(created_at) created_arr,MIN(created_at) ng_earliest_time
	FROM all_data
	WHERE grouplist=1
	AND status_cd='1'
	GROUP BY serial_cd
)
SELECT Bad_jig.serial_cd,Jig.datatype_id,Jig.line_cd,Jig.exist_flag,Bad_jig.reason_arr::TEXT,Bad_jig.ng_earliest_time
FROM Bad_jig
LEFT JOIN m_jig Jig ON Bad_jig.serial_cd=Jig.serial_cd
WHERE TRUE"
);

            if (chkJigID.Checked)
            {
                sql.AppendLine("AND Bad_jig.serial_cd='" + txtJigID.Text + "'");
            }            
            if (chkDataTypeID.Checked)
            {
                sql.AppendLine("AND Jig.datatype_id='" + cboDataTypeID.Text+"'");
            }
            if (chkLine.Checked)
            {
                sql.AppendLine("AND Jig.line_cd='" + cboLine.Text+"'");
            }
            if (chkExist.Checked)
            {
                if (cboExist.Text=="NULL")
                    sql.AppendLine("AND Jig.exist_flag IS NULL");
                else
                    sql.AppendLine("AND Jig.exist_flag=" + cboExist.Text+"");
            }
            if (chkReason.Checked)
            {
                sql.AppendLine($"AND '{cboReason.Text.Split(separator)[0]}'=ANY(Bad_jig.reason_arr)");
            }
            if (chkDate.Checked)
            {
                sql.AppendLine(string.Format("AND (Bad_jig.ng_earliest_time BETWEEN '{0}' AND '{1}'::timestamp+ '1D')",
                    dtpStart.Value.ToString("yyyyMMdd"), dtpEnd.Value.ToString("yyyyMMdd")));
            }

            DataTable dt = new DataTable();
            new DBhelp().ExecuteDataTable(sql.ToString(), ref dt);
            dgvData.DataSource = dt;
            dgvData.AutoResizeColumns();
        }
        
        private void Jig添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == "JigAdd")
                {
                    isOpen = true;
                    openForm.Focus();
                    break;
                }
            }
            if (!isOpen)
            {
                new JigAdd().Show();
            }
        }

        private void Jig报废ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == "JigExist")
                {
                    isOpen = true;
                    openForm.Focus();
                    break;
                }
            }
            if (!isOpen)
            {
                new JigExist().Show();
            }
        }

        private void Jig维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == "JigMaintenance")
                {
                    isOpen = true;
                    openForm.Focus();
                    break;
                }
            }
            if (!isOpen)
            {
                new JigMaintenance().Show();
            }
        }

        private void Jig变更ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            bool isOpen = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == "JigRename")
                {
                    isOpen = true;
                    openForm.Focus();
                    break;
                }
            }
            if (!isOpen)
            {
                new JigRename().Show();
            }
        }

        private void 维修记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == "MaintenanceHistory")
                {
                    isOpen = true;
                    openForm.Focus();
                    break;
                }
            }
            if (!isOpen)
            {
                new MaintenanceHistory().Show();
            }
        }
    }
}