<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AB3._Default" %>
<asp:Content ID="head2" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    <form id="Principal" runat="server">
        <div class="inicio" runat="server">
            <nav class="menu" runat="server">
                <ul>
                    <li><a href="Default.aspx">Inicio</a></li>
                    <li><a href="Buscar.aspx">Buscar</a></li>
                    <li><a href="Comprar.aspx">Comprar</a></li>
                </ul>
            </nav>
            <div id="Login" class="login">
                <asp:TextBox class="txtLogin" ID="txtCorreo" TextMode="SingleLine" Placeholder="Correo" runat="server" Height="15px" />
                <asp:TextBox class="txtLogin" ID="txtContrasena" TextMode="Password" Placeholder="Contraseña" runat="server" Height="15px" />
                <asp:Button class="btn" ID="btnIniciarSesion" Text="Iniciar Sesión" runat="server" OnClick="btnIniciarSesion_Click" />
                <asp:Label class="" ID="LblLogin" Text="" runat="server" Visible="false"></asp:Label>
                 <br />
                <asp:Image ID="imgError" Visible="false" class="imgError" runat="server" ImageUrl="/Images/error1.png" />
                    &nbsp;<asp:Label ID="msgError" class="error" runat="server" Text="" /></td>
               
            </div>
        </div>
        <div class="register">
            <div class="titulo"></div>
            <hr />
            <asp:HyperLink ID="btnRegPersona" runat="server" NavigateUrl="~/Interfaz/AgregarPersona.aspx">
                <asp:Image class="RegistroImagen" ID="imgRegPersona" runat="server" ImageUrl="~/Images/Usuario2.png" />
            </asp:HyperLink>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Interfaz/AgregarLibro.aspx" Visible="false">
                <asp:Image class="RegistroImagen" ID="Image1" runat="server" ImageUrl="~/Images/Usuario2.png" />
            </asp:HyperLink>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Interfaz/AgregarLibro.aspx" Visible="false">
                <asp:Image class="RegistroImagen" ID="Image2" runat="server" ImageUrl="~/Images/Usuario2.png" />
            </asp:HyperLink>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Interfaz/AgregarLibro.aspx" Visible="false">
                <asp:Image class="RegistroImagen" ID="Image3" runat="server" ImageUrl="~/Images/Usuario2.png" />
            </asp:HyperLink>
        </div>
        <div class="registrar">
    <div class="titulo">Libros</div>
             <br />
                <asp:Image ID="imgError2" Visible="false" class="imgError" runat="server" ImageUrl="/Images/error1.png" />
                    &nbsp;<asp:Label ID="msgError2" class="error" runat="server" Text="" /></td>  
        <br/>
            <asp:GridView ID="gvLibros" runat="server">
            </asp:GridView>

        </div>
    </form>
</asp:Content>


