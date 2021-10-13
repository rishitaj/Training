using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeProjectApp
{
    public class DbConnection
    {
        public DataTable Query(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-S89M8M3B\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
        public void InsertDepartmentDetails(string DepartmentName)
        {
            string insertquery = "insert into tblDepartment(DepartmentName) values('" + DepartmentName + "')";
            DataTable dt = Query(insertquery);
        }
        public DataTable GetDepartmentDetails()
        {
            string getquery = "select * from tblDepartment";
            DataTable dt = Query(getquery);
            return dt;
        }
        public DataTable GetDepartmentDetailsbyID(int DepartmentNumber)
        {
            string getquery = "select * from tblDepartment where departmentNumber=" + DepartmentNumber + "";
            DataTable dt = Query(getquery);
            return dt;
        }
        public void UpdateDeptDetails(int deptno, string deptName)
        {
            string updateQuery = "update tbldepartment set DepartmentName='" + deptName + "' where departmentNumber=" + deptno + "";
            DataTable dt = Query(updateQuery);
        }
        public void DeleteDeptDetails(int deptNo)
        {
            string deletequery = "delete from tbldepartment where departmentNumber=" + deptNo + "";
            DataTable dt = Query(deletequery);
        }
        public void InsertProjectDetails(string ProjectName, string StartDate)
        {
            string insertquery = "insert into tblProject(ProjectName, Startdate) values('" + ProjectName + "', '" + StartDate + "')";
            DataTable dt = Query(insertquery);
        }
        public DataTable GetProjectDetails()
        {
            string getquery = "select * from tblProject";
            DataTable dt = Query(getquery);
            return dt;
        }
        public DataTable GetProjectDetailsbyID(int ProjectNumber)
        {
            string getquery = "select * from tblProject where ProjectNumber=" + ProjectNumber + "";
            DataTable dt = Query(getquery);
            return dt;
        }
        public void UpdateProjectDetails(int projectNo, string projectname, string startdate)
        {
            string updateQuery = "update tblproject set projectName='" + projectname + "', startdate='" + startdate + "' where projectNumber=" + projectNo + "";
            DataTable dt = Query(updateQuery);
        }
        public void DeleteProjectDeatils(int ProjectNo)
        {
            string deletequery = "delete from tblproject where projectNumber=" + ProjectNo + "";
            DataTable dt = Query(deletequery);
        }
        public void InsertEmployeeDetails(string JobTitle, string lastName, string FirstName, string Gender, string birthday, string hiredate, int departmentno, int projectno)
        {
            string insertquery = "insert into tblEmployee(job_title, lastName,firstName,gender,birthday,hiredate,departmentNumber,projectNumber) values('" + JobTitle + "','" + lastName + "', '" + FirstName + "', '" + Gender + "', '" + birthday + "','" + hiredate + "', " + departmentno + "," + projectno + ")";
            DataTable dt = Query(insertquery);
            //SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP - S89M8M3B\SQLEXPRESS; Initial Catalog = EmployeeDB; Integrated Security = True");
            //SqlCommand sqlCommand = new SqlCommand("insert into tblemployee(job_Title,lastName,firstName,gender,birthday,hiredate,departmentNumber,projectNumber) values ('" + JobTitle + "', '" + lastName + "','" + FirstName + "','" + Gender + "', '" + birthday + "','" + hiredate + "', " + departmentno + "," + projectno + ")", sqlConnection);
            //sqlConnection.Open();
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
        }
        public DataTable GetEmpDetails()
        {
            string getquery = "select * from tblEmployee";
            DataTable dt = Query(getquery);
            return dt;
        }
        public DataTable GetEmpDetailsbyID(int EmpNumber)
        {
            string getquery = "select * from tblEmployee where EmployeeNumber=" + EmpNumber + "";
            DataTable dt = Query(getquery);
            return dt;
        }
        public DataTable GetDeptNo()
        {
            string getquery = "select departmentnumber from tbldepartment";
            DataTable dt = Query(getquery);
            return dt;
        }
        public DataTable GetProjectNo()
        {
            string getquery = "select projectNumber from tblproject";
            DataTable dt = Query(getquery);
            return dt;
        }
        public void UpdateEmpDetails(int EmpNo, string jobTitle, string lastname, string firstname, string gender, string birthday, string hiredate, int deptno, int projectno)
        {
            string updateQuery = "update tblEmployee set job_title='" + jobTitle + "', lastname='" + lastname + "', firstname='" + firstname + "', gender='" + gender + "', birthday='" + birthday + "', hiredate='" + hiredate + "', departmentNumber=" + deptno + ", ProjectNumber=" + projectno + " where EmployeeNumber=" + EmpNo + "";
            DataTable dt = Query(updateQuery);
        }
        public void DeleteEmpDeatils(int EmpNo)
        {
            string deletequery = "delete from tblEmployee where EmployeeNumber=" + EmpNo + "";
            DataTable dt = Query(deletequery);
        }
    }
}