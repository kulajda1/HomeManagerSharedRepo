<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPages/AccountSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HomeManager.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbl_login" runat="server" Text="Bejelentkezés"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lbl_username" runat="server" Text="Felhasználónév:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_password" runat="server" Text="Jelszó:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btn_login" runat="server" Text="Bejelentkezés" PostBackUrl="~/View/Pages/HomePage.aspx" />
    <br />
</asp:Content>
