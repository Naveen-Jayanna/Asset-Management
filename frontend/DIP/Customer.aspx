<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="DIP.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div  class="form-group">
    <br />
    <br />
    <asp:Label ID="lblSuite" runat="server" Text="Enter Customer Name">
    </asp:Label>
    <br />
    <asp:TextBox ID="txtName" class="form-control"
        runat="server" Width="540px"></asp:TextBox>
        <br />

           <br />
    <asp:Label ID="Label1" runat="server" Text="Enter Customer Address">
    </asp:Label>
    <br />
    <asp:TextBox ID="txtAdd" class="form-control"
        runat="server" Width="540px"></asp:TextBox>
        <br />
         <br />
    <asp:Label ID="Label2" runat="server" Text="Enter Customer Phone Number">
    </asp:Label>
    <br />
    <asp:TextBox ID="txtPhone" class="form-control"
        runat="server" Width="540px"></asp:TextBox>
        <br />   
        <br />
    <asp:Label ID="Label3" runat="server" Text="Enter Customer Aadhar Number">
    </asp:Label>
    <br />
    <asp:TextBox ID="txtAadhar" class="form-control"
        runat="server" Width="540px"></asp:TextBox>
        <br />
        <asp:Button
            ID="btnSubmit"  class="btn btn-default" runat="server" Text="ADD" 
        onclick="btnSubmit_Click" />
            <br />
</div>
    <div>
        <br />
    <asp:GridView ID="gvCustomer" runat="server" class="table table-bordered table-hover" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="CID" HeaderText="Customer ID" />
            <asp:BoundField DataField="Customer_Name" HeaderText="Customer Name" />
            <asp:BoundField DataField="Address" HeaderText="Address" />
            <asp:BoundField DataField="Phone" HeaderText="Phone" />
            <asp:BoundField DataField="Adhaar" HeaderText="Aadhar" />
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:LinkButton ID="lbEdit" runat="server" CommandArgument='<%# Eval("CID") %>' 
                        onclick="lbEdit_Click">Edit</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        <br />
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
