﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehicleInfoForm.aspx.cs" Inherits="VehicleInfo.VehicleInformationUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 302px;
		}
		.auto-style2 {
			width: 281px;
			text-align: center;
			height: 60px;
		}
		.auto-style3 {
			width: 256px;
		}
		.auto-style4 {
			width: 302px;
			text-align: right;
		}
		.auto-style5 {
            width: 256px;
            text-align: left;
        }
	</style>
</head>
<body style="height: 67px">
    <form id="form1" runat="server">
		
        <div>

        	<table style="width:100%;">
				<tr>
					<td class="auto-style1">&nbsp;</td>
					<td class="auto-style3"><h1 class="auto-style2">Vehicle Information</h1>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style4">Vehicle Name:</td>
					<td class="auto-style3">
						<asp:TextBox ID="vehicleNameTextBox" runat="server" Width="251px"></asp:TextBox>
					</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style4">Reg No:</td>
					<td class="auto-style3">
						<asp:TextBox ID="regNoTextBox" runat="server" Width="249px"></asp:TextBox>
					</td>
					<td>
						<asp:Button ID="createButton" runat="server" Text="Create" OnClick="createButton_Click" />
					</td>
				</tr>
				<tr>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style3">
                        <asp:Label ID="vehicleErrorLabel" runat="server"></asp:Label>
                    </td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style4">Speed:</td>
					<td class="auto-style3">
						<asp:TextBox ID="speedTextBox" runat="server" Width="254px"></asp:TextBox>
					</td>
					<td>
						<asp:Button ID="speedEnterButton" runat="server" Text="Enter" OnClick="speedEnterButton_Click" Width="55px" />
					</td>
				</tr>
				<tr>
					<td class="auto-style1">&nbsp;</td>
					<td class="auto-style3">
                        <asp:Label ID="showErrorLabel" runat="server"></asp:Label>
                    </td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style1">&nbsp;</td>
					<td class="auto-style3">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style4">Max Speed:</td>
					<td class="auto-style5">
						<asp:TextBox ID="maxTextBox" runat="server" Width="249px"></asp:TextBox>
					</td>
					<td>
						<asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" Width="56px" />
					</td>
				</tr>
				<tr>
					<td class="auto-style4">&nbsp;Min Speed&nbsp;:</td>
					<td class="auto-style5">
						<asp:TextBox ID="minTextBox" runat="server" Width="247px"></asp:TextBox>
					</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style4">Avg Speed:</td>
					<td class="auto-style5">
						<asp:TextBox ID="avgTextBox" runat="server" Width="249px"></asp:TextBox>
					</td>
					<td>&nbsp;</td>
				</tr>
				</table>

        </div>
    </form>
</body>
</html>
