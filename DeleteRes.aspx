<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DeleteRes.aspx.cs" Inherits="DBHandIn3.DeleteRes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="centerAlign">

        <br />
        <br />

        <asp:GridView ID="GridViewUpdateRes" runat="server" HorizontalAlign="Center" Width="476px">
        </asp:GridView>
        <br />
        <br />
        <asp:DropDownList ID="DropDownListRes" runat="server" CssClass="auto-style1" OnSelectedIndexChanged="DropDownListRes_SelectedIndexChanged" Width="253px">
        </asp:DropDownList>
        <br />
        <asp:Button ID="ButtonDeleteRes" runat="server" CssClass="button" OnClick="ButtonDeleteRes_Click" Text="Delete reservation" />
        <br />
        <asp:Label ID="LabelMessageCRR" runat="server" ForeColor="Green"></asp:Label>

    </div>
</asp:Content>
