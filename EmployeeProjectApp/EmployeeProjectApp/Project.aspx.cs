using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EmployeeProjectApp
{
    public partial class Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dt = dbConnection.GetProjectDetails();
            GVProjectDetails.DataSource = dt;
            GVProjectDetails.DataBind();
        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.InsertProjectDetails(TxtName.Text, TxtStartDate.Text);
            DataTable dt = dbConnection.GetProjectDetails();
            GVProjectDetails.DataSource = dt;
            GVProjectDetails.DataBind();
        }
        protected void ResetBtn_Click(object sender, EventArgs e)
        {
            TxtName.Text = string.Empty;
            TxtStartDate.Text = string.Empty;
            txtProjectNo.Text = string.Empty;
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.UpdateProjectDetails(Convert.ToInt32(txtProjectNo.Text), TxtName.Text, TxtStartDate.Text);
            DataTable dt = dbConnection.GetProjectDetails();
            GVProjectDetails.DataSource = dt;
            GVProjectDetails.DataBind();
        }

        protected void GVProjectDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GVProjectDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GVProjectDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GVProjectDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int ProjectNo = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetProjectDetailsbyID(ProjectNo);
                TxtName.Text = dt.Rows[0][1].ToString();
                TxtStartDate.Text = dt.Rows[0][2].ToString();
                txtProjectNo.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                DbConnection dbConnection = new DbConnection();
                dbConnection.DeleteProjectDeatils(ProjectNo);
                DataTable dt = dbConnection.GetProjectDetails();
                GVProjectDetails.DataSource = dt;
                GVProjectDetails.DataBind();
            }
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            DataTable dt = db.GetProjectDetailsbyID(Convert.ToInt32(txtProjectNo.Text));
            GVProjectDetails.DataSource = dt;
            GVProjectDetails.DataBind();
        }

    }
}