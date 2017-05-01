<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default7.aspx.cs" Inherits="Default7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style type="text/css">
    .auto-style1
    {
             width: 100%;
            height: 200px;
            /*margin-top:30px;*/
            margin-left:250px;
        }
        .auto-style2
        {
            width: 197px;
        }
        .auto-style3
        {
             width: 433px;
         }
        .style1
        {
            width: 197px;
            height: 28px;
        }
        .style2
        {
            width: 270px;
            height: 28px;
        }
        .style3
        {
            height: 28px;
        }
        .style4
        {
            width: 197px;
            height: 30px;
        }
        .style5
        {
            width: 270px;
            height: 30px;
        }
        .style6
        {
            height: 30px;
        }
     .style7
     {
         width: 197px;
         height: 29px;
     }
     .style8
     {
         width: 270px;
         height: 29px;
     }
     .style9
     {
         height: 29px;
     }
        .auto-style5
        {
             width: 433px;
             height: 29px;
         }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <table class="auto-style1">
        
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" 
                Text="App ID" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox1" runat="server" Font-Names="Times New Roman" 
                Font-Size="Medium"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="style7">
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" 
                Text="App Name" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox2" runat="server" Font-Names="Times New Roman" 
                Font-Size="Medium" style="margin-top: 3px"></asp:TextBox>
        </td>
        <td class="style9"></td>
    </tr>
    <tr>
        <td class="style7">
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" Text="User Email" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox3" runat="server" Font-Names="Times New Roman" 
                Font-Size="Medium"></asp:TextBox>
        </td>
        <td class="style9"></td>
    </tr>
    <tr>
        <td class="style7">
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" Text="App Image" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style5">
            &nbsp;<a rel="lightbox" href='<%# "imghandler.ashx?ImID="+ Eval("appid") %>'>
                <asp:Image  ID="Image1" class="lightbox" Width="100px" runat="server" ImageUrl='<%# "imghandler.ashx?ImID="+ Eval("appid") %>'/></a></td>
        <td class="style9"></td>
    </tr>
    <tr>
        <td class="style7">
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" 
                Text="Rating" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:RadioButton ID="RadioButton5" runat="server" Font-Names="Times New Roman" Text="Bad" GroupName="review"/>
&nbsp;<asp:RadioButton ID="RadioButton1" runat="server" Font-Names="Times New Roman" Text="Poor" GroupName="review" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" Font-Names="Times New Roman" Text="Avg" GroupName="review"/>
&nbsp;<asp:RadioButton ID="RadioButton3" runat="server" Font-Names="Times New Roman" Text="Good" GroupName="review"/>
&nbsp;<asp:RadioButton ID="RadioButton4" runat="server" Font-Names="Times New Roman" Text="Excellant" GroupName="review"/>
&nbsp;</td>
        <td class="style9"></td>
    </tr>
   <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    
         <tr>
        <td class="auto-style2">
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="Button1" runat="server" BackColor="#009999" 
                     BorderColor="#009999" Font-Bold="True" Font-Names="Times New Roman" 
                     Font-Size="Medium" ForeColor="White" Text="Save" Width="70px" 
                     onclick="Button1_Click" />
                 &nbsp;</td>
        <td class="auto-style3">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BackColor="#009999" 
                BorderColor="#009999" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Medium" ForeColor="White" OnClick="Button2_Click" Text="Cancel" 
                Width="70px" />
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
         <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Visible="False"></asp:Label>
             </td>
        <td>&nbsp;</td>
    </tr>
         <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
        </div>
</asp:Content>

