<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Searchpage.aspx.cs" Inherits="ClientProject.Searchpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Region Name: <asp:TextBox ID="txtregion" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <br />
             <br />
            <asp:Label ID="lnlbtech" runat="server" ></asp:Label>
            <br />
             <br />
            <asp:Label ID="lnlmedical" runat="server" ></asp:Label>
            <br />
             <br />
            <asp:Label ID="lblmba" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
