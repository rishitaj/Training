using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Purchase
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dt = dbConnection.GetSalesmanId();
            DDlSalesmanID.Items.Add("--Select--");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DDlSalesmanID.Items.Add(new ListItem(dt.Rows[i][0].ToString() + "-" + dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
            }
            DataTable DBCustomersDetails = dbConnection.GetCustomerDetails();
            GVCustomerDetails.DataSource = DBCustomersDetails;
            GVCustomerDetails.DataBind();


        }
        protected void saveBtnCust_Click(object sender, EventArgs e)
        {
            int salesmanID = Convert.ToInt32(DDlSalesmanID.SelectedValue);
            int grade = Convert.ToInt32(TxtGrade.Text);
            DbConnection dbobj = new DbConnection();
            dbobj.InsertCustDetails(TxtCustName.Text, TxtCity.Text,grade,salesmanID);
        }

        protected void resetBtnCust_Click(object sender, EventArgs e)
        {
            TxtCustName.Text = string.Empty;
            TxtCity.Text = string.Empty;
            TxtGrade.Text = string.Empty;
        }
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.UpdateCustomerDetails(Convert.ToInt32(LblCustID.Text), TxtCustName.Text, TxtCity.Text, Convert.ToInt32(TxtGrade.Text), Convert.ToInt32(DDlSalesmanID.Text));
            DataTable dtCustomerResults = dbConnection.GetCustomerDetails();
            GVCustomerDetails.DataSource = dtCustomerResults;
            GVCustomerDetails.DataBind();
        }

        protected void GVCustomerDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int customerID= Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt=dbConnection.GetCustomerDetailsbyID(customerID);
                TxtCustName.Text = dt.Rows[0][1].ToString();
                TxtCity.Text = dt.Rows[0][2].ToString();
                TxtGrade.Text = dt.Rows[0][3].ToString();
                LblCustID.Text = dt.Rows[0][0].ToString();
                DDlSalesmanID.Text = dt.Rows[0][4].ToString();
            }
            else
            {
                DbConnection dbConnection = new DbConnection();
                dbConnection.DeleteCustomerDetails(customerID);
                DataTable dtCustomerResults = dbConnection.GetCustomerDetails();
                GVCustomerDetails.DataSource = dtCustomerResults;
                GVCustomerDetails.DataBind();
            }
        }

        protected void GVCustomerDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GVCustomerDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

    }
}