<%@ Page enableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="KpopZtationLab.Views.Common.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../Assets/css/artistDetail.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content" style="padding: 64px 96px;">
    <div style="display: flex; flex-direction: column;">
        <img src="<%= "../../"+artist.ArtistImage %>" width="300" alt="no image found" />
		<br />
        <h1 class="artist-title"><%= artist.ArtistName %></h1>
    </div>
    <div class="right" runat="server">
            <div style="display: flex; flex-wrap: wrap; justify-content: flex-start;">
                <asp:Repeater ID="AdminAlbumsRepeater" runat="server">
                    <ItemTemplate>
                        <a href="<%# "AlbumDetail.aspx?ID="+ Eval("AlbumID") %>" style="color: black">
                            <div id="productCard" style="
                                width: 250px;
                                border: none;
                                border-radius: 4px;
                                margin: 10px;
                                padding: 10px;
                                background-color: #fff;
                                box-shadow: 0 2px 4px rgba(0, 0, 0, 0.3);
                                display: flex;
                                flex-direction: column;
                                gap: 12px;
                                align-items: center">
                                <asp:Image ID="ArtistImage" runat="server" ImageUrl='<%# "../../"+Eval("AlbumImage") %>' style="width: 100%; height: 200px; object-fit: cover; border-radius: 5px;" />
                                <h2 style="margin-top: 10px; margin-bottom: 0;"><%# Eval("AlbumName") %></h2>
                                <% if (role == "ADMN")
                                { %>
                                <div style="top: 10px; left: 10px; display: flex; gap: 4px;">
                                    <asp:Button ID="Button1" runat="server" Text="Edit" CommandName="Edit" CommandArgument='<%# Eval("AlbumID") %>' style="
                                        background: #F2BE22;
                                        padding: 2px 4px;
                                        border: none;
                                        border-radius: 4px;" />
                                    <asp:Button ID="Button2" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("AlbumID") %>' style="
                                        background: #F24C3D;
                                        padding: 2px 4px;
                                        border: none;
                                        border-radius: 4px;" />
                                </div>
                                <% } %>
                            </div>
                        </a>
                    </ItemTemplate>
                </asp:Repeater>
                <% if (role == "ADMN") %>
                <% { %>
                <asp:Button ID="InsertAlbum" runat="server" Text="Insert New Album" OnClick="NavigateToInsertAlbum_Click" style="
                        width: 250px;
                        height: 304.4px;
                        border: none;
                        border-radius: 4px;
                        margin: 10px;
                        padding: 10px;
                        background-color: #31de7a;
                        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.3);
                        display: flex;
                        flex-direction: column;
                        gap: 12px;
                        justify-content: center;
                        font-weight: bold;
                        align-items: center"/>
                <% } %>
            </div>
    </div>
</div>


</asp:Content>
