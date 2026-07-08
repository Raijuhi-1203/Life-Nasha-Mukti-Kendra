<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="auth_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>Life Nasha Mukti Kendra</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!-- Font Awesome -->
    <link rel="stylesheet" href="login-assets/plugins/fontawesome-free/css/all.min.css" />

    <!-- icheck bootstrap -->
    <link rel="stylesheet" href="login-assets/plugins/icheck-bootstrap/icheck-bootstrap.min.css" />
    <!-- Theme style -->
    <link rel="stylesheet" href="login-assets/dist/css/adminlte.min.css" />

    <link href="https://fonts.googleapis.com/css?family=Poppins:400,500,500i,600,600i,700&display=swap" rel="stylesheet" />

    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.1/css/all.css" integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous" />

    <link href="login-assets/dist/css/Message.css" rel="stylesheet" />

</head>

<body class="hold-transition login-page" style="background:#007bff">
<%--<body class="hold-transition login-page" style="background-image: url(https://hotel.digitalbull.in/hotel-receptionist1.jpg);">--%>
    <form id="form1" runat="server">
        <div class="login-box">
            <div class="login-logo" style="color:#fff">
                <%--<img src="assets/logo.png" style="width:200px;height:auto;background-color: #ffffff;border-radius: 100px;" />--%>
                Life Nasha Mukti Kendra
            </div>
            <div class="card" style="border-radius: 10px;">
                <div class="card-body login-card-body" style="border-radius: 10px;">
                    <p class="login-box-msg"><b>Admin Panel</b></p>

                    <div class="input-group mb-3">
                        <asp:TextBox ID="txtemail" TextMode="Email" class="form-control" placeholder="Email" runat="server"></asp:TextBox>
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-envelope"></span>
                            </div>
                        </div>
                    </div>

                    <div class="input-group mb-3">
                        <asp:TextBox ID="txtpassword" TextMode="Password" class="form-control" placeholder="Password" runat="server"></asp:TextBox>
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-lock"></span>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-12">
                            <button id="btnlogin" runat="server" type="submit" class="btn btn-primary btn-block btn-flat" onserverclick="btnlogin_ServerClick" style="border-radius: 60px;">Sign In</button>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </form>


    <!-- jQuery -->
    <script src="login-assets/plugins/jquery/jquery.min.js"></script>
    <!-- Bootstrap -->
    <script src="login-assets/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="login-assets/dist/js/Message.js"></script>


</body>
</html>
