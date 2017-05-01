<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
            width: 313px;
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
        .auto-style4
        {
            width: 313px;
            height: 28px;
        }
        .auto-style5
        {
            width: 313px;
            height: 29px;
        }
        .auto-style6
        {
            width: 313px;
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div>
    <table class="auto-style1">
        
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" 
                Text="User ID" Font-Names="Times New Roman"></asp:Label>
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
                Text="UserName" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox2" runat="server" Font-Names="Times New Roman" 
                Font-Size="Medium" style="margin-top: 3px"></asp:TextBox>
        </td>
        <td class="style9"></td>
    </tr>
    <tr>
        <td class="style7">
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" Text="Email" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox3" runat="server" Font-Names="Times New Roman" 
                Font-Size="Medium"></asp:TextBox>
        </td>
        <td class="style9"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" Text="Password" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox4" runat="server" Font-Names="Times New Roman" 
                Font-Size="Medium" TextMode="Password"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" 
                Text="Qualification" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox5" runat="server" Font-Names="Times New Roman" 
                Font-Size="Medium"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Medium" 
                Text="About Us" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox6" runat="server" Font-Names="Times New Roman" 
                Font-Size="Medium" style="margin-top: 5px" TextMode="MultiLine" Width="193px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" 
                Text="Gender" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:DropDownList ID="DropDownList1" runat="server" 
                Font-Names="Times New Roman" Font-Size="Medium" Height="27px" 
                Width="200px">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="style6"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Medium" 
                Text="City" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox8" runat="server" Font-Names="Times New Roman" 
                Font-Size="Medium"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
   <tr>
        <td class="auto-style2">
            <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Medium" 
                Text="State" Font-Names="Times New Roman"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox9" runat="server" Font-Names="Times New Roman" 
                Font-Size="Medium" style="margin-top: 2px"></asp:TextBox>
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
            Existng User&nbsp;&nbsp; <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" 
                onclick="LinkButton1_Click" Font-Names="Times New Roman">Login Here</asp:LinkButton>
            &nbsp;</td>
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

