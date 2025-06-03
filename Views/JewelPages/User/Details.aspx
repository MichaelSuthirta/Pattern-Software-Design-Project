<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="PSDLabProject.Views.JewelPages.User.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Jewel Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Jewel Details</h1>
            <asp:Label ID="Label1" runat="server" Text="Jewel Name: "></asp:Label>
            <asp:Label ID="nameLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Jewel Category: "></asp:Label>
            <asp:Label ID="categoryLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Jewel Brand: "></asp:Label>
            <asp:Label ID="brandLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Country of Origin: "></asp:Label>
            <asp:Label ID="countryLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Jewel Class: "></asp:Label>
            <asp:Label ID="classLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Jewel Price: "></asp:Label>
            <asp:Label ID="priceLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Jewel Release Year: "></asp:Label>
            <asp:Label ID="yearLabel" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Quantity of item to buy: "></asp:Label>
            <asp:TextBox ID="qtyBox" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Button ID="addToCartButton" runat="server" Text="Add to Cart" OnClick="addToCartButton_Click"/>
            <br />
            <asp:Label ID="msgText" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
