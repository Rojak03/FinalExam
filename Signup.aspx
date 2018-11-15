<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="pnlMail" CssClass="contactForm" runat="server" DefaultButton="btnSend">
        <div class="form-group">
            <label for="name">Navn</label>
            <asp:TextBox ID="txtName" CssClass="form_control" placeholder="Navn" requeried="true" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="email">Email</label>
            <asp:TextBox ID="txtEmail" CssClass="form-control" placeholder="Email" runat="server"></asp:TextBox>

        </div>
        <div class="form-group">
            <label for="subject">Emne</label>
            <asp:TextBox ID="txtEmne" CssClass="form_control" placeholder="Emne" requeried="true" runat="server"></asp:TextBox>

        </div>
        <div class="form-group">
            <label for="message">Besked</label>
            <asp:TextBox ID="txtMessage" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSend" CssClass="btn btn-theme pull-left" runat="server" Text="Send mail"  OnClick="btnSend_Click" />
            <br />

            <asp:Literal ID="litResult" runat="server"></asp:Literal>
        </div>
    </asp:Panel>
    <asp:Literal ID="litMessage" runat="server" />
</asp:Content>

