<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="EmployeeProjectApp.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Employee Number -</td>
                    <td>
                        <asp:Label ID="LblEmpNo" runat="server" Text="EmployeeNo"></asp:Label></td>
                </tr>
                <tr>
                    <td>Job Title</td>
                    <td><asp:TextBox ID="TxtJobTitle" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name</td>
                    <td><asp:TextBox ID="TxtlstName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>First Name</td>
                    <td><asp:TextBox ID="TxtfirstName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:TextBox ID="TxtGender" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Birthday</td>
                    <td><asp:TextBox ID="TxtBirthday" runat= "server"></asp:TextBox></td>
                    <td><asp:Calendar ID="CalendarBirthday" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="100px" OnSelectionChanged="CalendarBirthday_SelectionChanged" Width="110px">
                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                            <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar>
                        <asp:ImageButton ID="ImgBtnCalender" runat="server" Height="30px" OnClick="ImgBtnCalender_Click" style="margin-top: 0px" Width="30px" />
                    </td>
                </tr>
                <tr>
                    <td>Hire Date</td>
                    <td><asp:TextBox ID="TxtHireDate" runat= "server"></asp:TextBox></td>
                    <td><asp:Calendar ID="CalendarHireDate" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="100px" OnSelectionChanged="CalendarHireDate_SelectionChanged" Width="110px">
                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                            <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar>
                        <asp:ImageButton ID="ImgBtnCalendarHireDate" runat="server" Height="30px" style="margin-top: 0px" Width="30px" OnClick="ImgBtnCalendarHireDate_Click" />
                    </td>
                </tr>
                <tr>
                    <td>Department Number</td>
                    <td>
                        <asp:DropDownList ID="DropDownListDptNo" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>Project Number</td>
                    <td>
                        <asp:DropDownList ID="DropDownListProjectNo" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="SaveBtn" runat="server" Text="Save" OnClick="SaveBtn_Click" />
                        <asp:Button ID="ResetBtn" runat="server" Text="Reset" OnClick="ResetBtn_Click" />  
                        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" /> 
                    </td>
                </tr>
            </table>
            <div>
                <asp:GridView ID="GridViewEmployeeDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="GridViewEmployeeDetails_RowCommand" OnRowDeleting="GridViewEmployeeDetails_RowDeleting" OnRowEditing="GridViewEmployeeDetails_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="EmployeeNumber" HeaderText="Employee Number" />
                        <asp:BoundField DataField="job_title" HeaderText="Job Title" />
                        <asp:BoundField DataField="lastName" HeaderText="Last Name" />
                        <asp:BoundField DataField="firstName" HeaderText="First Name" />
                        <asp:BoundField DataField="gender" HeaderText="Gender" />
                        <asp:BoundField DataField="birthday" HeaderText="Birthday" />
                        <asp:BoundField DataField="hiredate" HeaderText="Hire Date" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="LBtnEdit" runat="server" CommandArgument='<%# Eval("EmployeeNumber") %>' CommandName="Edit">Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="LBtnDelete" runat="server" CommandArgument='<%# Eval("EmployeeNumber") %>' CommandName="Delete">Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
