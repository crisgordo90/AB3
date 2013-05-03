<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="PerfilEmpresa.aspx.cs" Inherits="AB3.Interfaz.PerfilEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
 <form id="Form1" runat="server">
        <div id="3" class="borderPerfilEmpresaPersona" >
        <div class="titulo">Perfil Empresa</div>
        <asp:Button ID="Button1" runat="server" CssClass="btmodificarEmprPers" Text="Enviar Correo" />
        <br/>
        <div class="titulosDatosBasicos">Nombre:</div>
        <asp:Label runat="server" ID="lbl_NombreEmpresa" Text="Nombre de la empresa"/>
        <br/>
        <br/>
               
       <table class="datosBasicosPersona">
            <tr>
                <th class="tdborderbot"colspan="2">Datos Básicos</th>
            </tr>
            <tr>
                <td class="tdleft"><asp:Label ID="Label4" runat="server" Text="Cedúla Jurídica:"/></td>
                <td class="tdleft"><asp:Label ID="Label1" runat="server" Text="Cedúla Jurídica"/></td>
            </tr>
            <tr>
                <td class="tdleft"><asp:Label ID="Label5" runat="server" Text="Correo Electronico"/></td>
                <td class="tdleft"><asp:Label ID="Label6" runat="server" Text="ContactoEmpresa@mail.com"/></td>
            </tr>
            <tr>
                <td class="tdleft"><asp:Label ID="Label2" runat="server" Text="Teléfonos:"/></td>
                <td class="tdleft"><div class="titulosDatosBasicos"><asp:Label  ID="Label3" runat="server" Text="telefonos de contacto" /></div></td>
            </tr>
            <tr>
                <td class="tdleft"><asp:Label ID="Label7" runat="server" Text="Fax:"/></td>
                <td class="tdleft"><div class="titulosDatosBasicos"><asp:Label  ID="Label8" runat="server" Text="faxes de contacto" /></div></td>
            </tr>
            <tr>
                <td class="tdleft"><asp:Label ID="Label13" runat="server" Text="Dirección:"/></td>
                <td class="tdleft"><asp:Label ID="Label14" runat="server" Text="Dirección de la empresa"/></td>
            </tr>
           <tr>
                <td class="tdleft"><asp:Label ID="Label9" runat="server" Text="Pagina Web"/></td>
                <td class="tdleft"><asp:Label ID="Label10" runat="server" Text="Empresa.com"/></td>
            </tr>
           <tr>
                <td class="tdleft"><asp:Label ID="Label17" runat="server" Text="Descripción:"/></td>
                <td class="tdleft"><asp:Label ID="Label18" runat="server" Text="Descripción de la empresa"/></td>
            </tr>
           <tr><td></td><td></td></tr>
        </table>
             <table class="datosBasicosPersona">
		        <tr>
                    <th class="tdborderbot"colspan="2">Puestos Laborales en Oferta</th>
		        </tr>
                <tr>
                    <td class="tdleft">
                        <asp:GridView ID="GridView1" runat="server" EnableModelValidation="True" >
                            <Columns>
                                <asp:CommandField ShowEditButton="True" />
                                <asp:CommandField ShowDeleteButton="True" />
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td>
                        <asp:Button ID="btEliminarOfertasEmpleo" runat="server" CssClass="btmodificarEmprPers" Text="Eliminar" />
                    </td>
                </tr>
            </table>
    </div>
    </form>
         
</asp:Content>
