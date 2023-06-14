<%@ Page Title="CartPage" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cartpage.aspx.cs" Inherits="KpopZtationLab.Views.Pages.Cartpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cart</h1>
    <div class="left">
         <asp:GridView ID="CartGridView" runat="server" 
            AutoGenerateColumns="false">
            <Columns>
                <asp:CheckBoxField headerText="Product To be checked out" />
                <asp:BoundField HeaderText="AlbumID" DataField="AlbumID" />
                <asp:BoundField HeaderText="Artist name" DataField="Album.ArtistName" />
                <asp:ImageField DataImageUrlField="AlbumImage" HeaderText="Artist Image"/>
                <asp:BoundField HeaderText="id" DataField="AlbumName" />
                <asp:BoundField HeaderText="id" DataField="AlbumPrice" />

 <%--               <asp:CommandField 
                    HeaderText="Actions" 
                    ShowDeleteButton="True" 
                    ShowEditButton="True" 
                    ShowSelectButton="True" />--%>
            </Columns>
        </asp:GridView>
            
    </div>
    <div class="right">
        <h3>Total Transacation</h3>
        <h4>Sub Price: </h4>
        <h4>Tax: 10%</h4>
        <h4>Total Price: 110$</h4>
        <asp:Button ID="Button1" runat="server" Text="Check Out" />
    </div>
</asp:Content>
