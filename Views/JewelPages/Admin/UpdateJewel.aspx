<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateJewel.aspx.cs" Inherits="PSDLabProject.Views.JewelPages.Admin.UpdateJewel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <h1>Update Jewel</h1>
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
    <asp:Button ID="confirmButton" runat="server" Text="Confirm Update" OnClick="confirmButton_Click"/>
    <asp:Label ID="messageText" runat="server" Text=""></asp:Label>
</div>

</asp:Content>
