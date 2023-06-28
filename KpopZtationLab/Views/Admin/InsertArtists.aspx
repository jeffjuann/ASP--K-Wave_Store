<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertArtists.aspx.cs" Inherits="KpopZtationLab.Views.Admin.InsertArtists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        @import url(https://fonts.googleapis.com/css?family=Open+Sans:400,600,700,800);
        @import url(https://fonts.googleapis.com/css?family=Droid+Sans:400,700);
        @import "//maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css";
        body {
            font-family: 'Open Sans', sans-serif;
            background: #BDBDBD;
        }
        .flex {
            display: flex;
            justify-content: flex-start;
        }
        .wrapper {
            margin-left: auto;
            margin-right: 0;
            background: #FFFFFF;
            padding: 32px;


        }
        .column {
            flex-basis: 50%;
        }
        .flex h2 {
            margin-bottom: 16px;
        }
        .flex h5 {
            margin-top: 0;
        }
        .flex input[type="text"],
        .flex input[type="file"] {
            padding: 0.75rem 0.875rem;
            border-radius: 4px;
            outline: 0;
            color: #212121;
            font-size: 0.875rem;
            width: 100%;
            border: 0.063rem solid #b0bec5;
        }
        .flex input[type="file"] {
            margin-bottom: 16px;
        }
        .flex button {
            padding: 0.75rem 1.5rem;
            margin-top: 16px;
            outline: 0;
            border: 0;
            background: #2196f3;
            border-radius: 4px;
            color: #FFF;
            font-weight: 700;
            font-size: 0.875rem;
            letter-spacing: 0.25px;
            transition: background 0.3s ease;
        }
        .flex button:hover {
            background: #39a1f4;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="flex" style="padding: 64px 96px;">
        <div class="wrapper">
            <h2>Create New Artist</h2>
            <div class="flex">
                <div class="column">
                    <asp:FileUpload ID="ArtistImageUpload" runat="server" EnableViewState="true" />
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
