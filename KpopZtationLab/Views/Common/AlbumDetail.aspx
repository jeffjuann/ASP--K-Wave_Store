<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="KpopZtationLab.Views.Common.AlbumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content" style="padding: 64px 96px;">
         <main style="display: flex; flex-direction: row; gap: 48px">
              <div class="left">
                  <img src="<%=album.AlbumImage %>" alt="Alternate Text" style="
                      width: 100%; 
                      height: 500px; 
                      object-fit: cover; 
                      border-radius: 64px;"/>
            </div>
            <div class="right" style="padding-top: 32px; padding-bottom: 8px">
                <div class="flex" style="flex-direction: column; gap: 8px">
                     <div class="column">
                        <h1 style="font-size: 48px"><%=album.AlbumName %></h1>

                        <h3>Description</h3>
                        <h3 style="font-weight: 400"><%=album.AlbumDescription %></h3>
                    </div>
					<br />
                    <h2>$ <%=album.AlbumPrice %></h2>
                    <h3>Remaining Stock: <%=album.AlbumStock %></h3>
                </div>
                <div class="flex" style="gap: 8px">
                    <h3>Buy Quantity</h3>
                    <div class="flex-group">
                        <%if (role == "CSTM" || role == "ADMN")
                            { %>
                              <asp:TextBox ID="QuantityTxt" runat="server" Text="0"></asp:TextBox>
                              <asp:Label ID="ErrorLbl" runat="server" Text="Label" Visible="false"></asp:Label>


                        <%} %>
                        <%else
                            { %>
                               <asp:TextBox ID="TextBox1" runat="server" Text="0" Enabled="false"></asp:TextBox>
                        <%} %>
                    </div>
                </div>
                <%if (role == "CSTM" || role == "ADMN")
                    { %>
                <div class="flex" style="margin: 8px">
                    <asp:Button ID="addToCartBtn" runat="server" Text="Add to cart" OnClick="addToCartBtn_Click" style="
                        background: #0062CC;
                        padding: 8px 16px;
                        border: none;
                        border-radius: 4px;
                        color: white"/>
                </div>
                <%} %>
            </div>
        </main>
    </div>
</asp:Content>
