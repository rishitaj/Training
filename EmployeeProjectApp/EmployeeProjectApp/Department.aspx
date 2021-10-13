<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="EmployeeProjectApp.Department" %>

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
                    <td>Department Number - </td>
                    <td>
                        <asp:TextBox ID="txtDeptNo" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="SearchBtn" runat="server" Text="Search" OnClick="SearchBtn_Click" /></td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td><asp:TextBox ID="TxtName" runat= "server"></asp:TextBox></td>
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
                <asp:GridView ID="GridViewDepartmentDetails" runat="server" AutoGenerateColumns="False"  OnRowCommand="GridViewDepartmentDetails_RowCommand" OnRowEditing="GridViewDepartmentDetails_RowEditing" OnRowDeleting="GridViewDepartmentDetails_RowDeleting" OnSelectedIndexChanged="GridViewDepartmentDetails_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="departmentNumber" HeaderText="Department Number" />
                        <asp:BoundField DataField="departmentName" HeaderText="Name" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="LBtnEdit" runat="server" CommandArgument='<%# Eval("DepartmentNumber") %>' CommandName="Edit">Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="LBtnDelete" runat="server" CommandArgument='<%# Eval("DepartmentNumber") %>' CommandName="Delete">Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

        </div>
    </form>
</body>
</html>
