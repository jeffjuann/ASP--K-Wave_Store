<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="KpopZtationLab.Views.Common.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../Assets/css/artistDetail.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div style="display:flex;flex-direction:column">
            <h5>Artist's Image</h5>
            <br />
            <img src="<%= artist.ArtistImage %>" width="300" alt="no image found" />
            <br />
            <h5>Artis's Name</h5>
            <br />
            <h2 class="artist-title"><%= artist.ArtistName %></h2>
            <br />
        </div>
        <div class="right" runat="server">
            <%if (role == "ADMN") 
                { %>
                    <asp:Button ID="InsertAlbum" runat="server" Text="Insert New Album" OnClick="NavigateToInsertAlbum_Click" />
                    <asp:GridView ID="AlbumListGridView" runat="server"
                        AutoGenerateColumns="false"
                        OnRowDeleting="AlbumListGridView_RowDeleting"
                        OnRowEditing="AlbumListGridView_RowEditing"
                        OnSelectedIndexChanging="AlbumListGridView_SelectedIndexChanging">
                        <Columns>
                            <asp:BoundField HeaderText="id" DataField="AlbumID" />
                            <asp:ImageField DataImageUrlField="AlbumImage" HeaderText="Album Image"/>
                            <asp:BoundField DataField="AlbumName" HeaderText="Album Name" />
                            <asp:BoundField DataField="AlbumDescription" HeaderText="Album Description" />
                            <asp:BoundField DataField="AlbumPrice" HeaderText="Album Price" />
                            <asp:CommandField 
                                HeaderText="Actions" 
                                ShowDeleteButton="True" 
                                ShowEditButton="True" 
                                ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
            <% }%>
            <% else { %>
                   <asp:GridView ID="AlbumListGridViewCstm" runat="server"
                        AutoGenerateColumns="false"
                        OnRowDeleting="AlbumListGridViewCstm_RowDeleting"
                        OnRowEditing="AlbumListGridViewCstm_RowEditing"
                        OnSelectedIndexChanging="AlbumListGridViewCstm_SelectedIndexChanging">
                        <Columns>
                            <asp:BoundField HeaderText="id" DataField="AlbumID" />
                            <asp:ImageField DataImageUrlField="AlbumImage" HeaderText="Album Image"/>
                            <asp:BoundField DataField="AlbumName" HeaderText="Album Name" />
                            <asp:BoundField DataField="AlbumDescription" HeaderText="Album Description" />
                            <asp:BoundField DataField="AlbumPrice" HeaderText="Album Price" />
                            <asp:CommandField 
                                HeaderText="Actions" 
                                ShowDeleteButton="True" 
                                ShowEditButton="True" 
                                ShowSelectButton="True" />
                        </Columns>
                   </asp:GridView>
            <%} %>
        </div>
    </div>

</asp:Content>
