<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AB3._Default" %>
<asp:Content ID="head2" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="../CSS/style-news.css" />

</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    <form id="Principal" runat="server">
        <div class="inicio" runat="server">
            <nav class="menu" runat="server">
                <ul>
                    <li><a href="Default.aspx">Inicio</a></li>
                    <!--<li><a href="Default.aspx">Perfil</a></li>-->
                    <li><a href="Default.aspx">Buscar</a></li>
                    <li><a href="RegistroEmpresa.aspx">Contactar</a></li>
                    <li><asp:LinkButton runat="server" Text="Acerca" OnClick="prueba_Click" /></li>
                </ul>
            </nav>
            <div id="Login" class="login">
                <asp:TextBox class="txtLogin" ID="txtCorreo" TextMode="SingleLine" Placeholder="Correo" runat="server" Height="15px" />
                <asp:TextBox class="txtLogin" ID="txtContrasena" TextMode="Password" Placeholder="Contraseña" runat="server" Height="15px" />
                <asp:Button class="btn" ID="btnIniciarSesion" Text="Iniciar Sesión" runat="server" OnClick="btnIniciarSesion_Click" />
            </div>
        </div>
        <div class="register">
            <div class="titulo"></div>
            <hr />
            <asp:HyperLink ID="btnRegPersona" runat="server" NavigateUrl="~/Interfaz/RegistroPersona.aspx">
                <asp:Image class="RegistroImagen" ID="imgRegPersona" runat="server" ImageUrl="~/Images/Usuario2.png" />
            </asp:HyperLink>
           <!-- <asp:Button ID="jdo"></asp:Button>
            <br />
            <asp:HyperLink ID="btnRegEmpresa" runat="server" NavigateUrl="~/Interfaz/RegistroEmpresa.aspx">
                <asp:Image class="RegistroImagen" ID="imgRegEmpresa" runat="server" ImageUrl="~/Images/Empresa2.png" />
            </asp:HyperLink>-->
        </div>
    </form>
    <div id="page-wrap">


    </div>
</asp:Content>


