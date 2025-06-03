<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJewel.aspx.cs" Inherits="PSDLabProject.Views.JewelPages.Admin.AddJewel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Add Jewel</h1>
            <asp:Label ID="Label1" runat="server" Text="Jewel Name: "></asp:Label>
            <asp:TextBox ID="nameText" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Jewel Category: "></asp:Label>
            <asp:DropDownList ID="categoryDropdown" runat="server"></asp:DropDownList>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Jewel Brand: "></asp:Label>
            <asp:DropDownList ID="brandDropdown" runat="server"></asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Jewel Price: "></asp:Label>
            <asp:TextBox ID="priceText" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Release Year: "></asp:Label>
            <asp:TextBox ID="yearText" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="addButton" runat="server" Text="Add Jewel" OnClick="addButton_Click"/>
            <asp:Label ID="messageText" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
