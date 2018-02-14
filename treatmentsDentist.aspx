<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="treatmentsDentist.aspx.cs" Inherits="DBHandIn3.treatmentsDentist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="centerAlign">

        <br />
        <br />
        <asp:Button ID="ButtonShowAllTr" runat="server" CssClass="button" OnClick="ButtonShowAllTr_Click" Text="Show all treatments" />
        <asp:Button ID="ButtonCreateTr" runat="server" CssClass="button" OnClick="ButtonCreateTr_Click" Text="Create new treatment" />
        <asp:Button ID="ButtonUpdateTr" runat="server" CssClass="button" Text="Update treatment" OnClick="ButtonUpdateTr_Click" />
        <asp:Button ID="ButtonDeleteTr" runat="server" CssClass="button" Text="Delete treatment" OnClick="ButtonDeleteTr_Click" />
        <br />
        <br />
        <asp:Button ID="ButtonShowResAdmin" runat="server" CssClass="button" Text="Show reservations" OnClick="ButtonShowResAdmin_Click" />
        <br />
        <br />
        <asp:Repeater ID="RepeaterTreatment" runat="server">
                <HeaderTemplate>
                    <table class="mytable centerAlign" style="text-align: center">
                        <tr>
                            <td class="myheader">Treatment id</td>
                            <td class="myheader">Treatment name</td>
                            <td class="myheader">Treatment price</td>
                            <td class="myheader">Treatment number</td>
                            <td class="myheader">Treatment image URL</td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td class="myitem"><%# Eval("ID_treatment") %></td>
                        <td class="myitem"><%# Eval("Name") %></td>
                        <td class="myitem"><%# Eval("Price") %></td>
                        <td class="myitem"><%# Eval("Number") %></td>
                        <td class="myitem">
                            <img src="<%# Eval("Image") %>" alt="" />
                        </td>
                    </tr>
                </ItemTemplate>

            </asp:Repeater>

        <br />
        <br />
        <asp:Label ID="LabelMessage" runat="server" ForeColor="Green"></asp:Label>

    </div>
</asp:Content>
