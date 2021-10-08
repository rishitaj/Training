using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Purchase
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetCustomerID();
                DropDownListCustomerID.Items.Add("--Select--");
                DropDownListSalesmanID.Items.Add("--Select--");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DropDownListCustomerID.Items.Add(new ListItem(dt.Rows[i][0].ToString() + "-" + dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
                    DropDownListSalesmanID.Items.Add(new ListItem(dt.Rows[i][2].ToString(), dt.Rows[i][2].ToString()));
                }
                DataTable DbOrderDetails = dbConnection.GetOrderDetails();
                GVOrderDetails.DataSource = DbOrderDetails;
                GVOrderDetails.DataBind();
            }

        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            int customerID = Convert.ToInt32(DropDownListCustomerID.SelectedValue.ToString());
            int salesmanID = Convert.ToInt32(DropDownListSalesmanID.SelectedValue.ToString());
            DbConnection dbConnection = new DbConnection();
            dbConnection.InsertOrderDetails(Convert.ToDouble(TxtPurchAmt.Text), TxtOrdDate.Text, customerID, salesmanID);
        }
        protected void ResetBtn_Click(object sender, EventArgs e)
        {
            TxtOrdDate.Text = string.Empty;
            TxtPurchAmt.Text = string.Empty;
            //DropDownListSalesmanID.Text = string.Empty;
            //DropDownListCustomerID.Text = string.Empty;
        }
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.UpdateOrderDetails(Convert.ToInt32(LblOrderID.Text), Convert.ToDouble(TxtPurchAmt.Text), TxtOrdDate.Text, Convert.ToInt32(DropDownListCustomerID.Text), Convert.ToInt32(DropDownListSalesmanID.Text));
            DataTable dtOrderResults = dbConnection.GetOrderDetails(); 
            GVOrderDetails.DataSource = dtOrderResults;
            GVOrderDetails.DataBind();
        }

        protected void GVOrderDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int OrderID = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit") 
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetOrderDetailsbyID(OrderID);
                TxtPurchAmt.Text = dt.Rows[0][1].ToString();
                TxtOrdDate.Text = dt.Rows[0][2].ToString();
                DropDownListCustomerID.Text = dt.Rows[0][3].ToString();
                DropDownListSalesmanID.Text = dt.Rows[0][4].ToString();
                LblOrderID.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                DbConnection dbConnection = new DbConnection();
                dbConnection.DeleteOrderDetails(OrderID);
                DataTable dt = dbConnection.GetOrderDetails();
                GVOrderDetails.DataSource = dt;
                GVOrderDetails.DataBind();
            }

        }

        protected void GVOrderDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GVOrderDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}