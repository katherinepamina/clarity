<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClarityClientConference._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Clarity Client Conference</h1>
        <p class="lead">The Clarity Client Conference is being held to bring clients together to discuss how great it is working with Clarity Consulting.</p>
        <p style="font-size: 1em">20 N Wacker Dr. Suite 1450<br /> Chicago, IL 60606</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <a class="btn btn-default" href="/Register.aspx">Register &raquo;</a>
        </div>
        <div class="col-md-4">
            <a class="btn btn-default" href="/AttendeesList.aspx">Who's Attending? &raquo;</a>
        </div>
    </div>

</asp:Content>
