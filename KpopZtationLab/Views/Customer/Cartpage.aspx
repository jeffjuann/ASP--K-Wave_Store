<%@ Page Title="CartPage" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cartpage.aspx.cs" Inherits="KpopZtationLab.Views.Pages.Cartpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cart</h1>
    <div class="left">
        <%foreach (var cart in carts){ %>
            <asp:CheckBox ID="chk<%=cart.AlbumID %>"/>
            <img src="<%=cart.Album.AlbumImage %>" alt="Alternate Text" />
            <div class="column">
                <h5><%=cart.Album.AlbumName %></h5>
                <h6><%=cart.Album.AlbumDescription %></h6>
                <h6><%=cart.Album.AlbumPrice %> </h6>

            </div>
        <%} %>
    </div>
    <div class="right">
        <h3>Total Transacation</h3>
        <h4>Sub Price: </h4>
        <h4>Tax: 10%</h4>
        <h4>Total Price: 110$</h4>
        <asp:Button ID="Button1" runat="server" Text="Check Out" />
    </div>
</asp:Content>
