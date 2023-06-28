<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Loginpage.aspx.cs" Inherits="KpopZtationLab.Views.Common.Loginpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Login</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="max-width: 500px; height: 420px; margin: 3rem auto; background: #eceff1; padding: 0 0 1rem; position: relative;">
        <h1 style="background: #fff; text-align: center; font-size: 1.25rem; font-weight: 600; color: #212121; padding: 1rem; margin: 0 0 1rem; position: relative;">Log In</h1>
        <div style="margin: 0 2rem 1rem;">
            <asp:Label ID="Label1" runat="server" Text="Email" style="display: block; margin: 0 0 .5rem; font-weight: 700; letter-spacing: .2px; font-size: .875rem; color: #212121;"></asp:Label>
            <br />
            <asp:TextBox ID="EmailTxt" runat="server" ToolTip="Email" TextMode="Email" style="padding: 0.75rem 0.875rem; border-radius: 4px; outline: 0; color: #212121; font-size: .875rem; width: 100%; border: 0.063rem solid #b0bec5;"></asp:TextBox>
            <br />
        </div>
        <div style="margin: 0 2rem 1rem;">
            <asp:Label ID="Label2" runat="server" Text="Password" style="display: block; margin: 0 0 .5rem; font-weight: 700; letter-spacing: .2px; font-size: .875rem; color: #212121;"></asp:Label>
            <br />
            <asp:TextBox ID="PasswordTxt" runat="server" ToolTip="Password" TextMode="Password" style="padding: 0.75rem 0.875rem; border-radius: 4px; outline: 0; color: #212121; font-size: .875rem; width: 100%; border: 0.063rem solid #b0bec5;"></asp:TextBox>
            <br />
        </div>
        <div style="margin: 0 2rem 1rem;">
            <asp:CheckBox ID="RememberMeChk" runat="server" Text="Remember Me" style="display: block; margin: 0 0 .5rem; font-weight: 700; letter-spacing: .2px; font-size: .875rem; color: #212121;"></asp:CheckBox>
            <br />
        </div>
        <div style="margin: 0 2rem 1rem;">
            <asp:Label ID="ErrorLbl" runat="server" Text="No User Found" Visible="false" style="display: block; margin: 0 0 .5rem; font-weight: 700; letter-spacing: .2px; font-size: .875rem; color: #212121;"></asp:Label>
            <br />
        </div>
        <div style="margin: 0 2rem 1rem;">
            <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" style="padding: 0.75rem 1.5rem; margin: .5rem 0 0; outline: 0; border: 0; background: #2196f3; border-radius: 4px; color: #FFF; font-weight: 700; font-size: .875rem; letter-spacing: .25px;"></asp:Button>
        </div>
    </div>
</asp:Content>
