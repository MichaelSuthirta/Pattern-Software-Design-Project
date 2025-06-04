<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master/Customer.Master" AutoEventWireup="true" CodeBehind="JewelViewer.aspx.cs" Inherits="PSDLabProject.Views.JewelPages.JewelViewer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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

</asp:Content>
