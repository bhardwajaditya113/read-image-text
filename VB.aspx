<%@ Page Language="VB" AutoEventWireup="false" CodeFile="VB.aspx.vb" Inherits="VB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body { font-family: Arial; font-size: 10pt; }
    </style>
</head>
<body>
<form id="form1" runat="server">
    Select File:
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button Text="Upload" runat="server" OnClick="Upload" />
    <hr />
    <asp:Label ID="lblText" runat="server" />
</form>
</body>
</html>
