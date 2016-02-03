<%@ Page Title="Who's Attending" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AttendeesList.aspx.cs" Inherits="ClarityClientConference.AttendeesList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Who's Attending?</h2>
    <div>
        <asp:ListView ID="clientsList"
            ItemType="ClarityClientConference.Models.Client"
            runat="server"
            SelectMethod="GetAttendingClients">
            <ItemTemplate>
                <b style="font-size: large; font-style: normal"><%#:Item.Name  %>
                </b<br /><br />
                Phone: <%#:Item.PhoneNumber %> <br />
                Email: <%#:Item.Email %> <br />
                Address: <%#Item.Street %> , <%#:Item.City %> , <%#:Item.State %> <%#:Item.ZipCode %><br />
            </ItemTemplate>
            <ItemSeparatorTemplate> <br /> </ItemSeparatorTemplate>
        </asp:ListView>
        <br />
        <br />
        <b style="font-size: large; font-style: normal; text-decoration: underline">Attendees<br /></b>
        <asp:ListView ID="attendeesList"
            ItemType="ClarityClientConference.Models.Attendee"
            runat="server"
            SelectMethod="GetAttendeesByClient">
            <ItemTemplate>
                <b style="font-size: large; font-style: normal"><%#:Item.Name %></b>
            </ItemTemplate>
            <ItemSeparatorTemplate> <br /> </ItemSeparatorTemplate>
        </asp:ListView>

    </div>
</asp:Content>
