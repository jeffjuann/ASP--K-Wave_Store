    <%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="KpopZtationLab.Views.Common.Homepage" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <title>Home</title>
            <link rel="stylesheet" href="../../Assets/css/homepage.css" type="text/css" />
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h2>Artists</h2>
        <br />
        <% if (role == "ADMN")
            { %>
        <asp:Button ID="CreateArtist" runat="server" Text="Add New Artist" OnClick="CreateArtist_Click" />
        <asp:GridView ID="AdminArtistsGridView" runat="server" 
            AutoGenerateColumns="false"
            OnRowDeleting="AdminArtistsGridView_RowDeleting"
            OnRowEditing="AdminArtistsGridView_RowEditing"
            OnSelectedIndexChanging="AdminArtistsGridView_SelectedIndexChanging"
                >
            <Columns>
                <asp:BoundField HeaderText="id" DataField="ArtistID" />
                <asp:ImageField DataImageUrlField="ArtistImage" HeaderText="Artist Image"/>
                <asp:CommandField 
                    HeaderText="Actions" 
                    ShowDeleteButton="True" 
                    ShowEditButton="True" 
                    ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
            <%} %>
        <%else{ %>
            <asp:GridView ID="ArtistsGridView" runat="server" 
            AutoGenerateColumns="false"
            OnSelectedIndexChanging="ArtistsGridView_SelectedIndexChanging"
                >
            <Columns>
                <asp:BoundField HeaderText="id" DataField="ArtistID" />
                <asp:ImageField DataImageUrlField="ArtistImage" HeaderText="Artist Image"/>
                <asp:BoundField DataField="ArtistName" HeaderText="Artist Name" ></asp:BoundField>
                <asp:CommandField ShowSelectButton="true" />
            </Columns>
        </asp:GridView>

        <%} %>

    </asp:Content>
