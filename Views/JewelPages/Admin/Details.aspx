<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master/Admin.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="PSDLabProject.Views.JewelPages.Admin.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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

    <asp:Button ID="updateButton" runat="server" Text="Update Details" OnClick="updateButton_Click"/>
    <br />
    <asp:Button ID="deleteButton" runat="server" Text="Remove Jewel" OnClick="deleteButton_Click"/>
    <br />
    <asp:Label ID="msgLabel" runat="server" Text=""></asp:Label>
</div>

</asp:Content>
