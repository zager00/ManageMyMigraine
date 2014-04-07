<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Connect.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>My Home Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                You are not logged in.Click the Login link to sign in..
            </AnonymousTemplate>
            <LoggedInTemplate>
                You are logged in.Welcome,
            </LoggedInTemplate>
        </asp:LoginView>
        <asp:LoginName ID="LoginName1" runat="server" />
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/MemberPages/ChangePassword.aspx">Change Password</asp:HyperLink>
        <br />
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/MemberPages/Members.aspx">Members-only page</asp:HyperLink>
        </p>
    </form>
</body>
</html>
