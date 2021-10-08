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
<%--                <tr>
                    <td>Customer ID</td>
                    <td><asp:TextBox ID="TxtCustID" runat="server"></asp:TextBox></td>
                </tr>--%>
                <tr>
                    <td>Cutomer Name</td>
                    <td><asp:TextBox ID="TxtCustName" runat="server"></asp:TextBox>
                        <asp:Label ID="LblCustID" runat="server" Text="Label"></asp:Label>
                    </td>
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
                    <td>
                        <asp:DropDownList ID="DDlSalesmanID" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="saveBtnCust" runat="server" Text="Save" OnClick="saveBtnCust_Click" /> 
                        <asp:Button ID="resetBtnCust" runat="server" Text="Reset" OnClick="resetBtnCust_Click" />
                        <asp:Button ID="Button1" runat="server" OnClick="UpdateBtn_Click" Text="Update" />
                    </td>
                </tr>
            </table>
            <div>
                <asp:GridView ID="GVCustomerDetails" runat="server" AutoGenerateColumns="False" OnRowEditing="GVCustomerDetails_RowEditing" OnRowCommand="GVCustomerDetails_RowCommand" OnRowDeleting="GVCustomerDetails_RowDeleting" >
                    <Columns>
                        <asp:BoundField DataField="customer_id" HeaderText="CustomerID" />
                        <asp:BoundField DataField="Cust_Name" HeaderText="Customer_Name" />
                        <asp:BoundField DataField="City" HeaderText="Customer_City" />
                        <asp:BoundField DataField="grade" HeaderText="Grade" />
                        <asp:BoundField DataField="salesman_id" HeaderText="SalesmanID" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="LBtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("Customer_id") %>'>Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="LBtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("Customer_id") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

        </div>
    </form>
</body>
</html>
