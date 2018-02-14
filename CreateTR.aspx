<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CreateTR.aspx.cs" Inherits="DBHandIn3.CreateTR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
&nbsp;&nbsp;&nbsp;

    <asp:Button ID="ButtonBackToTRAdmin" runat="server" Text="Go back to treatments dentist page" CssClass="button" OnClick="ButtonBackToTRAdmin_Click" />
    <div class="centerAlign">

        &nbsp;<br />
        <asp:Label ID="Label1" runat="server" Text="Treatment name"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxCreateTRName" runat="server" Width="242px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Treatment Price"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxCreateTRPrice" runat="server" Width="221px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Treatment number"></asp:Label>
        <asp:TextBox ID="TextBoxCreateTRNumber" runat="server" Width="242px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Treatment Image"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxCreateTRImage" runat="server" Width="218px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonCreateTR" runat="server" CssClass="button" OnClick="ButtonCreateTR_Click" Text="Create new treatment" />
        <br />
        <br />
        <asp:Label ID="LabelMessageCreateTR" runat="server" ForeColor="Green"></asp:Label>

        <br />
        

    </div>
</asp:Content>
