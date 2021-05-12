<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test2.aspx.cs" Inherits="WebApplication1.test2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:TextBox ID="user" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </br>
    <asp:TextBox ID="passwd" runat="server" OnTextChanged="passwd_TextChanged"></asp:TextBox>
    </br>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</asp:Content>
