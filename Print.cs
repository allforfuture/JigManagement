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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
        public Print(string ID)
        {
            InitializeComponent();
            txtID0.Text = ID;
        }

        public void BtnPrint_Click(object sender, EventArgs e)
        {
            if (txtID0.Text == "")
            {
                MessageBox.Show("ID号不能为空", "打印标签", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string model = txtID0.Text.Substring(0, 1);
            string sql;
            if (model == "B")
            {
                sql = string.Format(@"SELECT type.model,type.assy,type.name,type.lot,type.exp,big.time+(type.exp || 'H')::interval,big.lot,big.glue_parent_id
                                            FROM glue_parent as big
                                            left join glue_type as type
                                            on big.glue_id = type.glue_id
                                            where big.glue_parent_id='{0}'"
                                    , txtID0.Text);
            }
            else if (model == "S")
            {
                sql = string.Format(@"select type.model,type.assy,type.name,type.lot,type.exp,small.time+(type.exp || 'H')::interval,big.lot,small.glue_child_id
                                            from glue_child as small
                                            left join glue_parent as big
                                            on small.glue_parent_id=big.glue_parent_id
                                            left join glue_type as type
                                            on big.glue_id=type.glue_id
                                            where small.glue_child_id='{0}'"
                                    , txtID0.Text);
            }
            else
            {
                MessageBox.Show("大胶水或小胶水的ID格式不正确", "胶水ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable dt = new DataTable();
            new DBhelp().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count == 1)
            {
                txt1.Text = dt.Rows[0][0].ToString();
                txt2.Text = dt.Rows[0][1].ToString();
                txt3.Text = dt.Rows[0][2].ToString();
                txt4.Text = dt.Rows[0][3].ToString();
                txt5.Text = dt.Rows[0][4].ToString();
                txt6.Text = dt.Rows[0][5].ToString();
                txtLot2.Text = txtLot1.Text = dt.Rows[0][6].ToString();
                txtID2.Text = txtID1.Text = dt.Rows[0][7].ToString();
                picQRcode1.Image = BarcodeHelper.QRcode(txtID1.Text, picQRcode1.Width, picQRcode1.Height);
                picQRcode2.Image = BarcodeHelper.QRcode(txtID2.Text, picQRcode2.Width, picQRcode2.Height);
            }
            else
            {
                MessageBox.Show("数据异常", "数据库", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            TxtBorderStyle(BorderStyle.None);
            pnlPrint.Enabled = true;
            Bitmap bitmap = new Bitmap(pnlPrint.Width, pnlPrint.Height);
            pnlPrint.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            TxtBorderStyle(BorderStyle.Fixed3D);
            pnlPrint.Enabled = false;
            return;
            void TxtBorderStyle(BorderStyle borderStyle)
            {
                txt1.BorderStyle =
                txt2.BorderStyle =
                txt3.BorderStyle =
                txt4.BorderStyle =
                txt5.BorderStyle =
                txt6.BorderStyle =
                txtLot1.BorderStyle =
                txtID1.BorderStyle =
                txtLot2.BorderStyle =
                txtID2.BorderStyle = borderStyle;
            }
        }
    }
}
