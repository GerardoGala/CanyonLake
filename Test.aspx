<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Concatenator</h1>
    <asp:TextBox ID="TextBox1" runat="server" Font-Names="Courier New" 
        Font-Size="12pt" TextMode="MultiLine" Width="697px" ReadOnly="True" 
        Height="75px" Wrap="False"></asp:TextBox>
    <br />
    <asp:Button ID="ClearButton" runat="server" Text="Clear" 
        onclick="ClearButton_Click" />
    <hr /> 
    <asp:ListBox ID="ListBox1" runat="server" 
        onselectedindexchanged="ListBox1_SelectedIndexChanged" AutoPostBack="True">
        <asp:ListItem Selected="True">Apartment</asp:ListItem>
        <asp:ListItem>Commercial</asp:ListItem>
    </asp:ListBox>
    <div id="ApartmentDiv" runat="server" style="visibility: visible">
    <table>
        <tr>
            <td>
                ID:</td>
            <td>
                <asp:TextBox ID="ApartmentTextBox1" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="10" Width="110px" Wrap="False">0123456789</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Apartment Complex Name:</td>
            <td>
                <asp:TextBox ID="ApartmentTextBox2" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="20" Width="210px" Wrap="False">12345678901234567890</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                No. Of Residents:</td>
            <td>
                <asp:TextBox ID="ApartmentTextBox3" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="6" Width="67px" Wrap="False" 
                    ontextchanged="ApartmentTextBox3_TextChanged">123456</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                No. Of Vacancies:</td>
            <td>
                <asp:TextBox ID="ApartmentTextBox4" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="30" Width="67px" Wrap="False"></asp:TextBox>            
             </td>
        </tr>
        <tr>
            <td>
                Address:</td>
            <td>
                <asp:TextBox ID="ApartmentTextBox5" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="30" Width="330px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                State:</td>
            <td>
                <asp:TextBox ID="ApartmentTextBox6" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="2" Width="26px" Wrap="False">12</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Zip:</td>
            <td>
                <asp:TextBox ID="ApartmentTextBox7" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="5" Width="60px" Wrap="False">12345</asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="ApartmentButton" runat="server" Text="Enter" 
            onclick="ApartmentButton_Click" />
    </div>
    <div id="CommercialDiv" runat="server" style="visibility: visible">
    <table>
        <tr>
            <td>
                ID:</td>
            <td>
                <asp:TextBox ID="CommercialTextBox1" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="10" Width="110px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Business Name:</td>
            <td>
                <asp:TextBox ID="CommercialTextBox2" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="30" Width="330px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Address:</td>
            <td>
                <asp:TextBox ID="CommercialTextBox3" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="30" Width="330px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                State:</td>
            <td>
                <asp:TextBox ID="CommercialTextBox4" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="2" Width="26px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Zip:</td>
            <td>
                <asp:TextBox ID="CommercialTextBox5" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="5" Width="60px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Date:</td>
            <td>
                <asp:TextBox ID="CommercialTextBox6" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="8" Width="88px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Time:</td>
            <td>
                <asp:TextBox ID="CommercialTextBox7" runat="server" Font-Names="Courier New" 
                    Font-Size="12pt" MaxLength="4" Width="88px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="CommercialButton" runat="server" Text="Enter" 
            onclick="CommercialButton_Click" />
    </div>
    </form>
</body>
</html>
