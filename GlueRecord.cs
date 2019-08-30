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
    public partial class GlueRecord : Form
    {
        Dictionary<string, bool> dic = new Dictionary<string, bool>();
        public GlueRecord()
        {
            InitializeComponent();
        }

        private void BigGlueReturn_Load(object sender, EventArgs e)
        {
            //添加使用地点
            DataTable dt = new DataTable();
            string sql = "Select Distinct(model) From use_place";
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                string[] strArr = dt.AsEnumerable().Select(d => d.Field<string>(0)).ToArray();
                cboModel.Items.AddRange(strArr);
            }
            else
            {
                MessageBox.Show("没有记录，请添加使用地点后再装载", "数据库查询", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            //添加胶水操作
            dt = new DataTable();
            sql = "Select name,need_write From action";
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dic.Add((string)dr["name"], (bool)(dr["need_write"]));
                    cboAction.Items.Add((string)dr["name"]);
                }
            }
            else
            {
                MessageBox.Show("没有动作记录", "数据库查询", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            //添加验证机种下拉框
            dt = new DataTable();
            sql = "Select Distinct(model) From glue_type";
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                string[] strArr = dt.AsEnumerable().Select(d => d.Field<string>(0)).ToArray();
                cboCheckModel.Items.AddRange(strArr);
            }
            else
            {
                MessageBox.Show("没有记录，请添加胶水类型后再装载", "数据库查询", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void CboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboLine.Items.Clear();
            DataTable dt = new DataTable();
            string sql = string.Format("Select Distinct(line)" +
                " From use_place" +
                " Where model ='{0}'"
                , cboModel.Text);
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                string[] strArr = dt.AsEnumerable().Select(d => d.Field<string>(0)).ToArray();
                cboLine.Items.AddRange(strArr);
            }
        }
        private void CboAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dic[cboAction.Text])
            {
                gbxCheck.Enabled = true;
            }
            else
            {
                gbxCheck.Enabled = false;
                cboCheckModel.SelectedIndex = cboModel.SelectedIndex = -1;
            }
        }

        private void CboCheckModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCheckAssy.Items.Clear();
            DataTable dt = new DataTable();
            string sql = string.Format("Select Distinct(assy)" +
                " From glue_type" +
                " Where model ='{0}'"
                , cboCheckModel.Text);
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                string[] strArr = dt.AsEnumerable().Select(d => d.Field<string>(0)).ToArray();
                cboCheckAssy.Items.AddRange(strArr);
            }
            CboCheckAssy_SelectedIndexChanged(sender, e);
        }

        private void CboCheckAssy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCheckName.Items.Clear();
            DataTable dt = new DataTable();
            string sql = string.Format("Select Distinct(name)" +
                " From glue_type" +
                " Where model ='{0}'" +
                " And assy='{1}'"
                , cboCheckModel.Text, cboCheckAssy.Text);
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                string[] strArr = dt.AsEnumerable().Select(d => d.Field<string>(0)).ToArray();
                cboCheckName.Items.AddRange(strArr);
            }
            CboCheckName_SelectedIndexChanged(sender, e);
        }

        private void CboCheckName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCheckLot.Items.Clear();
            DataTable dt = new DataTable();
            string sql = string.Format("Select Distinct(Lot)" +
                " From glue_type" +
                " Where model ='{0}'" +
                " And assy='{1}'" +
                " And name='{2}'"
                , cboCheckModel.Text, cboCheckAssy.Text, cboCheckName.Text);
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                string[] strArr = dt.AsEnumerable().Select(d => d.Field<string>(0)).ToArray();
                cboCheckLot.Items.AddRange(strArr);
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || cboAction.Text == "")
            {
                MessageBox.Show("“胶水ID”和“操作”不能是空值", "表格填写", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gbxCheck.Enabled)
            {
                if (cboModel.Text == "" || cboLine.Text == "" || cboCheckModel.Text == "" || cboCheckAssy.Text == "" || cboCheckName.Text == "" || cboCheckLot.Text == "")
                {
                    MessageBox.Show("“验证”内信息不能是空值", "表格填写", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            string model = txtID.Text.Substring(0, 1), sql;

            #region 检验存在（且选择“使用”下拉框后，ID号的胶水和选的胶水是一样）才可以继续
            switch (model)
            {
                case "B":
                    if (gbxCheck.Enabled)
                    {
                        sql = string.Format(@"with type as
                                    (select glue_id
                                    from glue_type
                                    where model='{0}'
                                    and assy='{1}'
                                    and name='{2}'
                                    and lot='{3}')
                                    select replace(big.glue_id, type.glue_id, '')
                                    from type,glue_parent big
                                    where big.glue_parent_id='{4}'"
    , cboCheckModel.Text, cboCheckAssy.Text, cboCheckName.Text, cboCheckLot.Text, txtID.Text);
                    }
                    else
                    {
                        sql = string.Format(@"select '' from glue_parent where glue_parent_id='{0}'", txtID.Text);
                    }
                    break;
                case "S":
                    if (gbxCheck.Enabled)
                    {
                        sql = string.Format(@"with type as
                                    (select glue_id
                                    from glue_type
                                    where model='{0}'
                                    and assy='{1}'
                                    and name='{2}'
                                    and lot='{3}')
                                    select replace(big.glue_id, type.glue_id, '')
                                    from type,glue_child small
                                    left join glue_parent big
                                    on small.glue_parent_id=big.glue_parent_id
                                    where small.glue_child_id='{4}'"
   , cboCheckModel.Text, cboCheckAssy.Text, cboCheckName.Text, cboCheckLot.Text, txtID.Text);
                    }
                    else
                    {
                        sql = string.Format(@"select '' from glue_child where glue_child_id='{0}'", txtID.Text);
                    }
                    break;
                default:
                    MessageBox.Show("大胶水或小胶水的ID格式不正确", "胶水ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }
            DataTable dt = new DataTable();
            new DBFactory().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() != "")
                {
                    MessageBox.Show("输入的ID号与选择的胶水类型不一致", "验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("不存在该ID号", "查询数据库", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            #region 插入记录
            if (gbxCheck.Enabled)
            {
                sql = string.Format(@"insert into record (id,use_place_id,action,time,user_id)
                                    values 
                                    ('{0}' 
                                    ,(select use_place_id
                                    from use_place
                                    where model='{1}'
                                    and line='{2}')
                                    ,'{3}'
                                    ,now()
                                    ,'{4}')"
                                    , txtID.Text, cboModel.Text, cboLine.Text, cboAction.Text, Login.User);
            }
            else
            {
                sql = string.Format(@"insert into record (id,action,time,user_id)
                                    values ('{0}','{1}',now(),'{2}')"
                                    , txtID.Text, cboAction.Text, Login.User);
            }
            new DBFactory().ExecuteSQL(sql);
            #endregion
            MessageBox.Show("已添加记录", "数据库", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}