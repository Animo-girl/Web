<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID = "userEnter" runat="server" Text = "Enter a number" />
        &nbsp;&nbsp;&nbsp;

        <asp:TextBox ID="numFeild" runat="server"/>

        <br /><br />
        <asp:Button ID ="submit_num" runat="server" Text="Submit" 
            onclick="submit_num_Click" />
        <br />
        <asp:Label ID = "show" runat="server" Text=" "/>
    </div>
    </form>
</body>
</html>
