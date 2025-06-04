<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master/Guest.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="PSDLabProject.Views.LoginRegisterPages.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="EmailLabel" runat="server" Text="Email : "></asp:Label>
        <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="PasswordLabel" runat="server" Text="Password : "></asp:Label>
        <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
    </div>
    <div>
        <asp:CheckBox ID="LoginCheckbox" runat="server" Text="Remember Me" />
        <asp:Label ID="MessageLabel" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
