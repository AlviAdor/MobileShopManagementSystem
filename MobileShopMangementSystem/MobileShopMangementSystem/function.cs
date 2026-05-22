using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MobileShopMangementSystem
{
    internal class function
    {
        private readonly string connStr = "Data Source=192.168.0.48,1433;Initial Catalog=MobileShop;User ID=sa;Password=YourStrongPassword123;TrustServerCertificate=True;";

        protected SqlConnection GetSqlConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connStr;
            return con;
        }

        public DataSet GetData(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        public void SetData(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = GetSqlConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Processed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public SqlDataReader GetForCombo(string query, SqlParameter[] parameters = null)
        {
            SqlConnection con = GetSqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return sdr;
        }

        public void CloseConnection()
        {
            SqlConnection con = GetSqlConnection();
            if (con.State == ConnectionState.Open)
                con.Close();
        }

    }
}
