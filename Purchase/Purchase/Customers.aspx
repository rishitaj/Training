<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="Purchase.Customers" %>

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
                    <td>Customer ID</td>
                    <td><asp:TextBox ID="TxtCustID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Cutomer Name</td>
                    <td><asp:TextBox ID="TxtCustName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City</td>
                    <td><asp:TextBox ID="TxtCity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Grade</td>
                    <td><asp:TextBox ID="TxtGrade" runat="server"></asp:TextBox></td>
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
