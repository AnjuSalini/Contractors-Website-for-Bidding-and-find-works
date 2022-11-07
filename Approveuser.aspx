<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageHomeAdmin.master" AutoEventWireup="true" CodeFile="Approveuser.aspx.cs" Inherits="Approveuser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
            width: 543px;
        }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td style="font-size: large; text-decoration: underline; color: #008080;">Admin Approval</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:Label ID="Label1" runat="server" Text="User Id" ForeColor="#009999"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:Label ID="Label2" runat="server" Text="User Email"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:Button ID="btnApprove" runat="server" OnClick="btnApprove_Click" Text="Approved" BackColor="#009999" ForeColor="Black" />
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:Label ID="lblApprvd" runat="server" Text="Approved Successfully" Visible="False"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:Label ID="lblmsg" runat="server" Visible="False"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:GridView ID="gvData" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvData_SelectedIndexChanged" BorderColor="#009999" BorderWidth="3px">
                <Columns>
                    <asp:BoundField DataField="userrid" HeaderText="ID" />
                    <asp:BoundField DataField="fullname" HeaderText="Name" />
                    <asp:BoundField DataField="address" HeaderText="Address" />
                    <asp:BoundField DataField="mobileno" HeaderText="Contact No" />
                    <asp:BoundField DataField="email" HeaderText="Email" />
                    <asp:BoundField DataField="status" HeaderText="Status" />
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

