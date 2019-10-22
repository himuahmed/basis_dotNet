<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="webForm__.StudentList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style4 {
            width: 210px;
            height: 61px;
        }
        .auto-style5 {
            height: 61px;
        }
        .auto-style7 {
            width: 210px;
            text-align: right;
        }
        .auto-style2 {
            width: 210px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style4">Student Information Management</td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style7">First Name:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="firstNameTextBox" runat="server" Width="219px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">Last Name:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="lastNameTextBox" runat="server" Width="219px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">User Name:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="userNameTextBox" runat="server" Width="219px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">Reg No:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="regNoTextBox" runat="server" Width="219px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">Email:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="emailTextBox" runat="server" Width="219px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">Age:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="ageTextBox" runat="server" Width="219px"></asp:TextBox>
                    </td>
                    <td>
                    
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">
&nbsp;&nbsp;&nbsp;<asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="message" runat="server" Text=""></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:ListBox ID="nameListBox" runat="server" Height="325px" Width="222px"></asp:ListBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        <div>
        </div>
    </form>
</body>
</html>
