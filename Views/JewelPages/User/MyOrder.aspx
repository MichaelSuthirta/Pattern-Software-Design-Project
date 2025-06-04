<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master/Customer.Master" AutoEventWireup="true" CodeBehind="MyOrder.aspx.cs" Inherits="PSDLabProject.Views.JewelPages.User.MyOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>My Transactions</h2>
        <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="False" OnRowCommand="gvOrders_RowCommand">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Date" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:BoundField DataField="PaymentMethod" HeaderText="Payment Method" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnDetails" runat="server" CommandName="ViewDetails" CommandArgument='<%# Eval("TransactionID") %>' Text="View Details" />
                        <asp:LinkButton ID="btnConfirm" runat="server" CommandName="Confirm" CommandArgument='<%# Eval("TransactionID") %>' Text="Confirm" Visible='<%# Eval("Status").ToString() == "Arrived" %>' />
                        <asp:LinkButton ID="btnReject" runat="server" CommandName="Reject" CommandArgument='<%# Eval("TransactionID") %>' Text="Reject" Visible='<%# Eval("Status").ToString() == "Arrived" %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
</asp:Content>
