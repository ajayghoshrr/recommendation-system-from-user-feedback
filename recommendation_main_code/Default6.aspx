<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 128px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="margin-left:250px;margin-top:0px; width: 450px;">
        
        
        <tr>
            <td class="style1">
                <asp:Label ID="Label3" runat="server" Text="Email" Font-Bold="True" 
                    Font-Names="Times New Roman"></asp:Label></td>
            <td class="style3">
                <asp:TextBox ID="TextBox2" runat="server" style="margin-top: 5px" Width="193px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
             </td>
        </tr>
          <tr>
            <td class="style1">
                <asp:Label ID="Label6" runat="server" Text="Secret Key" Font-Bold="True" 
                    Font-Names="Times New Roman"></asp:Label></td>
            <td class="style3">
            <asp:TextBox ID="TextBox6" runat="server" Font-Names="Times New Roman" 
                Font-Size="Medium" style="margin-top: 5px" Width="193px" TextMode="Password"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
             </td>
        </tr>
        
       
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
<asp:Button ID="btnUpload" runat="server" Text="Ok" OnClick="Upload" BackColor="#009999" BorderColor="#009999" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Medium" ForeColor="White" Width="82px" />
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

