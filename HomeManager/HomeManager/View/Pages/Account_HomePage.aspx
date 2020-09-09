<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPages/AccountSite.Master" AutoEventWireup="true" CodeBehind="Account_HomePage.aspx.cs" Inherits="HomeManager.View.Account_HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="accountheader">
    <asp:Button class="button button2" ID="btn_login" runat="server" Text="Bejelentkezés" PostBackUrl="~/View/Pages/Login.aspx" />
    <br />
    <br />
    <asp:Label ID="lbl_or" runat="server" Text="VAGY"></asp:Label>
    <br />
    <br />
    <asp:Button class="button button2" id="btn_register" runat="server" Text="Regisztráció" PostBackUrl="~/View/Pages/Register.aspx" />
    </div>
</asp:Content>
