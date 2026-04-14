<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppCimmVotaciones.Vista.Auth.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../Bootstrap/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">


        <div class="container vh-100 d-flex justify-content-center align-items-center">


            <div class="col-12 col-md-6 col-lg-4">


                <div class="card shadow-lg rounded-4 p-4">

                    <h3 class="text-center mb-4">Login</h3>

                    <div class="mb-3">
                        <label for="txtEmail" class="form-label">Email:</label>
                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="Enter email" TextMode="Email"></asp:TextBox>

                    </div>

                    <div class="mb-3">
                        <label for="txtPassword" class="form-label">Password:</label>
                        <asp:TextBox ID="txtPassword" runat="server" class="form-control" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
                    </div>

                    <div class="form-check mb-3">
                        <asp:CheckBox ID="chkTipo" runat="server" Checked="true" OnCheckedChanged="chkTipo_CheckedChanged" AutoPostBack="True" Text="Funcionario" />
                        
                    </div>
                    <div class="form-label mb-3">
                               <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>             
                    </div>

                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" class="btn btn-primary w-100" OnClick="btnIngresar_Click" />


                </div>

            </div>

        </div>

    </form>

</body>
</html>
