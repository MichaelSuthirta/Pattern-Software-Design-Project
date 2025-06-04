<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="PSDLabProject.Views.JewelPages.User.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>Change Password</h2>

    <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />

    <table>
        <tr>
            <td>Old Password:</td>
            <td><asp:TextBox ID="txtOldPassword" runat="server" TextMode="Password" /></td>
        </tr>
        <tr>
            <td>New Password:</td>
            <td><asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password" /></td>
        </tr>
        <tr>
            <td>Confirm Password:</td>
            <td><asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" OnClick="btnChangePassword_Click" />
            </td>
        </tr>
    </table>
        </div>
    </form>
</body>
</html>
