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
<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
     <ContentTemplate> 
    <asp:Button ID="btnSubmit" runat="server"  class="btn btn-default" 
        Text="Submit" ValidationGroup="A" onclick="btnSubmit_Click" />
    <br />
    <br />
        <asp:Label ID="lblMissing" runat="server" Text=""></asp:Label>
    <asp:GridView ID="gvMissing" class="table table-bordered table-hover" auto
        runat="server">
    
    </asp:GridView>
    <br />
    <br />
    <asp:Label ID="lblMissingMsg" runat="server" Text=""></asp:Label>
    &nbsp;<br />
    <br />
    <asp:Label ID="lblBasePrice" runat="server" Text=""></asp:Label>
     <br />
    <br />
     <asp:Label ID="lblItems" runat="server" Text="">
     </asp:Label>
    <br />
    <br />
    <asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>
    </ContentTemplate>
    
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate>
        <img src="200.gif" alt="Please wait" />
        </ProgressTemplate>
        </asp:UpdateProgress>


     </div>       

</asp:Content>
