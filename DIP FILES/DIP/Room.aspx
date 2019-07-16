<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="Room.aspx.cs" Inherits="DIP.Room" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="form-group">
   <br />
   <br />
   <asp:Label ID="lblSType" runat="server" Text="Select the Suite Type "></asp:Label>
    <br />
    <asp:DropDownList ID="ddlSuite" runat="server" class="form-control"
        Width="540px" onselectedindexchanged="ddlSuite_SelectedIndexChanged" 
        AutoPostBack="True">
        
    </asp:DropDownList>
    <br />
    <asp:Label ID="lblAddtem" runat="server" Text="Select the Room Number "></asp:Label>
    <br />
    <asp:DropDownList ID="ddlRoom" runat="server" class="form-control" 
        Width="540px" AutoPostBack="True" 
        onselectedindexchanged="ddlRoom_SelectedIndexChanged">
        
    </asp:DropDownList>
    <br />
    <asp:Label ID="lblCount" runat="server" Text="Enter CID" ></asp:Label>
    <br />
    <asp:TextBox ID="txtCID" runat="server" class="form-control" Width="540px" 
           ValidationGroup="A"></asp:TextBox>
    <br />
    <asp:Label ID="lblCost" runat="server" Text="Enter CheckIn Time in the format DD-MM-YYYY HH:MM:SS"></asp:Label>
    <br />
       <asp:TextBox ID="txtCheckIn" runat="server" class="form-control" Width="540px" 
           ValidationGroup="A"></asp:TextBox>
    <br />
    <asp:Label ID="lblCheckOut" runat="server" Text="Enter CheckOut Time in the format DD-MM-YYYY HH:MM:SS"></asp:Label>
    <br />
       <asp:TextBox ID="txtCheckOut" runat="server" class="form-control" Width="540px" 
          ></asp:TextBox>

    <br />
    <asp:Button
            ID="btnSubmit"  class="btn btn-default" runat="server" Text="ADD" 
        onclick="btnSubmit_Click" ValidationGroup="A" />
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
    </br>
    <div class="form-group">
        <asp:GridView ID="gvRoom" runat="server" 
            class="table table-bordered table-hover" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Room_No" HeaderText="Room Number" />
                <asp:BoundField DataField="SID" HeaderText="SID" />
                <asp:BoundField DataField="CID" HeaderText="CID" />
                <asp:BoundField DataField="Check_in" HeaderText="CheckIn Time" />
                <asp:BoundField DataField="Check_Out" HeaderText="CheckOut Time" />
            </Columns>
        </asp:GridView>
    <div>
    
</asp:Content>
