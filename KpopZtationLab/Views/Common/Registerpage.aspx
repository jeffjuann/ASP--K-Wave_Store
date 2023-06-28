<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Registerpage.aspx.cs" Inherits="KpopZtationLab.Views.Common.Registerpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align: center;">Register Page</h1>
    <div style="max-width: 500px; margin: 3rem auto 0; padding-top: 1rem;">
        <asp:Label ID="Label1" runat="server" Text="Email" style="font-weight: bold; display: block; margin-bottom: 5px;"></asp:Label>
        <asp:TextBox ID="EmailTxt" runat="server" ToolTip="Email" TextMode="Email" style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name" style="font-weight: bold; display: block; margin-bottom: 5px;"></asp:Label>
        <asp:TextBox ID="NameTxt" runat="server" ToolTip="Name" TextMode="SingleLine" style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Gender" style="font-weight: bold; display: block; margin-bottom: 5px;"></asp:Label>
        <asp:RadioButtonList ID="GenderRB" runat="server" style="margin-bottom: 10px;">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Address" style="font-weight: bold; display: block; margin-bottom: 5px;"></asp:Label>
        <asp:TextBox ID="AddressTxt" runat="server" TextMode="MultiLine" style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Password" style="font-weight: bold; display: block; margin-bottom: 5px;"></asp:Label>
        <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password" style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;"></asp:TextBox>
        <br />
        <asp:Label ID="ErrorLbl" runat="server" Text="ErrLbl" Visible="false" style="font-weight: bold; color: red;"></asp:Label>
        <br />
        <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click" style="padding: 10px 20px; background-color: #2196f3; color: #fff; border: none; border-radius: 4px; font-weight: bold; cursor: pointer;"></asp:Button>
    </div>
</asp:Content>
