<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="220px" Width="498px"></asp:ListBox>
        </br>
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Edit" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
        <asp:Label ID="lblError" runat="server" Text="ErrorMessage"></asp:Label>
        
        <p>Enter A PostCode:</p>
        <asp:TextBox ID="postcode" runat="server"></asp:TextBox>

    <asp:Button ID="Button4" runat="server" Text="Apply" OnClick="ApplyButton" style="height: 35px" />
    <asp:Button ID="Button5" runat="server" Text="Clear" OnClick="ClearButton" />
    </form>
</body>
</html>
