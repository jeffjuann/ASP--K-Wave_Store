<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertAlbum.aspx.cs" Inherits="KpopZtationLab.Views.Admin.InsertAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Create Album</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <h2>Insert a new Album to <%=artist.ArtistName %>'s Album</h2>
            <br />
            <asp:FileUpload ID="AlbumImageUpload" runat="server" />
            <br />
            <%--textbox isi attributes dari album--%>
            <%--name--%>
            <asp:Label ID="Label1" runat="server" Text="Album Name"></asp:Label>
            <br />
            <asp:TextBox ID="AlbumNameTxt" runat="server"></asp:TextBox>
            <br />
            <%--description--%>
            <asp:Label ID="Label5" runat="server" Text="Album Description"></asp:Label>
            <br />
            <asp:TextBox ID="AlbumDescriptionTxt" runat="server"></asp:TextBox>
            <br />
            <%--price--%>
            <asp:Label ID="Label3" runat="server" Text="Album Price"></asp:Label>
            <br />
            <asp:TextBox ID="AlbumPriceTxt" runat="server"></asp:TextBox>
            <br />
            <%--stock--%>
            <asp:Label ID="Label4" runat="server" Text="Album Stock"></asp:Label>
            <br />
            <asp:TextBox ID="AlbumStockTxt" runat="server"></asp:TextBox> 
            <br />
            <asp:Label ID="errLbl" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="createAlbum" runat="server" Text="Insert Album" OnClick="createAlbum_Click" />
</asp:Content>
