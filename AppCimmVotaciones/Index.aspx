<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AppCimmVotaciones.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sistema de Votaciones Cimm</title>

    <!-- <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script> -->

    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.css" integrity="sha384-tViUnnbYAV00FLIhhi3v/dWt3Jxw4gZQcNoSCxCIFNJVCx7/D55/wXsrNIRANwdD" crossorigin="anonymous" />
    <link href="Vista/Bootstrap/css/bootstrap.min.css" rel="stylesheet" />

    <link href="Vista/Assets/css/EstiloLanding.css" rel="stylesheet" />
    <script src="Vista/Bootstrap/js/bootstrap.min.js"></script>


</head>
<body>
    <form id="form1" runat="server">
        <h1>Cambio desde rama dev/gustavo</h1>
        <div class="container mt-5">

            <!-- NAVBAR -->

            <nav class="navbar navbar-expand-lg navbar-light bg-light shadow-sm">
                <div class="container">
                    <a class="navbar-brand fw-bold" href="#">Votaciones Cimm</a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#menu">
                        <span class="navbar-toggler-icon"></span>
                    </button>

                    <div class="collapse navbar-collapse" id="menu">
                        <ul class="navbar-nav ms-auto">

                            <li class="nav-item ">
                                <a class="nav-link active" href="#">Home</a>
                            </li>

                            <li class="nav-item ">
                                <a class="nav-link active" href="#">Candidatos</a>
                            </li>
                            <li class="nav-item ">
                                <a class="nav-link active" href="#">Resultados</a>
                            </li>

                            <li class="nav-item ms-4">
                                <a class="nav-link d-flex align-items-center" href="Vista/Auth/Login.aspx"><i class="bi bi-person-circle me-2"></i>Login</a>
                            </li>

                        </ul>
                    </div>
                </div>
            </nav>


        </div>

        <section class="hero m mt-3">
            <div class="hero-overlay">
                <div class="container">
                    <h1>Jornadas de Votación Aprendices SENA 2026</h1>
                    <p class="mt-3">
                        Participa en la elección de representantes estudiantiles de tu centro de formación.
            
                    </p>

                    <asp:Button ID="btnVotar" runat="server" class="btn btn-success btn-custom" Text="Votar Ahora" />
                    <asp:Button ID="btnVer" runat="server" class="btn btn-outline-light btn-custom" Text="Ver Candidatos" />


                </div>
            </div>
        </section>


    </form>
</body>
</html>
