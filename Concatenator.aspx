<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Concatenator.aspx.cs" Inherits="Concatenator" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Concatenator</title>
</head>
<body>
    <form id="form1" runat="server" 
    style="padding: 20px; margin: 20px; background-color: #F0F0F0;">
    <asp:Label ID="Label1" runat="server" Text="Batch File Maker"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Height="218px" TextMode="MultiLine" 
        Width="100%" Wrap="False" Font-Names="Courier New"></asp:TextBox>
    <br />
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Button ID="ClearButton" runat="server" Text="Clear" 
                    onclick="ClearButton_Click" />
            </td>
            <td align="right">
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <hr />  
    <asp:DropDownList ID="DropDownList1" runat="server" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="200px" 
        AutoPostBack="True">
    </asp:DropDownList>
    <asp:Button ID="EnterButton" runat="server" 
        onclick="EnterButton_Click" Text="Enter" UseSubmitBehavior="False" 
        PostBackUrl="~/Concatenator.aspx" />
    <hr />
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>


    </form>
</body>
</html>
