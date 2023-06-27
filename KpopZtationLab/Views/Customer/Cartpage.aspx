<%@ Page Title="CartPage" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cartpage.aspx.cs" Inherits="KpopZtationLab.Views.Pages.Cartpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* CSS styles for the cart page */
        .container {
            display: flex;
            justify-content: center;
        }

        .left {
            width: 600px;
        }

        .left ul {
            list-style-type: none;
            padding: 0;
        }

        .left li {
            display: flex;
            align-items: center;
            margin-bottom: 70px;
            box-shadow: 0px 10px 30px 2px rgba(0, 0, 0, 0.17); /* Add box shadow */
        }

        .left img {
            max-width: 250px;
            height: auto;
            margin-right: 10px;
            padding: 20px; /* Add padding to the images */
        }

        .left .item-details {
            display: flex;
            flex-direction: column;
            margin-right: 100px;
        }

        .left h1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="left">
            <h1>Cart</h1>
            <asp:Repeater ID="CartRepeater" runat="server">
                <HeaderTemplate>
                    <ul>
                </HeaderTemplate>
                <ItemTemplate>
                    <li>
                        <div>
                            <img src='<%# Eval("Album.AlbumImage") %>' alt="Album Image" />
                        </div>
                        <div class="item-details">
                            <span>Album ID: <%# Eval("Album.AlbumID") %></span><br />
                            <span>Album Name: <%# Eval("Album.AlbumName") %></span><br />
                            <span>Quantity: <%# Eval("Qty") %></span><br />
                            <span>Album Price: <%# Eval("Album.AlbumPrice") %></span><br />
                            <asp:Button ID="DeleteButton" style="text-decoration: none; color: #fff; padding: 8px 12px; background-color: #007bff; border: none; border-radius: 4px;" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%# Container.ItemIndex %>' />
                        </div>
                    </li>
                </ItemTemplate>
                <FooterTemplate>
                    </ul>
                </FooterTemplate>
            </asp:Repeater>
            <asp:Button ID="CheckOutBtn" runat="server" style="text-decoration: none; color: #fff; padding: 8px 12px; background-color: #007bff; border: none; border-radius: 4px;" Text="Checkout Cart" OnClick="CheckOutBtn_Click" />
        </div>
    </div>
</asp:Content>
