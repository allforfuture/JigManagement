using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.Text.RegularExpressions;

namespace JigManagement
{
    public partial class GlueType : Form
    {
        public GlueType()
        {
            InitializeComponent();
        }

        private void TxtExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //不能回格和删除
            //Regex regex = new Regex("[^0-9]+");
            //e.Handled = regex.IsMatch(e.KeyChar.ToString());

            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtModel.Text = txtAssy.Text = txtName.Text = txtLot.Text = txtExp.Text = txtColor.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtModel.Text == ""||txtAssy.Text==""||txtName.Text==""||txtLot.Text==""||txtExp.Text==""||txtColor.Text=="")
            {
                MessageBox.Show("所有信息不能是空值","表格填写",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            string sql = string.Format("Insert Into glue_type (glue_id,model,assy,name,lot,exp,color)" +
                " Values('G'||Nextval('glue_type_id'), '{0}', '{1}', '{2}', '{3}', '{4}', '{5}')"
                , txtModel.Text, txtAssy.Text, txtName.Text, txtLot.Text, txtExp.Text, txtColor.Text);
            new DBFactory().ExecuteSQL(sql);
            MessageBox.Show("已添加记录","数据库",MessageBoxButtons.OK,MessageBoxIcon.Information);
            BtnClear_Click(sender, e);            
        }
    }
}