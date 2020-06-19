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
        public JigManagement()
        {
            InitializeComponent();
            this.Text += "_" + Application.ProductVersion.ToString();

            #region 下拉框选项加载
            //cboReason_Search数据库原因字段
            //string sql = "select distinct(reason_text_cn) from m_reason";
            //DataTable dt = new DataTable();
            //new DBFactory().ExecuteDataTable(sql, ref dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    cboReason_Search.Items.Add(dr["reason_text_cn"].ToString());
            //}
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
@"SELECT Judge.serial_cd,Jig.datatype_id,Jig.line_cd,Jig.exist_flag
FROM v_total_judge Judge
LEFT JOIN m_jig Jig ON Judge.serial_cd=Jig.serial_cd
WHERE Judge.total_judge !='0'"
);

            if (chkJigID.Checked)
            {
                sql.AppendLine("AND Judge.serial_cd='" + txtJigID.Text + "'");
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