<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDeneyimGuncelle.aspx.cs" Inherits="CvType2.AdminDeneyimGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form id="Form1" runat="server">
       <div class="form-group">
           <div>
               <asp:Label ID="Label5" runat="server" Text="ID"></asp:Label>
               <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
           <div>
               <asp:Label ID="Label1" runat="server" Text="BASLIK"></asp:Label>
               <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
             <div>
               <asp:Label ID="Label2" runat="server" Text="ALT BASLIK"></asp:Label>
               <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
            <div>
               <asp:Label ID="Label3" runat="server" Text="ACIKLAMA"></asp:Label>
               <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" TextMode="MultiLine" Height="100px"></asp:TextBox>
           </div>
           <br />
            <div>
               <asp:Label ID="Label4" runat="server" Text="TARIH"></asp:Label>
               <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
           <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click"   />

       </div>
   </form>
</asp:Content>
