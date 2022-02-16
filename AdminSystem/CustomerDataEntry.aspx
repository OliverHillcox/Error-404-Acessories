<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Customer Name"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Birthday" height="19px" width="100px"></asp:Label>
        <asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label3" runat="server" Text="PhoneNumber" height="19px" width="100px"></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label4" runat="server" Text="Email Address" height="19px" width="100px"></asp:Label>
        <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label5" runat="server" Text="PostCode" height="19px" width="100px"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label6" runat="server" Text="Address" height="19px" width="100px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label7" runat="server" Text="Over 18" height="19px" width="100px"></asp:Label>
        <asp:CheckBox ID="chkOver18" runat="server" Text=" " />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="ErrorMessage"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" Text=" Ok " OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
