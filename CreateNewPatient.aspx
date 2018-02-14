<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CreateNewPatient.aspx.cs" Inherits="DBHandIn3.CreateNewPatient" %>


<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
        <br />
    </p>
                    <div class="container centerAlign">
                        <div>
                            <asp:Label ID="Label4" runat="server" Text="Create new patient account:"></asp:Label>
                            <br />
                            <br />
                            <br />
                            <asp:Label ID="LabelPatientFName" runat="server" Text="Patient first name" CssClass="label"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxPatientFName" runat="server"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:Label ID="LabelPatientLName" runat="server" Text="Patient last name" CssClass="label"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxPatientLName" runat="server"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Age" CssClass="label"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxPAge" runat="server" CssClass="auto-style1"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="CPR" CssClass="label"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxCpr" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelPatientPass" runat="server" Text="Password" CssClass="label"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxPatientPass" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelPatientConfirm" runat="server" Text="Confirm password" CssClass="label"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxPatientConfirm" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email" CssClass="label"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxPEmailCreate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelGender" runat="server" Text="Gender:" CssClass="label"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="radioButtons" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
        </asp:RadioButtonList>
        <br />
                            <asp:Label ID="LabelMessage" runat="server" Text="NoMessage"></asp:Label>
                            <br />
                            <br />
&nbsp;<asp:Button ID="ButtonCreatePatient" runat="server" CssClass="button" Text="Add new patient" OnClick="ButtonCreatePatient_Click" />
                            <br />
                        </div>
                    </div>
</asp:Content>

