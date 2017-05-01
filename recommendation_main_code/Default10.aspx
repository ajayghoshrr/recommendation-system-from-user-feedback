<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default10.aspx.cs" Inherits="Default10" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="height:400px; margin-top:0px;margin-left:100px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="appid" DataValueField="appid" Font-Names="Times New Roman" Font-Size="Medium" Height="18px" Width="142px"></asp:DropDownList>
        &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        <br />
        <br />
        <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true"
    OnPageIndexChanging="OnPageIndexChanging" PageSize="10" 
            OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="411px" 
            HeaderStyle-Font-Size="Medium" HeaderStyle-BackColor="#2E3C59" 
            HeaderStyle-ForeColor="White" Font-Names="Times New Roman" 
            Font-Size="Medium" Height="180px">
    <Columns>
       <%-- <asp:ButtonField Text="Accept" CommandName="Select" ItemStyle-Width="80px" />
        <asp:TemplateField ItemStyle-HorizontalAlign = "Center">
            <ItemTemplate>
                <asp:LinkButton ID="lnkstatus" runat="server" Text="Profile" OnClick="status" 
                       ForeColor="#FF3300" Font-Size="Medium" ItemStyle-Width="130px"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>--%>
        <asp:BoundField ItemStyle-Width="100px" DataField="appid" HeaderText="App ID" >
<ItemStyle Width="150px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField ItemStyle-Width="100px" DataField="aname" HeaderText="App Name" >
<ItemStyle Width="150px"></ItemStyle>
        </asp:BoundField>
      <%--  <asp:BoundField ItemStyle-Width="150px" DataField="age" HeaderText="City" />--%>
        <asp:BoundField ItemStyle-Width="100px" DataField="uname" HeaderText="User Name" >
<ItemStyle Width="150px"></ItemStyle>
        </asp:BoundField>
         <asp:BoundField ItemStyle-Width="100px" DataField="val" HeaderText="Rattings"  ItemStyle-HorizontalAlign="Justify">
<ItemStyle Width="150px" HorizontalAlign="Center"></ItemStyle>
        </asp:BoundField>
     <%--   <asp:BoundField ItemStyle-Width="100px" DataField="" HeaderText="Rattings">
<ItemStyle Width="150px"></ItemStyle>
        </asp:BoundField>--%>
    </Columns>

<HeaderStyle BackColor="#009999" Font-Size="Medium" ForeColor="White"></HeaderStyle>
</asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ratingConnectionString %>" SelectCommand="SELECT [appid] FROM [app]"></asp:SqlDataSource>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" ForeColor="Red">Overall Rating</asp:Label>
        &nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
</asp:Content>

