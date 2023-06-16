<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="KpopZtationLab.Views.Pages.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="TransactionHistoryGridView" runat="server">
           <Columns>
               <asp:BoundField HeaderText="Transaction ID" DataField="ID" />
               <asp:BoundField HeaderText="Transaction Date" DataField="Date" />               
               <asp:BoundField HeaderText="Customer Name" DataField="CustomerName" />
               <asp:BoundField HeaderText="Courier" DataField="CustomerName" />
               <asp:BoundField HeaderText="Album's Picture" DataField="CustomerName" />
               <asp:BoundField HeaderText="Album's Name" DataField="CustomerName" />
               <asp:BoundField HeaderText="album’s Quantity" DataField="CustomerName" />
               <asp:BoundField HeaderText="album’s Price" DataField="CustomerName" />
           </Columns>
    </asp:GridView>
</asp:Content>
