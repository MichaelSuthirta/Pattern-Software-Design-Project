<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserJewelViewer.aspx.cs" Inherits="PSDLabProject.Views.JewelPages.ViewJewels" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>View Jewels</h1>
            <asp:GridView ID="UserJewelGridview" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Name" DataField="JewelName"/>
                    <asp:BoundField HeaderText="Category Name" DataField="CategoryName"/>
                    <asp:BoundField HeaderText="Brand Name" DataField="BrandName"/>
                    <asp:BoundField HeaderText="Country of Origin" DataField="BrandCountry"/>
                    <asp:BoundField HeaderText="Class" DataField="BrandClass"/>
                    <asp:BoundField HeaderText="Price" DataField="JewelPrice"/>
                    <asp:BoundField HeaderText="Release Year" DataField="JewelReleaseYear"/>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="buyButton" runat="server" Text="Buy" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
