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
            }
            else
            {

            }
        }
        protected void GVSalesmanDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}