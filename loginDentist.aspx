<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="loginDentist.aspx.cs" Inherits="DBHandIn3.loginDentist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                            <div class="centerAlign">
                                <br />
                                <br />
                                <br />
                            <asp:Label ID="Label4" runat="server" Text="Login as a dentist:"></asp:Label>
                            <br />
                            <br />
                            <asp:Label ID="LabelLoginDemail" runat="server" Text="User name" CssClass="label"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxDNameLogin" runat="server"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:Label ID="LabelLoginDpass" runat="server" Text="Password" CssClass="label"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxLoginDpass" runat="server"></asp:TextBox>
&nbsp;<br />
                                <br />
                                <asp:Button ID="ButtonLoginD" runat="server" CssClass="button" Text="Submit" OnClick="ButtonLoginD_Click" />
                            <br />
                            <asp:Label ID="AdminLoginErrorMessage" runat="server" ForeColor="Red"></asp:Label>
                            <br />
                            <asp:Label ID="AdminLoginMessage" runat="server" ForeColor="Green"></asp:Label>
                            <br />
                            <asp:Label ID="LabelMessage" runat="server" ForeColor="Green"></asp:Label>
                            <br />
&nbsp;<br />
                        </div>
</asp:Content>
