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
    public partial class BigGlueItem : Form
    { 
        public BigGlueItem()
        {
            InitializeComponent();            
        }        

        private void BigGlueIn_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select Distinct(model) From glue_type";            
            new DBFactory().ExecuteDataTable(sql, ref dt);            
            if (dt.Rows.Count > 0)
            {
                string[] strArr = dt.AsEnumerable().Select(d => d.Field<string>(0)).ToArray();
                cboModel.Items.AddRange(strArr);
            }
            else
            {
                MessageBox.Show("没有记录，请添加胶水类型后再装载", "数据库查询", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void CboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboAssy.Items.Clear();
            DataTable dt = new DataTable();
            string sql = string.Format("Select Distinct(assy)" +
                " From glue_type" +
                " Where model ='{0}'"
                , cboModel.Text);
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                string[] strArr = dt.AsEnumerable().Select(d => d.Field<string>(0)).ToArray();
                cboAssy.Items.AddRange(strArr);
            }
            CboAssy_SelectedIndexChanged( sender,  e);
        }

        private void CboAssy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboName.Items.Clear();
            DataTable dt = new DataTable();
            string sql = string.Format("Select Distinct(name)" +
                " From glue_type" +
                " Where model ='{0}'" +
                " And assy='{1}'"
                , cboModel.Text, cboAssy.Text);
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                string[] strArr = dt.AsEnumerable().Select(d => d.Field<string>(0)).ToArray();
                cboName.Items.AddRange(strArr);
            }
            CboName_SelectedIndexChanged( sender,  e);
        }

        private void CboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboLot.Items.Clear();
            DataTable dt = new DataTable();
            string sql = string.Format("Select Distinct(Lot)" +
                " From glue_type" +
                " Where model ='{0}'" +
                " And assy='{1}'" +
                " And name='{2}'"
                , cboModel.Text, cboAssy.Text,cboName.Text);
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                string[] strArr = dt.AsEnumerable().Select(d => d.Field<string>(0)).ToArray();
                cboLot.Items.AddRange(strArr);
            }
            CboLot_SelectedIndexChanged( sender,  e);
        }

        private void CboLot_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExp.Items.Clear();
            cboColor.Items.Clear();
            DataTable dt = new DataTable();
            string sql = string.Format("Select Exp,Color" +
                " From glue_type" +
                " Where model ='{0}'" +
                " And assy='{1}'" +
                " And name='{2}'" +
                " And lot='{3}'"
                , cboModel.Text, cboAssy.Text, cboName.Text,cboLot.Text);
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                string[] strArr = dt.AsEnumerable().Select(d => d.Field<string>(0)).ToArray();
                cboExp.Items.AddRange(strArr);
                strArr = dt.AsEnumerable().Select(d => d.Field<string>(1)).ToArray();
                cboColor.Items.AddRange(strArr);
                cboExp.Text = dt.Rows[0][0].ToString();
                cboColor.Text = dt.Rows[0][1].ToString();
            }
        }


        private void BtnSave_Big_Click(object sender, EventArgs e)
        {
            if (cboModel.Text == "" || cboAssy.Text == "" || cboName.Text == "" || cboLot.Text == "" || cboExp.Text == "" || cboColor.Text == "" || txtLot.Text == "")
            {
                MessageBox.Show("所有信息不能是空值", "表格填写", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = string.Format(@"Insert Into glue_parent (glue_parent_id,glue_id,time,user_id,lot)
                                        Values
                                        ((Select Replace('B'||Current_date||(Substring('000'||Nextval('glue_parent_id') From '....$')),'-','')), 
		                                        ( Select glue_id
		                                        From glue_type
		                                        Where model='{0}'
		                                        And assy='{1}'
		                                        And name='{2}'
		                                        And lot='{3}'
		                                        And exp='{4}'
		                                        And color='{5}'),                                        
                                        Now(),
                                        '{6}'
                                        ,'{7}')
                                        ;select glue_parent_id
                                        from glue_parent
                                        where user_id='{6}'
                                        and lot='{7}'
                                        order by time desc
                                        limit 1"
            , cboModel.Text, cboAssy.Text, cboName.Text, cboLot.Text, cboExp.Text, cboColor.Text, Login.User, txtLot.Text);

            //new DBFactory().ExecuteSQL(sql);
            DataTable dt = new DataTable();
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