<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateArtists.aspx.cs" Inherits="KpopZtationLab.Views.Admin.UpdateArtists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Update Artist</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>List Of Existing</h1>
    </div>
    <h2>Update Artist Data</h2>
    <br />
    <h5>Artist's Image</h5>
    <asp:FileUpload ID="ArtistImageUpload" runat="server" EnableViewState="true"/>
    <h5>Artist's Name</h5>
    <asp:TextBox ID="ArtistTxt" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="errLbl" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Update Artist" OnClick="Update_Click" />
</asp:Content>
