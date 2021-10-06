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
                <tr>
                    <td>Order No.</td>
                    <td><asp:TextBox ID="txtOrdID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Purchase Amount</td>
                    <td><asp:TextBox ID="TxtPurchAmt" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Order Date</td>
                    <td><asp:TextBox ID="TxtOrdDate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Customer ID</td>
                    <td><asp:TextBox ID="TxtCustID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salesman ID</td>
                    <td><asp:TextBox ID="TxtSalesmanID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="Button1" runat="server" Text="Sumbit" />
                        <asp:Button ID="Button2" runat="server" Text="Reset" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
