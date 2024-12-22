<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Assignments.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Insert your details :
            Name : &nbsp ; &nbsp ; &nbsp ; &nbsp ; &nbsp
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            Family Name : &nbsp ; &nbsp ; &nbsp ; &nbsp ; &nbsp
            <asp:TextBox ID="txtFN" runat="server"></asp:TextBox>
            Address : &nbsp ; &nbsp ; &nbsp ; &nbsp ; &nbsp
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            City : &nbsp ; &nbsp ; &nbsp ; &nbsp ; &nbsp
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            Zip Code : &nbsp ; &nbsp ; &nbsp ; &nbsp ; &nbsp
            <asp:TextBox ID="txtZC" runat="server"></asp:TextBox>
            Phone Number  : &nbsp ; &nbsp ; &nbsp ; &nbsp ; &nbsp
            <asp:TextBox ID="txtPN" runat="server"></asp:TextBox>
            E-Mail : &nbsp ; &nbsp ; &nbsp ; &nbsp ; &nbsp
            <asp:TextBox ID="txtEMail" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
