<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master/Guest.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="PSDLabProject.Views.LoginRegisterPages.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Register Page</h1>
            <div>
                <asp:Label ID="EmailLabel" runat="server" Text="Email : "></asp:Label>
                <asp:TextBox ID="EmailTextBox" runat="server" TextMode="Email"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="UsernameLabel" runat="server" Text="Username : "></asp:Label>
                <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="PasswordLabel" runat="server" Text="Password : "></asp:Label>
                <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="ConfirmPasswordLabel" runat="server" Text="Confirm Password : "></asp:Label>
                <asp:TextBox ID="ConfirmPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <asp:RadioButton ID="maleRadioButton" runat="server" Text="Male" GroupName="GenderGroup"/>
                <asp:RadioButton ID="femaleRadioButton" runat="server" Text="Female" GroupName="GenderGroup"/>
            </div>
            <div>
                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            </div>
            <div>
                <asp:TextBox ID="CalendarTextBox" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" />
                <asp:Label ID="MessageLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>
</asp:Content>
