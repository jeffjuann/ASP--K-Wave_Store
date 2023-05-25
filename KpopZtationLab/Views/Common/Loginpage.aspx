<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Loginpage.aspx.cs" Inherits="KpopZtationLab.Views.Common.Loginpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <title>Login</title>
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Log In</h1>
    <asp:TextBox ID="EmailTxt" runat="server" ToolTip="Email" TextMode="Email"></asp:TextBox>
    <br />
    <asp:TextBox ID="PasswordTxt" runat="server" ToolTip="Password" TextMode="Password"></asp:TextBox>
    <br />
    <asp:CheckBox ID="RememberMeChk" runat="server" Text="Remember Me"/>
    <br />
    <asp:Label ID="ErrorLbl" runat="server" Text="Label" Visible="false">No User Found</asp:Label>
    <br />
    <asp:Button ID="Login" runat="server" Text="Button" OnClick="Login_Click"/>
</asp:Content>
