<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="PSDLabProject.Views.JewelPages.User.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
