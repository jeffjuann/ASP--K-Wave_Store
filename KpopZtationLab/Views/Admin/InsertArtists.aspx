<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertArtists.aspx.cs" Inherits="KpopZtationLab.Views.Admin.InsertArtists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Insert Artist</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>List Of Existing</h1>
    </div>
    <div class="flex">
        <div class="right">
            <h2>Create New Artist</h2>
            <div class="flex">
                <div class="column">
                    <asp:FileUpload ID="ArtistImageUpload" runat="server" EnableViewState="true"/>
                </div>
                <div class="column">
                    <h5>Artist's Name</h5>
                    <asp:TextBox ID="ArtistTxt" runat="server"></asp:TextBox>
                    <asp:Label ID="errLbl" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Insert Artist" OnClick="Insert_Click" />
        </div>
    </div>
</asp:Content>
