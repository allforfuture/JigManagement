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
            //cboDataTypeID_Search
            string[] strArr = ConfigurationManager.AppSettings["DataTypeID"].Split(',');
            cboDataTypeID.Items.AddRange(strArr);
            //cboLine_Search
            strArr = ConfigurationManager.AppSettings["Line"].Split(',');
            cboLine.Items.AddRange(strArr);
            //cboExist_Search
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
                //AND Judge.serial_cd='HRD9215-037D9HK09-DCCI1100A'
                sql.AppendLine("AND Judge.serial_cd='" + txtJigID.Text + "'");
            }            
            if (chkDataTypeID.Checked)
            {
                //AND Jig.datatype_id='JIG_BASE'
                sql.AppendLine("AND Jig.datatype_id='" + cboDataTypeID.Text+"'");
            }
            if (chkLine.Checked)
            {
                //AND Jig.line_cd='L06'
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
            new DBFactory().ExecuteDataTable(sql.ToString(), ref dt);
            if (dt.Rows.Count > 0)
            {
                dgvData.DataSource = dt;
                //加按钮
                addButtonsToDataGridView(dgvData);
                dgvData.AutoResizeColumns();
            }
            //else { MessageBox.Show("所选的条件查询不到数据", "数据库查询", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }


        //定义ButtonColumn
        DataGridViewButtonColumn btnOpen;
        DataGridViewButtonColumn btnMaintenance;
        private void addButtonsToDataGridView(DataGridView dgv)
        {
            //btnOpen = new DataGridViewButtonColumn();
            //btnOpen.HeaderText = string.Empty;
            //btnOpen.Text = "Jig属性";
            //btnOpen.UseColumnTextForButtonValue = true;
            //btnOpen.Width = 80;
            //dgv.Columns.Add(btnOpen);

            btnMaintenance = new DataGridViewButtonColumn();
            btnMaintenance.HeaderText = string.Empty;
            btnMaintenance.Text = "维修";
            btnMaintenance.UseColumnTextForButtonValue = true;
            btnMaintenance.Width = 80;
            dgv.Columns.Add(btnMaintenance);
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //点击"Jig属性"
            if (dgvData.Columns[e.ColumnIndex] == btnOpen)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "Info")
                    {
                        MessageBox.Show("请关闭已打开的Info窗口再打开", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                //int currentRow = int.Parse(e.RowIndex.ToString());

                DataGridViewRow row = dgvData.Rows[e.RowIndex];
                Info info = new Info(row, dgvData.Columns);
                info.Show();
            }
            //点击"维修"
            else if (dgvData.Columns[e.ColumnIndex] == btnMaintenance)
            {

                if (Login.Role != "admin" && Login.Role != "mainte")
                {
                    MessageBox.Show("此用户没有权限维修", "维修", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string serial_cd = dgvData.Rows[e.RowIndex].Cells["serial_cd"].Value.ToString();
                bool isOpen = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.Text == "JigMaintenance")
                    {
                        isOpen = true;
                        openForm.Close();
                        new JigMaintenance(serial_cd).ShowDialog();
                        break;
                    }
                }
                if (!isOpen)
                {
                    new JigMaintenance(serial_cd).ShowDialog();
                }
                BtnSearch_Click(sender, e);
            }
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