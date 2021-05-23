<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CvType2.Login" %>

<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

<!DOCTYPE html>
<html>
<head>
    <title>Login Page</title>
    <!--Made with love by Mutiullah Samim -->

    <!--Bootsrap 4 CDN-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

    <!--Fontawesome CDN-->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">

    <!--Custom styles-->
    <link href="GirişCss.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <div class="d-flex justify-content-center h-100">
            <div class="card">
                <div class="card-header">
                    <h3>Giriş Yap</h3>
                </div>
                <div class="card-body">
                    <form runat="server">
                        <div class="input-group form-group">
                            <div class="input-group-prepend">
                                <span class="input-group-text"><i class="fas fa-user"></i></span>
                            </div>
                            <%--<input type="text" class="form-control" placeholder="Kullanıcı Adı...">--%>
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" PlaceHolder="Mail" ></asp:TextBox>

                        </div>
                        <div class="input-group form-group">
                            <div class="input-group-prepend">
                                <span class="input-group-text"><i class="fas fa-key"></i></span>
                            </div>
                            <%--   <input type="password" class="form-control" placeholder="Şifre...">--%>
                            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" PlaceHolder="Şifre" TextMode="Password"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <%--<input type="submit" value="Giriş" class="btn float-right login_btn">--%>
                            <asp:Button ID="Button1" runat="server" Text="Giriş" CssClass="btn float-right login_btn" OnClick="Button1_Click" />
                        </div>
                    </form>
                </div>

            </div>
        </div>
    </div>
</body>
</html>
