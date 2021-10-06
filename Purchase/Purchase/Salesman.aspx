<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salesman.aspx.cs" Inherits="Purchase.Salesman" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
<%--                <tr>
                    <td>Salesman ID</td>
                    <td><asp:TextBox ID="TxtSalesmanID" runat="server"></asp:TextBox></td>
                </tr>--%>
                <tr>
                    <td>Salesman Name</td>
                    <td><asp:TextBox ID="TxtSalesmanName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City</td>
                    <td><asp:TextBox ID="TxtSalesmanCity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Commission</td>
                    <td><asp:TextBox ID="TxtSalesmanCommission" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="SaveBtn" runat="server" Text="Save" OnClick="SaveBtn_Click" />
                        <asp:Button ID="ResetBtn" runat="server" Text="Reset" OnClick="ResetBtn_Click" /></td>
                </tr>
            </table>
            <div>
                <asp:GridView ID="GVSalesmanDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="GVsalesmanDetails_RowCommand" OnRowEditing="GVSalesmanDetails_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="salesmanID" HeaderText="Salesman_ID" />
                        <asp:BoundField DataField="SalesmanName" HeaderText="SalesmanName" />
                        <asp:BoundField DataField="salesmanCity" HeaderText="SalesmanCity" />
                        <asp:BoundField DataField="commission" HeaderText="Commission" SortExpression="commission" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="LBtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("salesman_id") %>'>Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="LBtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("salesman_id") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
