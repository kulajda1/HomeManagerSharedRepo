<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPages/AccountSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HomeManager.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="loginpage">
        <div id="registerheader"><asp:Label ID="lbl_register" runat="server" Text="Bejelentkezés"></asp:Label></div>
    <br />
    <asp:Label ID="lbl_username" runat="server" Text="Felhasználónév:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_password" runat="server" Text="Jelszó:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_login_errortext" runat="server" Text="" CssClass="registerErrorMessages"></asp:Label>
    <br />
        <div id="registerbutton">
            <asp:Button CssClass="button button2" ID="btn_login" runat="server" Text="Bejelentkezés" OnClick="btn_register_Click" style="text-align: center;" />  
            <br />
            <br />
            <asp:HyperLink ID="btn_forgottenpassword" runat="server" CssClass="linkbutton" NavigateUrl="~/View/Pages/ForgottenPassword.aspx">Elfelejtett jelszó?</asp:HyperLink>
        </div>
    </div>
</asp:Content>
