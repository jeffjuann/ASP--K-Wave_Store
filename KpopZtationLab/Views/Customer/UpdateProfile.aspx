<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="KpopZtationLab.Views.Customer.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Profile</h1>
    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
    <br />
    <asp:TextBox ID="EmailTxt" runat="server" ToolTip="Email" TextMode="Email"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
    <br />
    <asp:TextBox ID="NameTxt" runat="server" ToolTip="Name" TextMode="SingleLine"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
    <br />
    <asp:RadioButtonList ID="GenderRB"  runat="server">
       <asp:ListItem>Male</asp:ListItem>
       <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
    <br />
    <asp:TextBox ID="AddressTxt" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
    <br />
    <asp:TextBox ID="PasswordTxt" runat="server" Text="Password" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="ErrorLbl" runat="server" Text="ErrLbl" Visible="false">No User Found</asp:Label>
    <br />
    <asp:Button ID="Save" runat="server" Text="Save Changes" OnClick="Save_Click"/>
</asp:Content>
