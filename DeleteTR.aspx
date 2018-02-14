<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DeleteTR.aspx.cs" Inherits="DBHandIn3.DeleteTR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
        <br />
   
        <asp:Button ID="ButtonBackToTRAdmin" runat="server" Text="Go back to treatments dentist page" CssClass="button" OnClick="ButtonBackToTRAdmin_Click" />

    <div class="centerAlign">

        <br />
        <asp:GridView ID="GridViewUpdateTR" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:DropDownList ID="DropDownListTR" runat="server" Height="26px" OnSelectedIndexChanged="DropDownListTR_SelectedIndexChanged" Width="274px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="ButtonDeleteTR" runat="server" CssClass="button" OnClick="ButtonDeleteTR_Click" Text="Delete treatment" />
        <br />
        <br />
        <asp:Label ID="LabelMessageCRR" runat="server" ForeColor="Green"></asp:Label>
    </div>
   
</asp:Content>
