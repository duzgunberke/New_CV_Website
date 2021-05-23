<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KonferansGuncelle.aspx.cs" Inherits="CvType2.KonferansGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
       <form id="Form1" runat="server">
       <div class="form-group">
           <div>
               <asp:Label ID="Label3" runat="server" Text="ID"></asp:Label>
               <asp:TextBox ID="txtid" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
           <div>
               <asp:Label ID="Label1" runat="server" Text="EKSTRA"></asp:Label>
               <asp:TextBox ID="txtekstra" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
            <div>
               <asp:Label ID="Label2" runat="server" Text="LINK"></asp:Label>
               <asp:TextBox ID="txtlınk" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
           <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click"  />

       </div>
   </form>
</asp:Content>
