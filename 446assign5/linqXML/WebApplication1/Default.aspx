<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick1">
            </asp:Timer>
        </h1>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <Triggers>
  <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
</Triggers>
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" Text="check for the message every second"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <Triggers>
  <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
</Triggers>
            <ContentTemplate>
                <asp:Label ID="Label2" runat="server" Text="UpdatePanel2 not refreshed yet\"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <h1>message delivery system!</h1>
        <p>From who&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>To Whom&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>&nbsp;</p>
        <p>Message&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="95px" Width="312px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="send message" />
        </p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
        <p>My ID&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="get messages" />
        </p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
        <p>Display Messages</p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" Height="104px" Width="401px" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>&nbsp;</p>
        <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
        </asp:UpdatePanel>
    </div>

    <div class="row">
    </div>

</asp:Content>
