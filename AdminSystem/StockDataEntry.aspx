<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label6" runat="server" Text="ItemID:" height="20px" width="150px"></asp:Label>
        <asp:TextBox ID="txtItemID" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Find_Click" Text="Find" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="ItemName:" height="20px" width="150px"></asp:Label>
        <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label2" runat="server" Text="ItemQuantity:" height="20px" width="150px"></asp:Label>
        <asp:TextBox ID="txtItemQuantity" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label3" runat="server" Text="ItemOver18:" height="20px" width="150px"></asp:Label>
        <asp:Checkbox ID="txtItemOver18" runat="server"></asp:Checkbox>
        <br/>
        <asp:Label ID="Label4" runat="server" Text="ItemPrice:" height="20px" width="150px"></asp:Label>
        <asp:TextBox ID="txtItemPrice" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label5" runat="server" Text="ItemDateAdded:" height="20px" width="150px"></asp:Label>
        <asp:TextBox ID="txtItemDateAdded" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" Text=" Ok " OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
