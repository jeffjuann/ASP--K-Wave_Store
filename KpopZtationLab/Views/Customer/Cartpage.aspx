<%@ Page Title="CartPage" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cartpage.aspx.cs" Inherits="KpopZtationLab.Views.Pages.Cartpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cart</h1>
    <div class="left">
         <asp:GridView ID="CartGridView" runat="server" 
             OnRowDeleting="CartGridView_RowDeleting"
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Album ID" DataField="Album.AlbumID" />
                <%--<asp:ImageField DataImageUrlField="Album.AlbumImage" HeaderText="Album Image"/>--%>
                <asp:BoundField HeaderText="Album Name" DataField="Album.AlbumName" />
                <asp:BoundField HeaderText="Quantity" DataField="Qty" />
                <asp:BoundField HeaderText="Album Price" DataField="Album.AlbumPrice" />
                <asp:CommandField 
                    HeaderText="Actions" 
                    ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
            
    </div>
    <div class="right">
        <h3>Total Transacation</h3>
        <h4>Sub Price: </h4>
        <h4>Tax: 10%</h4>
        <h4>Total Price: 110$</h4>
        <asp:Button ID="CheckOutBtn" runat="server" Text="Check Out" OnClick="CheckOutBtn_Click"/>
    </div>
</asp:Content>
