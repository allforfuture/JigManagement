using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JigManagement.Jig
{
    public partial class JigAdd : Form
    {
        public JigAdd()
        {
            InitializeComponent();
            cboDataTypeID_Add.Items.AddRange(Config.Control.ComboBox_DataTypeID);
            cboLine_Add.Items.AddRange(Config.Control.ComboBox_Line);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtJigID_Add.Text==""|| cboDataTypeID_Add.Text==""|| cboLine_Add.Text=="")
            {

                MessageBox.Show("需要添加的信息没填满", "添加", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
           

            string sql = string.Format(@"INSERT INTO m_jig (serial_cd, created_at, datatype_id,line_cd, user_id,exist_flag)
                            VALUES ('{0}',  Now(), '{1}', '{2}','{3}',True)"
                       , txtJigID_Add.Text, cboDataTypeID_Add.Text, cboLine_Add.Text, Login.User);

            try
            {
                if (new DBhelp().ExecuteSQL(sql) > 0)
                {
                    string APIbody = @"{
	                                ""serial_cd"": """ + txtJigID_Add.Text + @""",
                                    ""datatype_id"": """ + cboDataTypeID_Add.Text + @""",
                                    ""line_cd"": """ + cboLine_Add.Text + @""",
	                                ""status"": ""0"",
	                                ""reason_cd"": """"
                                }";
                    if (!API.API.HttpResponse(APIbody, "PUT"))
                    {
                        { MessageBox.Show("网页响应失败", "网页PUT", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        return;
                    }
                    MessageBox.Show("添加成功");
                }
                else { MessageBox.Show("添加失败"); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message,"数据库",MessageBoxButtons.OK,MessageBoxIcon.Error); }           
        }
    }
}
