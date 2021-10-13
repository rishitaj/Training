using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace EmployeeProjectApp
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CalendarBirthday.Visible = false;
                CalendarHireDate.Visible = false;
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetDeptNo();
                DataTable dataTable = dbConnection.GetProjectNo();
                DropDownListDptNo.Items.Add("--Select--");
                DropDownListProjectNo.Items.Add("--Select--");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DropDownListDptNo.Items.Add(new ListItem(dt.Rows[i][0].ToString(), dt.Rows[i][0].ToString()));
                }
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DropDownListProjectNo.Items.Add(new ListItem(dataTable.Rows[i][0].ToString(), dataTable.Rows[i][0].ToString()));
                }
                DataTable dbempdetails = dbConnection.GetEmpDetails();
                GridViewEmployeeDetails.DataSource = dbempdetails;
                GridViewEmployeeDetails.DataBind();
            }
        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.InsertEmployeeDetails(TxtJobTitle.Text, TxtlstName.Text, TxtfirstName.Text, TxtGender.Text, TxtBirthday.Text, TxtHireDate.Text, Convert.ToInt32(DropDownListDptNo.Text), Convert.ToInt32(DropDownListProjectNo.Text));
            DataTable dbempdetails = dbConnection.GetEmpDetails();
            GridViewEmployeeDetails.DataSource = dbempdetails;
            GridViewEmployeeDetails.DataBind();
        }
        protected void ResetBtn_Click(object sender, EventArgs e)
        {
            TxtBirthday.Text = string.Empty;
            TxtfirstName.Text = string.Empty;
            TxtlstName.Text = string.Empty;
            TxtGender.Text = string.Empty;
            TxtHireDate.Text = string.Empty;
            TxtJobTitle.Text = string.Empty;
        }
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.UpdateEmpDetails(Convert.ToInt32(LblEmpNo.Text), TxtJobTitle.Text, TxtlstName.Text, TxtfirstName.Text, TxtGender.Text, TxtBirthday.Text, TxtHireDate.Text, Convert.ToInt32(DropDownListDptNo.Text), Convert.ToInt32(DropDownListProjectNo.Text));
            DataTable dt = dbConnection.GetEmpDetails();
            GridViewEmployeeDetails.DataSource = dt;
            GridViewEmployeeDetails.DataBind();
        }

        protected void ImgBtnCalender_Click(object sender, ImageClickEventArgs e)
        {
            CalendarBirthday.Visible = true;
        }

        protected void CalendarBirthday_SelectionChanged(object sender, EventArgs e)
        {
            DateTime date = CalendarBirthday.SelectedDate;
            TxtBirthday.Text = date.ToString("yyyy/MM/dd");
            CalendarBirthday.Visible = false;
        }
        protected void ImgBtnCalendarHireDate_Click(object sender, ImageClickEventArgs e)
        {
            CalendarHireDate.Visible = true;
        }

        protected void CalendarHireDate_SelectionChanged(object sender, EventArgs e)
        {
            DateTime date = CalendarHireDate.SelectedDate;
            TxtHireDate.Text = date.ToString("yyyy/MM/dd");
            CalendarHireDate.Visible = false;
        }

        protected void GridViewEmployeeDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int empno = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetEmpDetailsbyID(empno);
                TxtJobTitle.Text = dt.Rows[0][1].ToString();
                TxtlstName.Text = dt.Rows[0][2].ToString();
                TxtfirstName.Text = dt.Rows[0][3].ToString();
                TxtGender.Text = dt.Rows[0][4].ToString();
                TxtBirthday.Text = dt.Rows[0][5].ToString();
                TxtHireDate.Text = dt.Rows[0][6].ToString();
                DropDownListDptNo.Text = dt.Rows[0][7].ToString();
                DropDownListProjectNo.Text = dt.Rows[0][8].ToString();
                LblEmpNo.Text = dt.Rows[0][0].ToString();
                GridViewEmployeeDetails.DataSource = dt;
                GridViewEmployeeDetails.DataBind();

            }
            else
            {
                DbConnection dbConnection = new DbConnection();
                dbConnection.DeleteEmpDeatils(empno);
                DataTable dt = dbConnection.GetEmpDetails();
                GridViewEmployeeDetails.DataSource = dt;
                GridViewEmployeeDetails.DataBind();
            }
        }
        protected void GridViewEmployeeDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
        protected void GridViewEmployeeDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}