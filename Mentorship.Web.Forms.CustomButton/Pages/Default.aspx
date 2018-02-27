<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mentorship.Web.Forms.CustomButton.Pages.Default" %>
<%@ Register Assembly="Mentorship.ServerControl.CusomButton" Namespace="Mentorship.ServerControl.CustomButton" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Webform</title>
    <link href="../Styles/stone_button.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <cc1:StoneButton  id="first" runat="server" Size="small" />
            <cc1:StoneButton enabled="true" Theme="gray" size="bigger" runat="server" Text="PushMe"/> 
            <cc1:StoneButton Enabled="true" Theme ="yellow" Size ="small" Text="enabled" runat="server"/>
            <cc1:StoneButton Enabled="false" Theme="gray" Size="bigger" runat="server" Text="Disable" />
            <asp:label id="label1" runat="server" text=""></asp:label>
        </div>
    </form>
</body>
</html>
