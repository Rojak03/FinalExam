<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="loginPlac">
        <div class="nyBruger">
            Opret dig som ny bruger<br />
            Klik på nedenstående link<br />
            <br />
            <asp:LinkButton ID="lnkNyBruger" runat="server" PostBackUrl="~/NyBruger.aspx" CausesValidation="false">Ny bruger</asp:LinkButton>
        </div>
        <div style="width: 50px; float: left;">&nbsp;</div>
        <div class="eksBruger">
            <table>
                <tr>
                    <td>Brugernavn:</td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server" CssClass="teksLogin" /></td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="tekstLogin" /></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Button ID="btnLogin" runat="server" Text="Log ind" CssClass="knap" CausesValidation="false" OnClick="btnLogin_Click"  /></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Literal ID="litError" runat="server" /></td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>

