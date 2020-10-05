<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPages/AccountSite.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HomeManager.View.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="registerpage">
        <div id="registerheader"><asp:Label ID="lbl_register" runat="server" Text="Regisztráció"></asp:Label></div>
    <br />
    <asp:Label ID="lbl_username" runat="server" Text="Felhasználónév:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_username_errortext" runat="server" Text="" CssClass="registerErrorMessages"></asp:Label>
    <br />
    <asp:Label ID="lbl_password" runat="server" Text="Jelszó:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_password" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_password_errortext" runat="server" Text="" CssClass="registerErrorMessages"></asp:Label>
    <br />
    <asp:Label ID="lbl_passwordagain" runat="server" Text="Jelszó újra:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_passwordagain" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_passwordagain_errortext" runat="server" Text="" CssClass="registerErrorMessages"></asp:Label>
    <br />
    <asp:Label ID="lbl_lastname" runat="server" Text="Vezetéknév:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_lastname" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_lastname_errortext" runat="server" Text="" CssClass="registerErrorMessages"></asp:Label>
    <br />
    <asp:Label ID="lbl_firstname" runat="server" Text="Keresztnév:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_firstname" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_firstname_errortext" runat="server" Text="" CssClass="registerErrorMessages"></asp:Label>
    <br />
    <asp:Label ID="lbl_email" runat="server" Text="E-mail cím:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_email_errortext" runat="server" Text="" CssClass="registerErrorMessages"></asp:Label>
    <br />
    <asp:Label ID="lbl_birthdate" runat="server" Text="Születési dátum:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_birthdate" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_birthdate_errortext" runat="server" Text="" CssClass="registerErrorMessages"></asp:Label>
    <br />
    <asp:Label ID="lbl_result" runat="server" Text=""></asp:Label>
    <br />
        <div>
            <div id="registerbutton">
                <asp:Button CssClass="button button2" ID="btn_register" runat="server" Text="Regisztráció" OnClick="btn_register_Click" style="text-align: center;" />  
                <br />
                <asp:Label ID="Label1" runat="server" Text=" vagy "></asp:Label>
                <asp:HyperLink ID="btn_forgottenpassword" runat="server" CssClass="linkbutton" NavigateUrl="~/View/Pages/Login.aspx">Bejelentkezés</asp:HyperLink>
            </div>
        </div>
    </div>
    </asp:Content>