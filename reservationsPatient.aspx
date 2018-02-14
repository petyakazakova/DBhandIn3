<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="reservationsPatient.aspx.cs" Inherits="DBHandIn3.createResPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centerAlign">

        <br />
        <br />
        <asp:Label ID="Label3" runat="server" ForeColor="Blue" Text="You have been logged in as a patient."></asp:Label>
        <br />
        <br />
        <strong>
        <asp:Label ID="Label1" runat="server" Font-Size="25px" Text="Your patient reservations:"></asp:Label>
        <br />
        </strong>
        <asp:GridView ID="GridViewUpdateRes" runat="server" CssClass="centerAlign" OnSelectedIndexChanged="GridViewUpdateRes_SelectedIndexChanged" Width="648px" HorizontalAlign="Center">
            <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="LabelMessageCRR" runat="server" ForeColor="Green"></asp:Label>
        <em>
        <br />
        </em>
        <asp:Label ID="Label2" runat="server" Text="To create a reservation, please fill out the form below."></asp:Label>
        <br />
        <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red"></asp:Label>
        <asp:Label ID="LabelMessageResPat" runat="server" ForeColor="Green"></asp:Label>
        <br />
        <asp:Label ID="LabelPatientID" runat="server" Text="Patient ID"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxPatID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelTrID" runat="server" Text="Treatment ID"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxTrID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelResDate" runat="server" Text="Reservation date"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxResDate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonCreateRes" runat="server" CssClass="button" OnClick="ButtonCreateRes_Click" Text="Create reservation" />
        <br />
        <asp:Button ID="ButtonUpdateRes" runat="server" CssClass="button" OnClick="ButtonUpdateRes_Click" Text="Update reservation" />
        <br />
        <asp:Button ID="ButtonDeleteRes" runat="server" CssClass="button" OnClick="ButtonDeleteRes_Click" Text="Delete reservation" />
        <br />

    </div>
</asp:Content>
