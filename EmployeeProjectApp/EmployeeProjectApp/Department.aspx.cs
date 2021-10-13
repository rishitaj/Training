using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EmployeeProjectApp
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dt = dbConnection.GetDepartmentDetails();
            GridViewDepartmentDetails.DataSource = dt;
            GridViewDepartmentDetails.DataBind();
        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.InsertDepartmentDetails(TxtName.Text);
            DataTable dt = dbConnection.GetDepartmentDetails();
            GridViewDepartmentDetails.DataSource = dt;
            GridViewDepartmentDetails.DataBind();

        }
        protected void ResetBtn_Click(object sender, EventArgs e)
        {
            TxtName.Text = string.Empty;
        }
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.UpdateDeptDetails(Convert.ToInt32(txtDeptNo.Text), TxtName.Text);
            DataTable dt = dbConnection.GetDepartmentDetails();
            GridViewDepartmentDetails.DataSource = dt;
            GridViewDepartmentDetails.DataBind();
        }
        protected void GridViewDepartmentDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int deptNo = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetDepartmentDetailsbyID(deptNo);
                TxtName.Text = dt.Rows[0][1].ToString();
                txtDeptNo.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                DbConnection dbConnection = new DbConnection();
                dbConnection.DeleteDeptDetails(deptNo);
                DataTable dt = dbConnection.GetDepartmentDetails();
                GridViewDepartmentDetails.DataSource = dt;
                GridViewDepartmentDetails.DataBind();
            }
        }
        protected void GridViewDepartmentDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
        protected void GridViewDepartmentDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void GridViewDepartmentDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            DataTable dt = db.GetDepartmentDetailsbyID(Convert.ToInt32(txtDeptNo.Text));
            GridViewDepartmentDetails.DataSource = dt;
            GridViewDepartmentDetails.DataBind();
        }

    }
}