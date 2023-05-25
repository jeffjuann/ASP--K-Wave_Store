<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="KpopZtationLab.Views.Common.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Home</title>
        <link rel="stylesheet" href="../../Assets/css/homepage.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Image ID="Image2" runat="server" ImageUrl="~/Assets/images/banner.png" Width="100%" Height="50%"/>
    <br />
    <h2>Artists</h2>
    <br />
    <div class="container" runat="server">
        <%if (artists != null)
            { %>
            <asp:Repeater ID= "ArtistRepeater" runat="server">
                <ItemTemplate>
                    <a href="/Views/Common/ArtistDetail.aspx?ID=<%# Eval("ArtistID")%>" class="card">
                        <img src="<%#Eval("ArtistImage")%>" alt="no image found"/>
                        <h3 class="card-title"><%# Eval("ArtistName") %></h3>
                        <%--<h4 class=""><%= artist.type%></h4>--%>
                        <%--only show if they are admin--%>
                       <div class="row">
                             <asp:Button runat="server" Text="Update Artist" OnCommand="Update_Artist" CommandArgument='<%# Eval("ArtistID") %>' />
                             <asp:Button runat="server" Text="Delete Artist" OnCommand="Delete_Artist" CommandArgument='<%# Eval("ArtistID") %>' />
                       </div>
                    </a>
                </ItemTemplate>
            </asp:Repeater>
           
        <%} %>
        <a class="card" href="/Views/Admin/InsertArtists.aspx">   
            <img alt="Alternate Text" src="/Assets/images/defaultArtist.png"/>
        </a>
    </div>
</asp:Content>
