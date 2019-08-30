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
            dtpStart.Value = DateTime.Today.AddDays(-5);

            #region 下拉框选项加载
            //cboReason_Search数据库原因字段
            string sql = "select distinct(reason_text_cn) from m_reason";
            DataTable dt = new DataTable();
            new DBFactory().ExecuteDataTable(sql, ref dt);
            foreach (DataRow dr in dt.Rows)
            {
                cboReason_Search.Items.Add(dr["reason_text_cn"].ToString());
            }
            //cboDataTypeID_Search
            string[] strArr = ConfigurationManager.AppSettings["DataTypeID"].Split(',');
            cboDataTypeID_Search.Items.AddRange(strArr);
            //cboLine_Search
            strArr = ConfigurationManager.AppSettings["Line"].Split(',');
            cboLine_Search.Items.AddRange(strArr);
            //cboExist_Search
            cboExist_Search.Text = "TRUE";
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
        private void 添加胶水类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == "GlueType")
                {
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                new GlueType().Show();
            }
        }

        private void 添加使用地点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == "GlueUsePlace")
                {
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                new GlueUsePlace().Show();
            }
        }

        private void 装大胶水ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == "BigGlueItem")
                {
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                new BigGlueItem().Show();
            }
        }

        private void 装小胶水ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == "SmallGlueItem")
                {
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                new SmallGlueItem().Show();
            }
        }

        private void 移动胶水ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == "GlueRecord")
                {
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                new GlueRecord().Show();
            }
        }

        private void 打印标签ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == "Print")
                {
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                new Print().Show();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dgvData.Columns.Clear();            
            
            StringBuilder sql = new StringBuilder();
            sql.AppendLine(
@"SELECT serial_cd,created_at,reason_text_cn,comment_text,datatype_id,line_cd,exist_flag
FROM
(SELECT ROW_NUMBER() OVER (PARTITION BY Status.serial_cd ORDER BY Status.created_at DESC),
Status.serial_cd,Status.created_at,Reason.reason_text_cn,Status.status_cd,Status.comment_text,
Jig.datatype_id,Jig.line_cd,Jig.exist_flag
FROM jig_status Status
LEFT JOIN m_reason Reason ON Status.reason_cd=Reason.reason_cd
LEFT JOIN m_jig Jig ON Status.serial_cd=Jig.serial_cd) Table1
WHERE row_number=1 AND status_cd='1'"
);

            if (chkJigID.Checked)
            {
                sql.AppendLine("AND serial_cd='" + txtJigID_Search.Text + "'");
            }
            if (chkTime.Checked)
            {
                sql.AppendLine(string.Format("AND '{0}'<=created_at AND created_at<'{1}'::timestamp+ '1D'",
                    dtpStart.Value.ToString("yyyyMMdd"), dtpEnd.Value.ToString("yyyyMMdd")));
            }

            if (chkReason.Checked)
            {
                sql.AppendLine("AND reason_text_cn='" + cboReason_Search.Text + "'");
            }

            if (chkDataTypeID.Checked)
            {
                sql.AppendLine("AND datatype_id='"+cboDataTypeID_Search.Text+"'");
            }


            if (chkLine.Checked)
            {
                sql.AppendLine("AND line_cd='"+cboLine_Search.Text+"'");
            }

            if (chkExist.Checked)
            {
                sql.AppendLine("AND exist_flag="+cboExist_Search.Text+"");
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
                if (MessageBox.Show("再次确认是否已维修？", "维修"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                string serial_cd = dgvData.Rows[e.RowIndex].Cells["serial_cd"].Value.ToString();
                string sql = string.Format(@"INSERT INTO jig_mainte_history (id, serial_cd, created_at, work_type, user_id)
                                        VALUES (Nextval('jig_mainte_history_id_seq'), '{0}', now(), 'MAINTENANCE', '{1}')"
                            , serial_cd, Login.User);
                new DBFactory().ExecuteSQL(sql);
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
                }
            }
            if (!isOpen)
            {
                new JigRename().Show();
            }
        }
    }
}