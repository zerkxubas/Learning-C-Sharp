<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Quiz.aspx.cs" Inherits="Quiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Sample Form</h2>
            <span>Full Name : </span><asp:TextBox ID="txtInput" runat="server" placeholder="Enter your name"></asp:TextBox>
            <br /><br />
            <p>Select Gender : </p>
            <asp:RadioButtonList ID="rbOptions" runat="server">
                <asp:ListItem Text="Male" Value="male"></asp:ListItem>
                <asp:ListItem Text="Female" Value="female"></asp:ListItem>
                <asp:ListItem Text="Others" Value="other"></asp:ListItem>
            </asp:RadioButtonList>
            <br /><br />
            <asp:CheckBox ID="chkAgree" runat="server" Text="I am a student."></asp:CheckBox>
            <br /><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <br /><br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
