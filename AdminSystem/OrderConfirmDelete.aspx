<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Are you sure you want to delete this record?</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
&nbsp;<asp:Button ID="Button1" runat="server" Text="No" />
    </form>
</body>
</html>
