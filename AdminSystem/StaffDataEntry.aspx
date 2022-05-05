<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="lblStaffId" runat="server" Text="StaffId : " width="193px"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server" OnTextChanged="TextBox8_TextChanged"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblName" runat="server" Text="Name : " width="193px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblPhone" runat="server" Text="Phone : " width="193px"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server" OnTextChanged="txtPhone_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblAddress" runat="server" Text="Address : " width="193px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" OnTextChanged="txtAddress_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblStartedDate" runat="server" Text="StartedDate : " width="193px"></asp:Label>
            <asp:TextBox ID="txtStartedDate" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblSalary" runat="server" Text="Salary : " width="193px"></asp:Label>
            <asp:TextBox ID="txtSalary" runat="server" OnTextChanged="TextBox7_TextChanged" style="margin-bottom: 0px; height: 41px;"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:CheckBox ID="chkIntern" runat="server" Text="Intern" OnCheckedChanged="chkIntern_CheckedChanged" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="margin-right: 0px" Text="OK" Width="76px" />
&nbsp;<asp:Button ID="btnCancle" runat="server" Text="Cancel" OnClick="btnCancle_Click" />
        </div>
&nbsp;</form>
</body>
</html>
