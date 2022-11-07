<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageHomeAdmin.master" AutoEventWireup="true" CodeFile="Adminviewingdd.aspx.cs" Inherits="Adminviewingdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 359px;
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
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td style="font-size: large; color: #008080;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;View DD</td>
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
        <td>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowEditing="GridView1_RowEditing" BorderColor="#009999" BorderWidth="3px">
                <Columns>
                    <asp:BoundField DataField="userid" HeaderText="User Id" />
                    <asp:BoundField DataField="username" HeaderText="User Name" />
                    <asp:BoundField DataField="contractorid" HeaderText="Contractor id" />
                    <asp:BoundField DataField="contractorname" HeaderText="Contractor Name" />
                    <asp:BoundField DataField="date" HeaderText="Date" />
                    <asp:BoundField DataField="price" HeaderText="Price" />
                    <asp:ImageField DataImageUrlField="dd" HeaderText="DD">
                        <ControlStyle Height="50px" Width="100px" />
                    </asp:ImageField>
                    <asp:CommandField CancelText="" DeleteText="" EditText="Download" ShowCancelButton="False" ShowEditButton="True" />
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
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

