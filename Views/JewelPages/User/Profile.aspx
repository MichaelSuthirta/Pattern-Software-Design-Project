<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master/Customer.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="PSDLabProject.Views.JewelPages.User.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
       <h2>Profile Information</h2>
       <asp:Label ID="lblEmail" runat="server" Text="Email: " />
       <asp:Label ID="lblEmailValue" runat="server" /><br />

       <asp:Label ID="lblUsername" runat="server" Text="Username: " />
       <asp:Label ID="lblUsernameValue" runat="server" /><br />

       <asp:Label ID="lblGender" runat="server" Text="Gender: " />
       <asp:Label ID="lblGenderValue" runat="server" /><br />

       <asp:Label ID="lblDOB" runat="server" Text="Date of Birth: " />
       <asp:Label ID="lblDOBValue" runat="server" /><br /><br />

       <asp:Button ID="btnRedirectChangePassword" runat="server" Text="Change Password"
       OnClick="btnRedirectChangePassword_Click" />
    </div>

</asp:Content>
