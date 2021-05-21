<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Hakkımda.aspx.cs" Inherits="CvType2.Hakkımda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   <form id="Form1" runat="server">
       <div class="form-group">
           <div>
               <asp:Label ID="Label1" runat="server" Text="Adınız"></asp:Label>
               <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
             <div>
               <asp:Label ID="Label2" runat="server" Text="Soyadınız"></asp:Label>
               <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
            <div>
               <asp:Label ID="Label3" runat="server" Text="Adres"></asp:Label>
               <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
            <div>
               <asp:Label ID="Label4" runat="server" Text="Mail"></asp:Label>
               <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
            <div>
               <asp:Label ID="Label5" runat="server" Text="Telefon"></asp:Label>
               <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <br />
            <div>
               <asp:Label ID="Label6" runat="server" Text="Kısa Not"></asp:Label>
               <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" TextMode="MultiLine" Height="100px"></asp:TextBox>
           </div>
           <br />
            <div>
               <asp:Label ID="Label7" runat="server" Text="Fotoğra"></asp:Label>
               <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           
           <br />
           <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="Button1_Click" />

       </div>
   </form>
</asp:Content>
