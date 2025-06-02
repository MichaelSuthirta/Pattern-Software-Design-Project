<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JewelViewer.aspx.cs" Inherits="PSDLabProject.Views.JewelPages.ViewJewels" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Jewel Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>View Jewels</h1>
            <asp:GridView ID="UserJewelGridview" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="JewelID"/>
                    <asp:BoundField HeaderText="Name" DataField="JewelName"/>
                    <asp:BoundField HeaderText="Price" DataField="JewelPrice"/>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="detailButton" runat="server" Text="Details"
                                OnCommand="detailButton_Command" CommandArgument='<%#Eval("JewelID")%>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
