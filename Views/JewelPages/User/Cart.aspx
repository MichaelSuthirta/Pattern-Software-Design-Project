<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="JAwelsAndDiamonds.Cart" %>
<!DOCTYPE html>
<html>
<head>
    <title>Cart</title>
</head>
<body>
    <form runat="server">
        <h2>Your Cart</h2>
        <asp:GridView ID="CartGrid" runat="server" AutoGenerateColumns="False" OnRowCommand="CartGrid_RowCommand1">
            <Columns>
                <asp:BoundField DataField="JewelID" HeaderText="Jewel ID" />
                <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:C}" />
                <asp:BoundField DataField="BrandName" HeaderText="Brand" />
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="txtQuantity" runat="server" Text='<%# Bind("Quantity") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Subtotal" HeaderText="Subtotal" DataFormatString="{0:C}" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton runat="server" CommandName="UpdateItem" CommandArgument='<%# Container.DataItemIndex %>' Text="Update" />
                        <asp:LinkButton runat="server" CommandName="RemoveItem" CommandArgument='<%# Container.DataItemIndex %>' Text="Remove" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

        <br />
        <asp:Label ID="lblTotal" runat="server" Font-Bold="true"></asp:Label>
        <br /><br />

        <asp:Label ID="lblPaymentMethod" runat="server" Text="Select Payment Method:" AssociatedControlID="ddlPayment" /><br />
        <asp:DropDownList ID="ddlPayment" runat="server">
            <asp:ListItem Text="--Select Payment--" Value="" />
            <asp:ListItem Text="Credit Card" Value="Credit Card" />
            <asp:ListItem Text="PayPal" Value="PayPal" />
        </asp:DropDownList>
        <br /><br />

        <asp:Button ID="btnClearCart" runat="server" Text="Clear Cart" OnClick="btnClearCart_Click1" />
        <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click1" />
    </form>
</body>
</html>
