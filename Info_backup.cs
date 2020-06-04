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
    public partial class Info_backup : Form
    {
        public Info_backup(DataGridViewRow row, DataGridViewColumnCollection columns)
        {
            InitializeComponent();

            dgvData.AutoResizeColumns();
            //string sql = "select reason_cd,reason_text_cn from m_reason";
            string sql = "select reason_text_cn from m_reason";
            DataTable dt = new DataTable();
            new DBhelp().ExecuteDataTable(sql, ref dt);
            for (int i=0;i<dt.Rows.Count;i++)
            {
                cboReason.Items.Add(dt.Rows[i]["reason_text_cn"]);
            }

            dt = new DataTable();
            DataRow dr = dt.NewRow();
            for (int i = 0; i < columns.Count - 1; i++)
            {                
                dt.Columns.Add(columns[i].HeaderText);
                dr[i] = row.Cells[i].Value;
            }
            dt.Rows.Add(dr);
            dgvData.DataSource = dt;
            txtJigID.Text = dt.Rows[0]["serial_cd"].ToString();
            cboStatus.SelectedIndex = Convert.ToInt16(dt.Rows[0]["status_cd"].ToString());
            cboReason.Text = dt.Rows[0]["reason_text_cn"].ToString();
            txtComment.Text= dt.Rows[0]["comment_text"].ToString();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            dgvData.AutoResizeColumns();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //string sql = string.Format(@"UPDATE jig_status
            //                            SET created_at = now()
            //                            , reason_cd = (select reason_cd from m_reason where reason_text_cn = '{0}')
            //                            ,status_cd='{1}',comment_text='{2}'
            //                            WHERE serial_cd='{3}';
            //                            INSERT INTO jig_mainte_history (id, serial_cd, created_at, work_type, user_id)
            //                            VALUES (Nextval('jig_mainte_history_id_seq'), '{3}', now(), 'MAINTENANCE', '{4}')"
            //            ,cboReason.Text, cboStatus.SelectedIndex, txtComment.Text,txtJigID.Text,Login.User);

            string sql = string.Format(@"UPDATE jig_status
                                        SET created_at = now()
                                        , reason_cd = (select reason_cd from m_reason where reason_text_cn = '{0}')
                                        ,status_cd='{1}',comment_text='{2}'
                                        WHERE serial_cd='{3}';
                                        INSERT INTO jig_mainte_history (id, serial_cd, created_at, work_type, user_id)
                                        VALUES (Nextval('jig_mainte_history_id_seq'), '{3}', now(), 'MAINTENANCE', '{4}')"
                        , cboReason.Text, cboStatus.SelectedIndex, txtComment.Text, txtJigID.Text, Login.User);
            new DBhelp().ExecuteSQL(sql);
            Close();            
        }
    }
}
