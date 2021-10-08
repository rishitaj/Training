<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="Purchase.Orders" %>

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
                    <td>Order No.</td>
                    <td><asp:TextBox ID="txtOrdID" runat="server"></asp:TextBox></td>
                </tr>--%>
                <tr>
                    <td>Purchase Amount</td>
                    <td><asp:TextBox ID="TxtPurchAmt" runat="server"></asp:TextBox>
                        <asp:Label ID="LblOrderID" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Order Date</td>
                    <td><asp:TextBox ID="TxtOrdDate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Customer ID</td>
                    <td>
                        <asp:DropDownList ID="DropDownListCustomerID" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>Salesman ID</td>
                    <td>
                        <asp:DropDownList ID="DropDownListSalesmanID" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="SaveBtn" runat="server" Text="Sumbit" OnClick="SaveBtn_Click" />
                        <asp:Button ID="ResetBtn" runat="server" Text="Reset" OnClick="ResetBtn_Click" />
                        <asp:Button ID="UpdateBtn" runat="server" OnClick="UpdateBtn_Click" Text="Update" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GVOrderDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="GVOrderDetails_RowCommand" OnRowDeleting="GVOrderDetails_RowDeleting" OnRowEditing="GVOrderDetails_RowEditing" >
            <Columns>
                <asp:BoundField DataField="ORD_NO" HeaderText="OrderNo" />
                <asp:BoundField DataField="PURCH_AMT" HeaderText="PurchaseAmount" />
                <asp:BoundField DataField="ORD_DATE" HeaderText="OrderDate" />
                <asp:BoundField DataField="Customer_ID" HeaderText="CustomerID" />
                <asp:BoundField DataField="Salesman_ID" HeaderText="SalesmanID" />
                <asp:TemplateField HeaderText="EDIT">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit" CommandArgument='<%# Eval("ORD_NO") %>'>EDIT</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="DELETE">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Delete" CommandArgument='<%# Eval("ORD_NO") %>'>DELETE</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
