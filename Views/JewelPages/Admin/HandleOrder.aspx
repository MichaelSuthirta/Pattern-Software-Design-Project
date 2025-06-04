<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master/Admin.Master" AutoEventWireup="true" CodeBehind="HandleOrder.aspx.cs" Inherits="PSDLabProject.Views.JewelPages.Admin.HandleOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="False" OnRowCommand="gvOrders_RowCommand">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" />
                <asp:BoundField DataField="UserID" HeaderText="User ID" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="btnAction" runat="server" 
                            CommandName="Handle"
                            CommandArgument='<%# string.Format("{0};{1}", Eval("TransactionID"), Eval("Status")) %>'
                            Text='<%# 
                                    Eval("Status").ToString() == "Payment Pending" ? "Confirm Payment" :
                                    (Eval("Status").ToString() == "Shipment Pending" ? "Ship Package" : "Waiting for user confirmation...")
                                    %>'
                            Enabled='<%# !Eval("Status").ToString().Equals("Arrived") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </div>

</asp:Content>
