<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID ="name" runat="server" Text = "Enter name" Font-Size="30px"/>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID = "nameEntry" runat="server" Font-Size="25px"/>
            <br /><br />
            <asp:CheckBox ID="cb1" runat="server" Text="Bold" Font-Bold=true Font-Size="18px"/>&nbsp;
            <asp:CheckBox ID="cb2" runat="server" Text="Italic" Font-Italic=true Font-Size="18px"/>&nbsp;
            <asp:CheckBox ID="cb3" runat="server" Text="Underline" Font-Underline=true Font-Size="18px"/>
            <br /><br />
            <asp:Button ID="Button_submit" runat="server" Text="Submit" 
                onclick="Button_submit_Click" Font-Size="18px" BackColor="#FFFF99"/>
            <br /><br />
            <asp:Label ID="show_now" runat="server" Text=" "/>
        </div>
    </form>
</body>
</html>
