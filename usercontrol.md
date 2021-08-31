# USER CONTROL IN ASP.net
- The file name extension for the user control is .ascx.
- The user control does not have html, body, or form elements in it. These elements must be in the hosting page.
- User controls are used to have code which is used multiple times in an application.
- The user control can then be reused across the application
```C#
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FileUploder.ascx.cs" Inherits="UserControls.WebUserControl1" %>
<asp:FileUpload ID="FileUpload1" runat="server" />
<p>
    &nbsp;</p>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
```
```C#
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="UserControls.index" %>

<%@ Register src="FileUploder.ascx" tagname="FileUploder" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <uc1:FileUploder ID="FileUploder1" runat="server" />
    </form>
</body>
</html>
```
