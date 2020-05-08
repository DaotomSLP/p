using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System.IO;

namespace Vanpheng_Jewelry
{
    class Database
    {

        string Id;
        SqlDataReader dr;
        SqlCommand comm;
        DataTable dataTable;
        string current_path = Directory.GetCurrentDirectory();


        public SqlDataReader LoadData(String Q)
        {
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + current_path + @"\Database1.mdf;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connstr);
            sqlConn.Open();
            comm = new SqlCommand(Q, sqlConn);
            dr = comm.ExecuteReader();
            dataTable = new DataTable();
            return dr;
        }

        public void InsertData(String Q)
        {
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + current_path + @"\Database1.mdf;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(connstr);
            sqlConn.Open();
            comm = new SqlCommand(Q, sqlConn);
            comm.ExecuteNonQuery();
        }

        public void UpdateData(String Q)
        {
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + current_path + @"\Database1.mdf;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(connstr);
            sqlConn.Open();
            comm = new SqlCommand(Q, sqlConn);
            comm.ExecuteNonQuery();
        }

        public void DeleteData(String Q)
        {
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + current_path + @"\Database1.mdf;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(connstr);
            sqlConn.Open();
            comm = new SqlCommand(Q, sqlConn);
            comm.ExecuteNonQuery();
        }
        public string generateBillNo(string Q)
        {
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + current_path + @"\Database1.mdf;Integrated Security=True";
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
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + current_path + @"\Database1.mdf;Integrated Security=True";
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

        public DataTable loadReport(string sql)
        {
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + current_path + @"\Database1.mdf;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(connstr);
            sqlConn.Open();
            comm = new SqlCommand(sql, sqlConn);
            dr = comm.ExecuteReader();
            dataTable = new DataTable();
            dataTable.Load(dr);
            return dataTable;
            
        }
        
        public string Login(string username, string password)
        {
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + current_path + @"\Database1.mdf;Integrated Security=True";
            string Q = "SELECT UserName FROM Employee WHERE UserName = '"+username+"' AND Password = '"+password+"'";
            SqlConnection sqlConn = new SqlConnection(connstr);
            sqlConn.Open();
            comm = new SqlCommand(Q, sqlConn);
            dr = comm.ExecuteReader();

            username = "notUser";

            while (dr.Read())
            {
                username = dr[0].ToString();
                globalVal.User = username;
            }
            
            return username;
        }
    }
}
