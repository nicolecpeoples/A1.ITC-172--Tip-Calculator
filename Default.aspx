<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1> Tip Calculator </h1>
        <p>
            <asp:Label ID="lblAmount" runat="server" Text="Enter the Amount: " CssClass="label"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox> &nbsp;
        </p>
    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Select Tip Amount: " CssClass="label"></asp:Label>
        </p>
        <div>
        <p>
            <asp:RadioButtonList ID="rdbPercentage" runat="server">
                <asp:ListItem Text ="10%" Value=".1"></asp:ListItem>
                <asp:ListItem Text ="15%" Value=".15"></asp:ListItem>
                <asp:ListItem Text ="20%" Value=".2"></asp:ListItem>
                <asp:ListItem Text ="other"></asp:ListItem>
            </asp:RadioButtonList>
        </p>
            <p>
                <asp:Label ID="lblOther" runat="server" Text="Other Amount:"></asp:Label> &nbsp;
                <asp:TextBox ID="txtOther" runat="server"></asp:TextBox>
            </p>
        <p>
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" CssClass="button" OnClick="btnCalculate_Click" />
        </p>
        <p>
            <asp:Label ID="lblTip" runat="server" CssClass="result"></asp:Label> <br />
            <asp:Label ID="lblTotal" runat="server" ></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
