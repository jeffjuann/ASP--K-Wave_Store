<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="KpopZtationLab.Views.Pages.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="TransactionHistoryGridView" runat="server">
           <Columns>
               <asp:BoundField HeaderText="Transaction ID" DataField="TransactionHeader.TransactionID" />
               <asp:BoundField HeaderText="Transaction Date" DataField="TransactionHeader.TransactionDate" />               
               <asp:BoundField HeaderText="Customer Name" DataField="TransactionHeader.Customer.CustomerName" />
               <asp:BoundField HeaderText="Album's Picture" DataField="Album.AlbumImage" />
               <asp:BoundField HeaderText="Album's Name" DataField="Album.AlbumName" />
               <asp:BoundField HeaderText="album’s Quantity" DataField="TransactionDetails.Qty" />
               <asp:BoundField HeaderText="album’s Price" DataField="Album.AlbumPrice" />
           </Columns>
    </asp:GridView>
</asp:Content>
