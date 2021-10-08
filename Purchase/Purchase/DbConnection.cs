using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Data;

namespace Purchase
{
    public class DbConnection
    {
        //SalesMan Details
        #region salesman
        public void InsertSalesman(string salesmanName, string city, string commission)
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
            SqlCommand sqlCommand = new SqlCommand("select * from salesmen where salesman_id=" + salesmanID + "", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public DataTable GetSalesmanId()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS ; Initial Catalog=Purchase ; Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select Salesman_Id, Name from salesmen", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public void UpdateSalesman(int salesmanID, string salesmanName, string city, string commission)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS ; Initial Catalog=Purchase ; Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("update salesmen set name='" + salesmanName + "',city='" + city + "',commission=" + commission + " where salesman_id=" + salesmanID + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void DeleteSalesman(int salesmanID)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS ; Initial Catalog=Purchase ; Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("delete from salesmen where salesman_id=" + salesmanID + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion

        //CustomerDetails
        #region customers
        public void InsertCustDetails(string CustName, string CustCity, int Grade, int SalesmanID)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-Q8TO498\\SQLEXPRESS;Initial Catalog=Purchase;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("insert into Customer(Cust_Name, city, grade, Salesman_id) values('" + CustName + "','" + CustCity + "'," + Grade + " , " + SalesmanID + ")", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable GetCustomerDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS ; Initial Catalog=Purchase ; Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from Customer", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public DataTable GetCustomerID()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS ; Initial Catalog=Purchase ; Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select customer_ID,Cust_name,salesman_ID from Customer", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public DataTable GetsalesID(int CustomerID)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS ; Initial Catalog=Purchase ; Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select salesman_ID from Customer where customer_id=" + CustomerID + "", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }

        public DataTable GetCustomerDetailsbyID(int CustomerID)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS ; Initial Catalog=Purchase ; Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from Customer where Customer_ID = " + CustomerID + "", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public void UpdateCustomerDetails(int CustID, string CustName, string City, int grade, int SalesmanID)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS ; Initial Catalog=Purchase ; Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("update customer set cust_name='" + CustName + "',city='" + City + "',grade=" + grade + ",salesman_id=" + SalesmanID + " where customer_id=" + CustID + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void DeleteCustomerDetails(int CustomerID)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS;Initial Catalog=Purchase;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("delete from Customer where customer_id=" + CustomerID + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion

        //Orders
        #region orders
        public void InsertOrderDetails(double PurchaseAmt, string date, int CustomerID,int salesmanID)
        {
            string insertquery= "insert into orders(purch_amt, ord_date, customer_ID, salesman_id) values(" + PurchaseAmt + ",'" + date + "', " + CustomerID + ", " + salesmanID + ")";
            // SqlCommand sqlCommand = new SqlCommand("insert into orders(purch_amt, ord_date, customer_ID, salesman_id) values(" + PurchaseAmt + ",'" + date + "', " + CustomerID + ", "+salesmanID+")", sqlConnection);
            DataTable dt = ExecuteQry(insertquery);
        }
        public DataTable GetOrderDetails()
        {
            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS ; Initial Catalog=Purchase ; Integrated Security=True");
            //SqlCommand sqlCommand = new SqlCommand("select * from Orders", sqlConnection);
            string selectquery = "select * from Orders";
            DataTable dt = ExecuteQry(selectquery);
            return dt;
        }
        public DataTable GetOrderDetailsbyID(int OrderID)
        {
            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS ; Initial Catalog=Purchase ; Integrated Security=True");
            //SqlCommand sqlCommand = new SqlCommand("select * from Orders where ord_no=" + OrderID + "", sqlConnection);
            string selectquery = "select * from Orders where ord_no=" + OrderID + "";
            DataTable dt = ExecuteQry(selectquery);
            return dt;
        }
        public void DeleteOrderDetails(int OrderID)
        {
            string deletequery = "delete from Orders where ord_no=" + OrderID + "";
            DataTable dt = ExecuteQry(deletequery);
        }
        public void UpdateOrderDetails(int OrderID, double Purch_Amt, string Date, int CustID, int SalesmanID)
        {
            string updatequery = "update orders set Purch_amt = " + Purch_Amt + ", ord_date = '" + Date + "', Customer_ID = " + CustID + ", salesman_id = " + SalesmanID + " where ord_no = " + OrderID + "";
            DataTable dt = ExecuteQry(updatequery);
        }
        public DataTable ExecuteQry(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q8TO498\SQLEXPRESS; Initial Catalog = Purchase; Integrated Security = True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
 

        #endregion
    }
}