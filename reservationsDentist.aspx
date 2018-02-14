<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="reservationsDentist.aspx.cs" Inherits="DBHandIn3.reservationsDentist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: justify;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centerAlign">

        <br />
        <br />
        <asp:Label ID="Label3" runat="server" ForeColor="Blue" Text="You have been logged in as a dentist."></asp:Label>

        <br />
        <asp:Label ID="LabelMessageResDentist" runat="server"></asp:Label>

        <br />
        <br />
        <asp:DropDownList ID="DropDownListPatient" runat="server" Width="237px" OnSelectedIndexChanged="DropDownListPatient_SelectedIndexChanged">
        </asp:DropDownList>
&nbsp;<asp:DropDownList ID="DropDownDate" runat="server" Width="237px" OnSelectedIndexChanged="DropDownDate_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <div class="auto-style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridViewReservations" runat="server" Width="1154px" CssClass="centerAlign">
        </asp:GridView>

        </div>

        <br />
        <asp:Button ID="ButtonAllRes" runat="server" CssClass="button" OnClick="ButtonAllRes_Click" Text="Show all reservations" />
        <br />
        <asp:Label ID="LabelMessage" runat="server" ForeColor="Green"></asp:Label>

    </div>
</asp:Content>
