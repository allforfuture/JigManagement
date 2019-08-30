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
    public partial class SmallGlueItem : Form
    {
        public SmallGlueItem()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtGlueID_Big.Text == "")
            {
                MessageBox.Show("所有信息不能是空值", "表格填写", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #region 检查母表存在
            string sql = string.Format(@"select glue_id from glue_parent where glue_parent_id='{0}'"
                        , txtGlueID_Big.Text);
            DataTable dt = new DataTable();
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("不存在该ID号", "查询数据库", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion
            sql = string.Format(@"Insert Into glue_child (glue_child_id,glue_parent_id,time,user_id)
                                values
                                (
	                                (Select Replace('S'||Current_date||(Substring('000'||Nextval('glue_child_id') From '....$')),'-',''))
	                                ,'{0}'
	                                ,now()
	                                ,'{1}'
                                )
                                    ;select glue_child_id
                                        from glue_child
                                        where user_id='{1}'
                                        order by time desc
                                        limit 1"
                        , txtGlueID_Big.Text,Login.User);
            dt = new DataTable();
            new DBFactory().ExecuteDataTable(sql, ref dt);
            txtGlueID.Text = dt.Rows[0][0].ToString();
            //MessageBox.Show("已添加记录", "数据库", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //打印操作
            //MessageBox.Show("打印");
            Print print = new Print(dt.Rows[0][0].ToString());
            try
            {
                print.Show();
                print.BtnPrint_Click(sender, e);
            }
            finally { print.Close(); }
        }
    }
}
