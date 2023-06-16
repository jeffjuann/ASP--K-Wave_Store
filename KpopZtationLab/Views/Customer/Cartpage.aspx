<%@ Page Title="CartPage" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cartpage.aspx.cs" Inherits="KpopZtationLab.Views.Pages.Cartpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cart</h1>
    <div class="left">
         <asp:GridView ID="CartGridView" 
             runat="server" 
             OnRowDeleting="CartGridView_RowDeleting" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Album ID" DataField="Album.AlbumID" />
                 <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Album.AlbumImage") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Album Name">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Album.AlbumName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Qty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Album.AlbumPrice") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <%--<asp:BoundField HeaderText="Album Name" DataField="Album.AlbumName" />
                <asp:BoundField HeaderText="Quantity" DataField="Qty" />
                <asp:BoundField HeaderText="Album Price" DataField="Album.AlbumPrice" />--%>
                <asp:CommandField HeaderText="Actions" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
  
    </div>
</asp:Content>
