<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="DBHandIn3.Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centerAlign">
        <br />
        <br />
        <asp:Button ID="ButtonLogout" runat="server" CssClass="button" Text="Logout" OnClick="ButtonLogout_Click" />

        <br />
        <br />

        <asp:Label ID="LabelMessageLogout" runat="server" ForeColor="Green"></asp:Label>
    </div>
</asp:Content>
