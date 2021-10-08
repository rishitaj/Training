using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Purchase
{
    public partial class Salesman : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbObj = new DbConnection();
            DataTable dtSalesmanResult = dbObj.GetSalesman();
            GVSalesmanDetails.DataSource = dtSalesmanResult;
            GVSalesmanDetails.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            string salesmanname = "";
            string salesmancity = "";
            string commission = "";
            salesmanname = TxtSalesmanName.Text;
            salesmancity = TxtSalesmanCity.Text;
            commission = TxtSalesmanCommission.Text;
            DbConnection DbObj = new DbConnection();
            DbObj.InsertSalesman(salesmanname, salesmancity, commission);

            DataTable dtSalesmanResults = DbObj.GetSalesman();
            GVSalesmanDetails.DataSource = dtSalesmanResults;
            GVSalesmanDetails.DataBind();

        }

        protected void ResetBtn_Click(object sender, EventArgs e)
        {

        }

        protected void GVsalesmanDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int salesmanid = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName =="Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetSalesmanbyID(salesmanid);
                TxtSalesmanName.Text = dt.Rows[0][1].ToString();
                TxtSalesmanCity.Text = dt.Rows[0][2].ToString();
                TxtSalesmanCommission.Text = dt.Rows[0][3].ToString();
                LblsalesmanID.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                DbConnection dbConnection = new DbConnection();
                dbConnection.DeleteSalesman(salesmanid);
                DataTable dtSalesmanResults = dbConnection.GetSalesman();
                GVSalesmanDetails.DataSource = dtSalesmanResults;
                GVSalesmanDetails.DataBind();
            }
        }
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.UpdateSalesman(Convert.ToInt32(LblsalesmanID.Text), TxtSalesmanName.Text, TxtSalesmanCity.Text, TxtSalesmanCommission.Text);
            DataTable dtSalesmanResults = dbConnection.GetSalesman();
            GVSalesmanDetails.DataSource = dtSalesmanResults;
            GVSalesmanDetails.DataBind();
        }
        protected void GVSalesmanDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GVSalesmanDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }


    }
}