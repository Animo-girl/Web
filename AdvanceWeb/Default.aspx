<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID = "user_name" runat="server" Text="Enter Name"
        Font-size="40px"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID = "user_name_text" runat="server" Font-Size="30px"/>
        <br /><br />
        <asp:Button ID ="submit" runat="server" Text = "Submit" onclick="submit_Click"/>
        <br /><br />
        <asp:Label ID="user_display" runat="server" Text = " "> </asp:Label>

    </div>
    </form>
</body>
</html>
