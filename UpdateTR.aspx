<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateTR.aspx.cs" Inherits="DBHandIn3.UpdateTR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
   
        <asp:Button ID="ButtonBackToTRAdmin" runat="server" Text="Go back to treatments dentist page" CssClass="button" OnClick="ButtonBackToTRAdmin_Click" />

    </p>

    <div class="centerAlign">

        <asp:GridView ID="GridViewUpdateTR" runat="server" OnSelectedIndexChanged="GridViewUpdateTR_SelectedIndexChanged" Height="203px" Width="1091px">
            <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Font-Size="25px" ForeColor="Blue" Text="Update treatment"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Update name"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxUpdateTRName" runat="server" OnTextChanged="TextBoxUpdateTRName_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Update price"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxUpdateTRPrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Update number"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxUpdateTRNumber" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Update image"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxUpdateTRImage" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonUpdateTR" runat="server" CssClass="button" OnClick="ButtonUpdateTR_Click" Text="Update treatment" />
        <br />
        <asp:Label ID="LabelMessageUpdateTR" runat="server" ForeColor="Green"></asp:Label>

    </div>
</asp:Content>
