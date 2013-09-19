<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RecordsUpload.aspx.cs" Inherits="RecordsUpload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>


        <asp:Panel ID="Panel1" runat="server" Height="100px"
            Width="500px">
            <br />
            &nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="False" 
                Text="Upload Records.xml:"></asp:Label>
            &nbsp;
            <asp:FileUpload ID="FUFile" runat="server" Font-Bold="False" Width="250px" />
            <br />
            <br />
            <asp:Button ID="btnUpload" runat="server" Font-Bold="False" 
                onclick="btnUpload_Click" Text="Upload" />
        </asp:Panel>
        <br />
        <br />

    
    </div>
    </form>
</body>
</html>
