<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="Billing.aspx.cs" Inherits="DIP.Billing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="form-group">
   <br />
   <br />
   <asp:Label ID="lblSType" runat="server" Text="Enter the room Number for billing : "></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="txtRoom" class="form-control" Width="540px" 
           ValidationGroup="A" runat="server"></asp:TextBox>
            

    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnSubmit" runat="server"  class="btn btn-default" 
        Text="Submit" ValidationGroup="A" onclick="btnSubmit_Click" />
    <asp:GridView ID="gvMissing" class="table table-bordered table-hover" auto
        runat="server">

    </asp:GridView>

     </div>       

</asp:Content>
