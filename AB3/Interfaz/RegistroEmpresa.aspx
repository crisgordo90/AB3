<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="RegistroEmpresa.aspx.cs" Inherits="AB3.RegistroEmpresa" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1
        {
            width: 150px;
        }
    </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="Body" runat="server">
    <form runat="server">
        <div runat="server">
            <div class="inicio" runat="server">
                <nav class="menu" runat="server">
                    <ul>
                        <li><a href="Default.aspx">Inicio</a></li>
                        <!--<li><a href="Default.aspx">Perfil</a></li>-->
                        <li><a href="Default.aspx">Buscar</a></li>
                        <li><a href="Default.aspx">Contactar</a></li>
                        <li><a href="Default.aspx">Acerca</a></li>
                    </ul>
                </nav>
            </div>
        </div>
        <div class="registrar" runat="server">
        <div class="titulo">Registrar Empresa</div>
        <br/>
        <table>
            <tr>
                <td><asp:Label ID="Label1" class="lblRegistrar" runat="server" Text="Nombre de empresa:" /></td>
                <td><asp:TextBox class="txt" runat="server" ID="txtNombre" Height="20px" Width="200px" /></td>
                <td><div class="asterisco"> *</div></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" class="lblRegistrar" runat="server" Text="Cédula Jurídica:" /></td>
                <td><asp:TextBox class="txt" runat="server" placeholder="0" ID="txtCedula1" MaxLength="1" Height="20px" Width="15px" />
                    <asp:TextBox class="txt" runat="server" placeholder="000" ID="txtCedula2" MaxLength="3" Height="20px" Width="55px" />
                    <asp:TextBox class="txt" runat="server" placeholder="000000" ID="txtCedula3" MaxLength="6" Height="20px" Width="110px" /></td>
                <td><div class="asterisco"> *</div></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" class="lblRegistrar" runat="server" Text="Correo electrónico:" /></td>
                <td><asp:TextBox class="txt" runat="server" placeholder="example@mail.com" ID="txtCorreo" Height="20px" Width="200px" /></td>
                <td><div class="asterisco"> *</div></td>
            </tr>
            <!--<tr>
                <td><asp:Label class="lblRegistrar" runat="server" Text="Teléfono:" /></td>
                <td><asp:TextBox class="txt" runat="server" placeholder="8888-8888" ID="txtTelefono" /></td>
            </tr>-->
            <tr>
                <td><asp:Label ID="Label4" class="lblRegistrar" runat="server" Text="Sitio Web:" /></td>
                <td><asp:TextBox class="txt" runat="server" placeholder="example.com" ID="txtWeb" Height="20px" Width="200px" /></td>
            </tr>
            <!--<tr>
                <td><asp:Label class="lblRegistrar" runat="server" Text="Contraseña:" /></td>
                <td><asp:TextBox class="txt" runat="server" ID="txtContrasena" /></td>
            </tr>
            <tr>
                <td><asp:Label class="lblRegistrar" runat="server" Text="Descripción:" /></td>
                <td><asp:TextBox class="txta" runat="server" TextMode="MultiLine" ID="txtDescripcion" /></td>
            </tr>
            <tr>
                <td><asp:Label class="lblRegistrar" runat="server" Text="Dirección:" /></td>
                <td><asp:TextBox class="txta" runat="server" TextMode="MultiLine" ID="txtDireccion" /></td>
            </tr>-->
            <tr>
                <td></td>
                <td><asp:Image ID="imgError" Visible="false" class="imgError" runat="server" ImageUrl="/Images/error1.png" />
                        &nbsp;<asp:Label ID="msgError" class="error" runat="server" Text="" /></td>
            </tr>
            <tr>
                <td><br /><asp:Button class="btn" runat="server" Text="Registrarse" ID="btnRegistrar" OnClick="btnRegistrar_Click" /></td>
                <td><br /><asp:Button class="btn" runat="server" Text="Cancelar" ID="btnCancelar" OnClick="btnCancelar_Click" NavigateUrl="~/Default.aspx" /></td>
            </tr>
        </table>
    </div>
    </form>

    
</asp:Content>