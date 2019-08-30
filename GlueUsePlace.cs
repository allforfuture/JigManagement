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
    public partial class GlueUsePlace : Form
    {
        public GlueUsePlace()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtModel.Text=txtLine.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtModel.Text == "" || txtLine.Text == "")
            {
                MessageBox.Show("所有信息不能是空值", "表格填写", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = string.Format("Insert Into use_place (use_place_id,model,line)" +
                " Values('P'||Nextval('use_place_id'), '{0}', '{1}')"
                , txtModel.Text, txtLine.Text);
            new DBFactory().ExecuteSQL(sql);
            MessageBox.Show("已添加记录", "数据库", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnClear_Click(sender, e);
        }
    }
}
