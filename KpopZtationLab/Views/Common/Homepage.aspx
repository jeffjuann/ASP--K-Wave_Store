    <%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="KpopZtationLab.Views.Common.Homepage" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <title>Home</title>
            <link rel="stylesheet" href="../../Assets/css/homepage.css" type="text/css" />
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="contentContainer" style="padding: 64px 96px;">
            <h2>Our Artists</h2>
            <div style="display: flex; flex-wrap: wrap; justify-content: flex-start;">
                <asp:Repeater ID="AdminArtistsRepeater" runat="server" OnItemCommand="AdminArtistsRepeater_ItemCommand">
                    <ItemTemplate>
                        <a href="<%# "ArtistDetail.aspx?ID="+Eval("ArtistID") %>" style="color: black">
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
                                <asp:Image ID="ArtistImage" runat="server" ImageUrl='<%# "../../"+Eval("ArtistImage") %>' style="width: 100%; height: 200px; object-fit: cover; border-radius: 5px;" />
                                <h2 style="margin-top: 10px; margin-bottom: 0;"><%# Eval("ArtistName") %></h2>
                                <% if (role == "ADMN")
                                { %>
                                <div style="top: 10px; left: 10px; display: flex; gap: 4px;">
                                    <asp:Button ID="EditButton" runat="server" Text="Edit" CommandName="Edit" CommandArgument='<%# Eval("ArtistID") %>' style="
                                        background: #F2BE22;
                                        padding: 2px 4px;
                                        border: none;
                                        border-radius: 4px;" />
                                    <asp:Button ID="DeleteButton" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("ArtistID") %>' style="
                                        background: #F24C3D;
                                        padding: 2px 4px;
                                        border: none;
                                        border-radius: 4px;" />
                                </div>
                                <%} %>
                            </div>
                        </a>
                    </ItemTemplate>
                </asp:Repeater>
                <% if (role == "ADMN") %>
                <% { %>
                <a ID="CreateArtist" runat="server" href="~/Views/Admin/InsertArtists.aspx" style="color: black;">
                    <div style="
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
                        align-items: center">
                        <asp:Image ID="ArtistImage" runat="server" ImageUrl="../../Assets/Images/defaultArtist.png" style="width: 100%; height: 200px; object-fit: cover; border-radius: 5px;" />
                        <h2 style="margin-top: 10px; margin-bottom: 0;">Add New Artist</h2>
                    </div>
                </a>
                <% } %>
            </div>
    </asp:Content>
