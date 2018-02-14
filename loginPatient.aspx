<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="loginPatient.aspx.cs" Inherits="DBHandIn3.loginPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                        <div class="centerAlign">
                            <br />
                            <br />
                            <br />
                            <asp:Label ID="LabelLoginPheadline" runat="server" Text="Login as a patient:"></asp:Label>
                            <br />
                            <br />
                            <asp:Label ID="LabelLoginPemail" runat="server" Text="Email" CssClass="label"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxPEmailLogIn" runat="server"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:Label ID="LabelLoginPpass" runat="server" Text="Password" CssClass="label"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxLoginPpass" runat="server"></asp:TextBox>
&nbsp;<br />
                            <br />
                            <asp:Button ID="ButtonLoginP" runat="server" CssClass="button" Text="Submit" OnClick="ButtonLoginP_Click" />
                            <br />
                            <asp:Label ID="PatientLoginErrorMessage" runat="server" ForeColor="Red"></asp:Label>
                            <br />
                            <asp:Label ID="PatientLoginMessage" runat="server" ForeColor="Green"></asp:Label>
                            <br />
                            <asp:Label ID="LabelMessage" runat="server" ForeColor="Green"></asp:Label>
                            <br />
&nbsp;<br />
                        </div>
</asp:Content>

