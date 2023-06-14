<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="KpopZtationLab.Views.Common.AlbumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content">
         <header>
              <div class="left">
                  <img src="<%=album.AlbumImage %>" alt="Alternate Text" />
            </div>
            <div class="right">
                <div class="flex">
                    <div class="column">
                        <h1>Title</h1>
                        <h2>By <%=artist.ArtistName %></h2>
                    </div>
                     <div class="column">
                         <h2><%=album.AlbumPrice %>$</h2>
                         <h3>Stock: <%=album.AlbumStock %></h3>
                    </div>
                </div>
                <h3>Description</h3>
                <div class="flex">
                    <h3>Quantity</h3>
                    <div class="flex-group">
                        <%--- 0 +--%>
                        <asp:Button ID="decreaseProduct" runat="server" Text="-" OnClick="decreaseProduct_Click"/>
                         <asp:TextBox ID="quantityTxt" runat="server"><%=quantity %></asp:TextBox>
                        <asp:Button ID="addProduct" runat="server" Text="+" OnClick="addProduct_Click"/>                        <asp:Button ID="Button3" runat="server" Text="Button" />
                    </div>
                </div>
                <div class="flex">
                    <asp:Button ID="addToCartBtn" runat="server" Text="Add to cart" OnClick="addToCartBtn_Click"/>
                    <asp:Button ID="Button2" runat="server" Text="Buy Now" />
                </div>
            </div>
        </header>
         <main runat="server">
            <%--populate--%>
             <%foreach (var album in albums)
                 { %>
             <a href="/Views/Common/AlbumDetail.aspx?AlbumID=<%=album.AlbumID%>&&ArtistID=<%=artist.ArtistID %>">>
                 <img src="<%= album.AlbumImage%>" alt="Alternate Text" />
                 <div class="column">
                     <h3><%=album.AlbumName %></h3>
                     <h3><%=album.AlbumDescription %></h3>
                 </div>
             </a>
             <%} %>
         </main>
    </div>
</asp:Content>
