<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="EmployeeProjectApp.Project" %>

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
                    <td>Project Number - </td>
                    <td>
                        <asp:TextBox ID="txtProjectNo" runat="server"></asp:TextBox></td>
                    <td><asp:Button ID="SearchBtn" runat="server" Text="Search" OnClick="SearchBtn_Click" /></td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td><asp:TextBox ID="TxtName" runat= "server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Start Date</td>
                    <td><asp:TextBox ID="TxtStartDate" runat= "server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="SaveBtn" runat="server" Text="Save" OnClick="SaveBtn_Click" />
                        <asp:Button ID="ResetBtn" runat="server" Text="Reset" OnClick="ResetBtn_Click" style="height: 35px; width: 78px" />  
                        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" /> 
                    </td>
                </tr>
            </table>
            <div>

                <asp:GridView ID="GVProjectDetails" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVProjectDetails_SelectedIndexChanged" OnRowCommand="GVProjectDetails_RowCommand" OnRowDeleting="GVProjectDetails_RowDeleting" OnRowEditing="GVProjectDetails_RowEditing" >
                    <Columns>
                        <asp:BoundField DataField="projectNumber" HeaderText="Project Number" />
                        <asp:BoundField DataField="Projectname" HeaderText="Name" />
                        <asp:BoundField DataField="startDate" HeaderText="Start Date" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="LBtnEdit" runat="server" CommandArgument='<%# Eval("ProjectNumber") %>' CommandName="Edit">Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="LBtnDelete" runat="server" CommandArgument='<%# Eval("ProjectNumber") %>' CommandName="Delete">Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

            </div>

        </div>
    </form>
</body>
</html>
