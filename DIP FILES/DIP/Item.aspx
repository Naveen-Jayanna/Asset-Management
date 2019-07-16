<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="DIP.Item" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="form-group">
   <br />
   <br />
   <asp:Label ID="lblSType" runat="server" Text="Enter the Suite Type "></asp:Label>
    <br />
    <asp:TextBox ID="txtSuite" runat="server" class="form-control" Width="540px" 
           ValidationGroup="A"></asp:TextBox>
    <br />
    <asp:Label ID="lblAddtem" runat="server" Text="Enter the item to be added"></asp:Label>
    <br />
    <asp:TextBox ID="txtAddItem" runat="server" class="form-control" Width="540px" 
           ValidationGroup="A"></asp:TextBox>
    <br />
    <asp:Label ID="lblCount" runat="server" Text="Enter the count of the item added"></asp:Label>
    <br />
    <asp:TextBox ID="txtCount" runat="server" class="form-control" Width="540px" 
           ValidationGroup="A"></asp:TextBox>
    <br />
    <asp:Label ID="lblCost" runat="server" Text="Enter the cost of the Item"></asp:Label>
    <br />
       <asp:TextBox ID="txtCost" runat="server" class="form-control" Width="540px" 
           ValidationGroup="A"></asp:TextBox>
    <br />
     <asp:Button
            ID="btnSubmit"  class="btn btn-default" runat="server" Text="ADD" 
        onclick="btnSubmit_Click" ValidationGroup="A" />
        <br />
        <br />

        </div>
        
    <asp:GridView ID="gvItem" runat="server" class="table table-bordered table-hover" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="SID" HeaderText="Suite" />
            <asp:BoundField DataField="Item_Name" HeaderText="Item Name" />
            <asp:BoundField DataField="Count" HeaderText="Count" />
            <asp:BoundField DataField="Cost" HeaderText="Cost" />
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:LinkButton ID="lnEdit" runat="server" 
                        CommandArgument='<%# Eval("Item_Id") %>'
                        onclick="lnEdit_Click">Edit</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:LinkButton ID="lnDelete" runat="server" 
                        CommandArgument='<%# Eval("Item_Id") %>'
                        onclick="lnDelete_Click">Delete</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
    <br />
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>

</asp:Content>
