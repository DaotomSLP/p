using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Vanpheng_Jewelry
{
    class Database
    {

        string Id;
        SqlDataReader dr;
        SqlCommand comm;
        DataTable dataTable;
        public string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\work\windowbase\Vanpheng Jewelry\Vanpheng Jewelry\Database1.mdf;Integrated Security=True";

        public SqlDataReader LoadData(String Q)
        {
            SqlConnection sqlConn = new SqlConnection(connstr);
            sqlConn.Open();
            comm = new SqlCommand(Q, sqlConn);
            dr = comm.ExecuteReader();
            dataTable = new DataTable();
            return dr;
        }

        public void InsertData(String Q)
        {
            SqlConnection sqlConn = new SqlConnection(connstr);
            sqlConn.Open();
            comm = new SqlCommand(Q, sqlConn);
            comm.ExecuteNonQuery();
        }

        public void UpdateData(String Q)
        {
            SqlConnection sqlConn = new SqlConnection(connstr);
            sqlConn.Open();
            comm = new SqlCommand(Q, sqlConn);
            comm.ExecuteNonQuery();
        }

        public void DeleteData(String Q)
        {
            SqlConnection sqlConn = new SqlConnection(connstr);
            sqlConn.Open();
            comm = new SqlCommand(Q, sqlConn);
            comm.ExecuteNonQuery();
        }
        public string generateBillNo(string Q)
        {
            SqlConnection sqlConn = new SqlConnection(connstr);
            sqlConn.Open();
            comm = new SqlCommand(Q, sqlConn);
            SqlDataReader dr = comm.ExecuteReader();
            dataTable = new DataTable();
            while (dr.Read())
            {
                Id = dr[0].ToString();
            }
            dr.Close();
            int Plus;
            try
            {
                Plus = Convert.ToInt32(Id) + 1;
            }
            catch
            {
                Plus = 100000;
            }
            return Plus.ToString();
        }
        public string generateId(String Q)
        {
            SqlConnection sqlConn = new SqlConnection(connstr);
            sqlConn.Open();
            comm = new SqlCommand(Q, sqlConn);
            SqlDataReader dr = comm.ExecuteReader();
            dataTable = new DataTable();
            while (dr.Read())
            {
               Id = dr[0].ToString();
            }
            dr.Close();
            int Plus;
            try
            {
                 Plus = Convert.ToInt32(Id) + 1;
            }
            catch
            {
                 Plus = 1;
            }
            return Plus.ToString();
        }
    }
}
