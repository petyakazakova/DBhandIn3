<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="DBHandIn3.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Button ID="ButtonShowAllTr" runat="server" CssClass="button" OnClick="ButtonShowAllTr_Click" Text="Show all treatments" />
    <asp:Button ID="ButtonCreatePatient" runat="server" CssClass="button" Text="Create new patient account" OnClick="ButtonCreatePatient_Click" />
    <br />
    <br />
    <asp:Repeater ID="RepeaterTreatment" runat="server">
                <HeaderTemplate>
                    <table class="mytable" style="text-align: center; width: 63%;">
                        <tr>
                            <td class="myheader">Treatment ID</td>
                            <td class="myheader">Treatment name</td>
                            <td class="myheader">Treatment price</td>
                            <td class="myheader">Treatment number</td>
                            <td class="myheader">Treatment image</td>
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
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
    <br />
    <br />
    <asp:Label ID="LabelMessage" runat="server" ForeColor="Green"></asp:Label>
    <br />
    <br />
</asp:Content>
