<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Default8.aspx.cs" Inherits="Default8" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1
    {
             width: 100%;
            height: 200px;
            /*margin-top:30px;*/
            margin-left:200px;
        }
        .auto-style2
        {
             width: 159px;
         }
        .auto-style3
        {
            width: 270px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>
    <table class="auto-style1">
        
    <tr>
        <td class="auto-style2">
            &nbsp;</td>
        <td class="auto-style3">
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            &nbsp;</td>
        <td class="auto-style3">
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" Text="Email" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" Text="Password" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" style="margin-right: 0px; margin-top: 4px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="Button1" runat="server" BackColor="#009999" 
                BorderColor="#009999" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Medium" ForeColor="White" Text="LogIn" Width="70px" Height="32px" 
                onclick="Button1_Click" />
                 &nbsp;</td>
        <td class="auto-style3">
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BackColor="#009999" 
                BorderColor="#009999" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Medium" ForeColor="White" Text="Cancel" Width="70px" 
                Height="32px" onclick="Button2_Click" />
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
         <tr>
        <td class="auto-style2">
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 &nbsp;</td>
        <td class="auto-style3">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td>&nbsp;</td>
    </tr>
        
</table>
        </div>
</asp:Content>

