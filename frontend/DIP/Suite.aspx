<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="Suite.aspx.cs" Inherits="DIP.Suite" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div  class="form-group">
    <br />
    <br />
    <asp:Label ID="lblSuite" runat="server" Text="Enter Suite Type">
    </asp:Label>
    <br />
    <asp:TextBox ID="txtSuite" class="form-control"
        runat="server" Width="540px"></asp:TextBox>
        <br />

        <asp:Label ID="Label2" runat="server" Text="Enter Base Price"></asp:Label>
        <br />
    <asp:TextBox ID="txtBase" class="form-control"  runat="server" Width="540px"></asp:TextBox>
        <br />
        <asp:Button
            ID="btnSubmit"  class="btn btn-default" runat="server" Text="ADD" 
        onclick="btnSubmit_Click" />
            <br />
</div>
    <div>
        <br />
    <asp:GridView ID="gvSuite" runat="server" class="table table-bordered table-hover" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Suite_Type" HeaderText="Suite" />
            <asp:BoundField DataField="Base_Price" HeaderText="Base Price" />
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:LinkButton ID="lbEdit" runat="server" CommandArgument='<%# Eval("SID") %>' 
                        onclick="lbEdit_Click">Edit</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:LinkButton ID="lbDelete" runat="server" 
                        CommandArgument='<%# Eval("SID") %>' onclick="lbDelete_Click">Delete</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        <br />
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

