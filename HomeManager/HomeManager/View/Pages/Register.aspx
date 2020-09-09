<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPages/AccountSite.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HomeManager.View.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbl_register" runat="server" Text="Regisztráció"></asp:Label>
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
    <asp:Label ID="lbl_passwordagain" runat="server" Text="Jelszó újra:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_passwordagain" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_lastname" runat="server" Text="Vezetéknév:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_lastname" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_firstname" runat="server" Text="Keresztnév:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_firstname" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_email" runat="server" Text="E-mail cím:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_birthdate" runat="server" Text="Születési dátum:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_birthdate" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btn_register" runat="server" Text="Regisztráció" 
        PostBackUrl="~/View/Pages/HomePage.aspx" OnClick="btn_register_Click" />

    </asp:Content>
