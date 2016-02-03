<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ClarityClientConference.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Register</h2>
    <table>
        <tr>
            <td>Name</td>
            <td><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
        </tr>
        <tr> 
            <td> &nbsp</td>
        </tr>
        <tr>
            <td>Email</td>
            <td><asp:TextBox ID="email" runat="server"></asp:TextBox></td>
        </tr>
        <tr> 
            <td> &nbsp</td>
        </tr>
        <tr>
            <td>Company&nbsp</td>
            <td><asp:TextBox ID="client" runat="server"></asp:TextBox></td>
        </tr>
    </table>

    <br />
    <asp:Button ID="registerBtn" runat="server" Text="Finish Registering" OnClick="registerBtn_click"/>
    <br />
    <br />
    <asp:Label ID="successLabel" runat="server" Text="" />
</asp:Content>
