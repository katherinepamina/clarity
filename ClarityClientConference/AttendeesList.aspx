<%@ Page Title="Who's Attending" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AttendeesList.aspx.cs" Inherits="ClarityClientConference.AttendeesList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Who's Attending?</h2>
    <div>
        <asp:ListView ID="attendeesList"
            ItemType="ClarityClientConference.Models.Attendee"
            runat="server"
            SelectMethod="GetAttendees">
            <ItemTemplate>
                <b style="font-size: large; font-style: normal">
                    <%#:Item.Name  %>
                </b>
            </ItemTemplate>
            <ItemSeparatorTemplate> <br /> </ItemSeparatorTemplate>
        </asp:ListView>
    </div>
</asp:Content>
