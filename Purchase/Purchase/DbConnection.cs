using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Purchase
{
    public class DbConnection
    {
        public void InsertSalesman(string salesmanName, string city,string commission)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-Q8TO498\\SQLEXPRESS;Initial Catalog=Purchase;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("insert into salesmen(Name, city, commission) values('" + salesmanName + "','" + city + "'," + commission + ")", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable GetSalesman()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS ; Initial Catalog=Purchase ; Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from salesmen", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public DataTable GetSalesmanbyID(int salesmanID)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS ; Initial Catalog=Purchase ; Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from salesmen where salesman_id="+salesmanID+"", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
    }
}