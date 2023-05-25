<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertAlbum.aspx.cs" Inherits="KpopZtationLab.Views.Admin.InsertAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Create Album</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>List Of Existing Album Owned by UI</h1>
    </div>
    <div class="flex">
        <div class="left">
            <%--render list of albums--%>
            <asp:GridView ID="AlbumGridView" runat="server" AutoGenerateColumns="false" ShowHeader="false" OnRowEditing="AlbumGridView_RowEditing">
                <Columns>
                    <asp:BoundField DataField="AlbumID" visible="false"/>
                    <asp:BoundField DataField="AlbumName"/>
                    <asp:ImageField HeaderImageUrl="AlbumImage"/>
                    <asp:CommandField ShowEditButton="true"/>
                </Columns>
            </asp:GridView>
        </div>
        <div class="right">
            <h2>Insert a new Album into <%= artist.ArtistName %>'s Music Album</h2>
            <div class="flex">
                <asp:FileUpload ID="AlbumImgUpload" runat="server" />
                <div class="column">
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
                    <%--artist name--%>
                    <asp:Label ID="Label2" runat="server" Text="Artist Name"></asp:Label>
                    <br />
                    <asp:DropDownList ID="ArtistName" runat="server">
                        
                    </asp:DropDownList>
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
                </div>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Insert Album" />
        </div>
    </div>
</asp:Content>
