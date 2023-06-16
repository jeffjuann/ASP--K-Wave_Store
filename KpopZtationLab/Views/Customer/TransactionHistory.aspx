<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="KpopZtationLab.Views.Pages.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Transaction History</h3>
    <asp:GridView ID="TransactionHistoryGridView" runat="server">
           <Columns>
               <asp:BoundField HeaderText="Transaction ID" DataField="TransactionHeader.TransactionID" />
               <asp:BoundField HeaderText="Transaction Date" DataField="TransactionHeader.TransactionDate" />               
               <asp:BoundField HeaderText="Customer Name" DataField="TransactionHeader.Customer.CustomerName" />
               <asp:TemplateField HeaderText="Album's Image">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Album.AlbumImage") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
               <asp:BoundField HeaderText="Album's Name" DataField="Album.AlbumName" />
               <asp:BoundField HeaderText="album’s Quantity" DataField="Qty" />
               <asp:BoundField HeaderText="album’s Price" DataField="Album.AlbumPrice" />
           </Columns>
    </asp:GridView>
</asp:Content>
