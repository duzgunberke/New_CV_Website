<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGuncelle.aspx.cs" Inherits="CvType2.YetenekGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <form id="Form1" runat="server">
       <div class="form-group">
             <div>
               <asp:Label ID="Label2" runat="server" Text="YETENEK"></asp:Label>
               <asp:TextBox ID="txtid" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
           <div>
               <asp:Label ID="Label1" runat="server" Text="YETENEK"></asp:Label>
               <asp:TextBox ID="txtyetenek" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
           <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click"  />

       </div>
   </form>
</asp:Content>
