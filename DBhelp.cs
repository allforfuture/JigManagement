using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;

using Npgsql;
using System.Windows.Forms;

namespace JigManagement
{
    public class DBhelp
    {
        static string DbConnectstring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        NpgsqlConnection con;
        
        public int ExecuteSQL(string sql)
        {
            using (con = new NpgsqlConnection(DbConnectstring))
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                int result = cmd.ExecuteNonQuery();
                return result;
            }
        }

        public object ExecuteScalar(string sql)
        {
            using (con = new NpgsqlConnection(DbConnectstring))
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                return cmd.ExecuteScalar();
            }
        }

        public void ExecuteDataTable(string sql, ref DataTable dt)
        {
            using (con = new NpgsqlConnection(DbConnectstring))
            {
                try
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "数据库", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Tran(List<string> sql)
        {
            using (con = new NpgsqlConnection(DbConnectstring))
            {
                con.Open();
                NpgsqlTransaction tran = con.BeginTransaction();
                NpgsqlCommand cmd = new NpgsqlCommand() { Connection = con };
                try
                {
                    //cmd.CommandText = "Insert Into t_user Values('3','2','3','4','@')";
                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "Insert Into t_user Values('2','2','3','4','@')";
                    //cmd.ExecuteNonQuery();

                    foreach (string temp in sql)
                    {
                        cmd.CommandText = temp;
                        cmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message, "数据库事务", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void TranWithQuery(List<string> sql, ref DataTable dt)
        {
            using (con = new NpgsqlConnection(DbConnectstring))
            {
                con.Open();
                NpgsqlTransaction tran = con.BeginTransaction();
                NpgsqlCommand cmd = new NpgsqlCommand() { Connection = con };
                try
                {
                    foreach (string temp in sql)
                    {

                        if ((temp.Trim().ToUpper()).Contains("SELECT"))
                        {
                            cmd.CommandText = temp;
                            NpgsqlDataReader dr = cmd.ExecuteReader();
                            dt.Load(dr);
                            //dr.Close();
                            //con.Close(); 
                        }
                        else
                        {
                            cmd.CommandText = temp.Replace("@", "'" + dt.Rows[0][0].ToString() + "'");
                            cmd.ExecuteNonQuery();
                        }
                    }
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    dt = new DataTable();
                    MessageBox.Show(ex.Message, "数据库事务", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
