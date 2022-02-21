<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 406px">
    <p>This is the order entry page</p>
    <form id="form1" runat="server">
        <div style="height: 24px">
            <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 11px" width="128px"></asp:TextBox>
            <br />
        </div>
        <br />
        <asp:Label ID="lblOrderNo" runat="server" Text="Order Number"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server" Height="16px" style="margin-left: 12px" width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblOrderQnty" runat="server" Text="Order Quantity"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderQnty" runat="server" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderPrice" runat="server" Text="Order Price"></asp:Label>
        <asp:TextBox ID="txtOrderPrice" runat="server" style="margin-left: 12px" width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateOfPurchase" runat="server" Text="Date of Purchase"></asp:Label>
&nbsp;<asp:TextBox ID="txtDateOfPurchase" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
&nbsp;
            <asp:CheckBox ID="chkDispatched" runat="server" Text="Dispatched" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" Text="OK" Width="36px" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
