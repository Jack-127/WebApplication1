<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebApplication1.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br>
            <input type="text" id="user" name ="user2">
            <br>
            <input type="text" id="passwd" name ="passwd2">
            <br>
            <input type="submit" value="Submit" />
        </div>
    </form>
</body>
</html>
