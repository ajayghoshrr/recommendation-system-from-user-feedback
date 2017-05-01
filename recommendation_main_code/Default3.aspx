<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height:880px; margin-top:0px;margin-left:100px; font-family: 'Times New Roman', Times, serif;">
        <table>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" ForeColor="#FF3300"></asp:Label>
                    &nbsp;</td>
            </tr>
             <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;</td>
            </tr>
        </table> 
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                        ForeColor="#333333" GridLines="None" Height="16px" ShowFooter="True"
                    Width="93%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" >
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:TemplateField ItemStyle-HorizontalAlign = "Center">
            <ItemTemplate>
                <asp:LinkButton ID="lnkstatus" runat="server" Text="Rating" OnClick="status" 
                       ForeColor="#FF3300" Font-Size="Medium" ></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
                      <asp:ButtonField Text="Download" CommandName="Select" ItemStyle-Width="80px" />
                      <asp:TemplateField HeaderText="Image" >
                        <ItemTemplate>
                        <a rel="lightbox" href='<%# "imghandler.ashx?ImID="+ Eval("appid") %>'>
                        <asp:Image  ID="Image1" class="lightbox" Width="100px" runat="server" ImageUrl='<%# "imghandler.ashx?ImID="+ Eval("appid") %>'/> <%--</a>--%>
                       <%-- <asp:Image ID="img" runat="server" Width="100px" Height="100px" ImageUrl='<%# "Handler.ashx?ImID="+ Eval("img") %>'/>--%>
<%--                         <asp:Image ID="Image1" runat="server" Width="100px" Height="100px" />
--%>                        </ItemTemplate>
                        </asp:TemplateField>
                     
                            <asp:BoundField DataField="appid" HeaderText="ID" />
                        <asp:BoundField DataField="aname" HeaderText="Name" />
                        <asp:BoundField DataField="description" HeaderText="Description" />
                         
                        </Columns>
                        <RowStyle BackColor="#E3EAEB" />
                        <EditRowStyle BackColor="#7C6F57" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
        </div>
</asp:Content>

