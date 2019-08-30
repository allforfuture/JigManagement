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
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
            dgv.RowHeadersWidth = 55;
            //dtpStart.Value = dtpStart.Value.AddDays(-3);
            //string a = dtpStart.Value.ToLongDateString();
            //MessageBox.Show(a);
            //a = dtpStart.Value.ToShortDateString();
            //MessageBox.Show(a);
            //a = dtpStart.Value.ToString("yyyy-MM-dd");
            //MessageBox.Show(a);
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            if (!chkID1.Checked && !chkGroup2.Checked && !chkWorkLocation3.Checked && !chkModel4.Checked && !chkLot5.Checked && !chkUserID6.Checked && !chkAction7.Checked && !chkLine8.Checked && !chkTime9.Checked)
            {
                MessageBox.Show("请勾上条件再查询","查询",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("Select t1.glue_id,t1.group,t1.worklocation,t1.model,t1.lot,t2.user_id,t2.action,t2.line,t2.time");
            sql.AppendLine("From glue t1,glue_use t2");
            sql.AppendLine("Where t1.glue_id=t2.glue_id");
            if (chkID1.Checked)
                sql.AppendLine("And t1.glue_id::text='" + txtID.Text+"'");
            if (chkGroup2.Checked)
                sql.AppendLine("And t1.group='" + txtGroup.Text + "'");
            if (chkWorkLocation3.Checked)
                sql.AppendLine("And t1.worklocation='" + txtWorkLocation.Text + "'");
            if (chkModel4.Checked)
                sql.AppendLine("And t1.model='" + txtModel.Text + "'");
            if (chkLot5.Checked)
                sql.AppendLine("And t1.lot='" + txtLot.Text + "'");
            if (chkUserID6.Checked)
                sql.AppendLine("And t2.user_id='" + txtUserID.Text + "'");
            if (chkAction7.Checked)
                sql.AppendLine("And t2.action='" + cboAction.Text + "'");
            if (chkLine8.Checked)
                sql.AppendLine("And t2.line='" + txtLine.Text + "'");
            if (chkTime9.Checked)
                sql.AppendFormat("And t2.time::date Between '{0}'::date And '{1}'::date\r\n", dtpStart.Value.ToShortDateString(), dtpEnd.Value.ToShortDateString());//"And t2.time::date Between '2020-07-01'::date And '2019-04-01'::date");
            sql.AppendLine("Order By time Desc");
            DataTable dt = new DataTable();
            new DBFactory().ExecuteDataTable(sql.ToString(), ref dt);
            if (dt.Rows.Count > 0)
            {
                dgv.DataSource = dt;
            }
            else
            {
                //登陆失败
                MessageBox.Show("根据条件查询不到记录", "查询", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].HeaderCell.Value = (dgv.RowCount - i).ToString();
                if (i % 2 == 0)
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                }
            }
        }
    }
}
