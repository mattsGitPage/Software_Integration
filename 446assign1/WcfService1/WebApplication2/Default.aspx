<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Lower Limit"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="94px"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Upper Limit"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="128px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate Secret Number" Width="254px" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Make a Guess"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="130px"></asp:TextBox>
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Play" />
&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Attempts"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server" Width="26px"></asp:TextBox>
&nbsp;<asp:Label ID="Label5" runat="server" Text="The number is"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox5" runat="server" Width="142px"></asp:TextBox>
    </div>

</asp:Content>
