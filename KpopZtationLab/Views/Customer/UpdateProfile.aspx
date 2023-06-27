<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="KpopZtationLab.Views.Customer.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* CSS styles */
        @import url(https://fonts.googleapis.com/css?family=Open+Sans:400,600,700,800);
        @import url(https://fonts.googleapis.com/css?family=Droid+Sans:400,700);
        @import "//maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css";
        * {
            box-sizing: border-box;
        }
        body {
            font-size: 100%;
            font-family: 'Open Sans', sans-serif;
            background: #BDBDBD;
        }
        .wrapper {
            max-width: 70vw;
            margin: 3rem auto;
            background: #eceff1;
            padding: 0 0 1rem;
            position: relative;
        }
        .form-header {
            background: #fff;
            text-align: center;
            font-size: 1.25rem;
            font-weight: 600;
            color: #212121;
            padding: 1rem;
            margin: 0 0 1rem;
            position: relative;
        }
        .form-header .close {
            position: absolute;
            right: 1rem;
            top: 1.25rem;
            color: #cfd6db;
            cursor: pointer;
            transition: color .2s ease;
        }
        .form-header .close:hover {
            color: #212121;
        }
        .form-grp {
            margin: 0 2rem 1rem;
        }
        .form-grp label {
            display: block;
            margin: 0 0 .5rem;
            font-weight: 700;
            letter-spacing: .2px;
            font-size: .875rem;
            color: #212121;
        }
        .form-grp label.inline {
            display: inline-block;
            width: 100px;
        }
        .form-grp label.inline.right {
            text-align: right;
            padding-right: .5rem;
        }
        input[type="text"],
        input[type="email"],
        input[type="password"],
        textarea { /* Added textarea selector */
            padding: 0.75rem 0.875rem;
            border-radius: 4px;
            outline: 0;
            color: #212121;
            font-size: .875rem;
            width: 100%;
            border: 0.063rem solid #b0bec5;
        }
        input[type="submit"] {
            padding: 0.75rem 1.5rem;
            margin: .5rem 0 0;
            outline: 0;
            border: 0;
            background: #2196f3;
            border-radius: 4px;
            color: #FFF;
            font-weight: 700;
            font-size: .875rem;
            letter-spacing: .25px;
            transition: background .3s ease;
        }
        input[type="submit"]:hover {
            background: #39a1f4;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
        <div class="form-header">
            <h1>Update Profile</h1>
            <i class="fa fa-times close"></i>
        </div>
        <div class="form-grp">
            <label class="inline right">Email</label>
            <asp:TextBox ID="EmailTxt" runat="server" ToolTip="Email" TextMode="Email" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-grp">
            <label class="inline right">Name</label>
            <asp:TextBox ID="NameTxt" runat="server" ToolTip="Name" TextMode="SingleLine" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-grp">
            <label class="inline right">Gender</label>
            <asp:RadioButtonList ID="GenderRB" runat="server" CssClass="form-control">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="form-grp">
            <label class="inline right">Address</label>
            <asp:TextBox ID="AddressTxt" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-grp">
            <label class="inline right">Password</label>
            <asp:TextBox ID="PasswordTxt" runat="server" Text="Password" TextMode="Password" CssClass="form-control"></asp:TextBox>
        </div>
        <asp:Label ID="ErrorLbl" runat="server" Text="No User Found" Visible="false" CssClass="error-label"></asp:Label>
        <div class="form-grp">
            <asp:Button ID="Save" runat="server" Text="Save Changes" OnClick="Save_Click" CssClass="submit-btn" />
        </div>
    </div>
</asp:Content>
