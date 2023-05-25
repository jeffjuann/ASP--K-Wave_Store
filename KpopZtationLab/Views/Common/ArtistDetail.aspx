<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="KpopZtationLab.Views.Common.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../Assets/css/artistDetail.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="left" runat="server">
            <img src="<%= artist.ArtistImage %>" width="300" alt="no image found" />
            <h2 class="artist-title"><%= artist.ArtistName %></h2>
            <%--<h3 class="artist-type">Singer</h3>--%>
        </div>
        <div class="right" runat="server">
            <% foreach (var album in albums) {%>
            <div class="card">
                <img src="<%=album.AlbumImage%>" alt="no image found" width="150"/>
                <div class="column">
                    <h4><%=album.AlbumName %></h4>
                    <h5><%=album.AlbumDescription %></h5>
                    <h5>$<%= album.AlbumPrice %></h5>
                </div>
                <a href="/Views/Common/AlbumDetail.aspx?AlbumID=<%=album.AlbumID%>&&ArtistID=<%=artist.ArtistID %>">More Details</a>
            </div>
            <%} %>
        </div>
    </div>
</asp:Content>
