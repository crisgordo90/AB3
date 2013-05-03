<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ModificarPersona.aspx.cs" Inherits="AB3.Interfaz.ModificarPersona" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ContentPlaceHolderID="Body" runat="server">
    <form id="Form1" runat="server">
        <div id="4" class="borderPerfilEmpresaPersona" >
        <div class="titulo">Candidato</div>
        <br/>
        <div><asp:Label ID="Label2" class="lblRegistrar" runat="server" Text="Nombre Completo:" /></div>
         <div><asp:TextBox ID="txtNombre" class="txt" runat="server"  Visible="False" Height="20px" Width="160px" />
                        <asp:Label ID="lblNombre" class="lblRegistrar" runat="server" Text="Nombre del Candidato" />
                    <asp:LinkButton class="Link" runat="server" ID="hplNombre" text="Editar" OnClick="hplNombre_Click" />
                 </div>  
        <br/><br/>

        <div id="Div1" runat="server">
       
               
       <table class="datosBasicosPersona">
            <tr>
                <th class="tdborderbot"colspan="3">
                    Datos Básicos
                </th>
            </tr>
            <tr>   
                <td class="tdleft"><asp:Label ID="Label1" class="lblRegistrar" runat="server" Text="Cédula:" /></td>
                    <td class="tdleft"><asp:TextBox class="txt" runat="server" placeholder="0-0000-0000" ID="txtCedula"  Visible="False" Height="20px" />
                        <asp:Label ID="lblCedula" class="lblRegistrar" runat="server" Text="Cedúla Persona" /></td>
                    <td class="tdleft"><asp:LinkButton runat="server" ID="hplCedula" text="Editar" OnClick="hplCedula_Click" /></td>
            </tr>
            <tr>
                <td class="tdleft"><asp:Label ID="Label3" class="lblRegistrar" runat="server" Text="Teléfono:" /></td>
                    <td class="tdleft"><asp:TextBox ID="txtTelefono" class="txt" runat="server" placeholder="0000-0000"  Visible="False" Height="20px" Width="160px" />
                        <asp:Label ID="lblTelefono" class="lblRegistrar" runat="server" Text="telefonos de contacto" /></td>
                    <td class="tdleft"><asp:LinkButton class="Link" runat="server" ID="hplTelefono" text="Editar" OnClick="hplTelefono_Click" /></td>
            </tr>
            <tr>
                    <td class="tdleft"><asp:Label ID="Label4" class="lblRegistrar" runat="server" Text="Idioma(s):" /></td>
                    <td class="tdleft"><asp:DropDownList ID="cmbIdioma" class="txt" runat="server"  Visible="False" Height="20px" Width="166px"/>
                        <asp:Button ID="btnIdioma" runat="server" Text="+" Visible="False"/>
                        <asp:Label ID="lblIdioma" class="lblRegistrar" runat="server" Text="Español-Ingles-Frances" /></td>
                    <td class="tdleft"><asp:LinkButton class="Link" runat="server" ID="hplIdioma" text="Editar" OnClick="hplIdioma_Click" /></td>
            </tr>
            <tr>
                    <td class="tdleft"><asp:Label ID="Label7" class="lblRegistrar" runat="server" Text="Dirección:" /></td>
                    <td class="tdleft"><asp:TextBox class="txta" runat="server" TextMode="MultiLine" ID="txtDireccion" Visible="False" Width="160px" />
                        <asp:Label ID="lblDireccion" class="lblRegistrar" runat="server" Text="Nombre" /></td>
                    <td class="tdleft"><asp:LinkButton class="Link" runat="server" ID="hplDireccion" text="Editar" OnClick="hplDireccion_Click" /></td>
           </tr>
            <tr><td></td><td></td></tr>
           <tr>
                <th class="tdborderbot"colspan="3">
               Información Laboral
                </th> 
            </tr>
            <tr>
                    <td class="tdleft"><asp:Label ID="Label5" class="lblRegistrar" runat="server" Text="Condicion Laboral:" /></td>
                    <td class="tdleft"><asp:DropDownList ID="cmbCondicion" class="txt" runat="server" Visible="False" Height="20px" Width="166px">
                            <asp:ListItem Selected="True" Text="Desempleado" />
                            <asp:ListItem Text="Empleado" />
                        </asp:DropDownList> 
                        <asp:Label ID="lblCondicion" class="lblRegistrar" runat="server" Text="Empleado-Desempleado" /></td>
                    <td class="tdleft"><asp:LinkButton class="Link" runat="server" ID="hplCondicion" text="Editar" OnClick="hplCondicion_Click" /></td>
            </tr>
            <tr>
                    <td class="tdleft"><asp:Label ID="Label6" class="lblRegistrar" runat="server" Text="Experiencia Laboral:" /></td>
                    <td class="tdleft"><asp:TextBox Class="txta" runat="server" TextMode="MultiLine" ID="txtExperiencia"  Visible="False" />
                        <asp:Label ID="Label8" class="lblRegistrar" runat="server" Text="Nombre" /></td>
                    <td class="tdleft"><asp:LinkButton runat="server" ID="hplExperiencia" text="Editar" /></td>
            </tr>
           <tr><td></td><td></td></tr>
            <tr> 
                <th class="tdborderbot"colspan="3">Configuracion</th>
            </tr>
            <tr>
                    <td class="tdleft"><asp:Label ID="lblContrasena1" class="lblRegistrar" runat="server" Text="Contraseña:" /></td>
                    <td class="tdleft"><asp:TextBox ID="txtContrasena1" class="txt" runat="server"  TextMode="Password" Visible="False" Height="20px" Width="144px" />
                        <asp:Label ID="lblContrasena" class="lblRegistrar" runat="server" Text="&#8226;&#8226;&#8226;&#8226;&#8226;&#8226;&#8226;&#8226;&#8226;" /></td>
                    <td class="tdleft"><asp:LinkButton ID="hplContrasena" class="Link" runat="server"  text="Editar" OnClick="hplContrasena_Click" /></td>
                </tr>
                <tr>
                    <td class="tdleft"><asp:Label ID="lblContrasena2" class="lblRegistrar" runat="server" Text="Nueva contraseña:" visible="false" /></td>
                     <td class="tdleft"><asp:TextBox ID="txtContrasena2" class="txt" runat="server"  TextMode="Password" Visible="False" Height="20px" Width="144px" /></td>
                </tr>
                <tr>
                    <td class="tdleft"><asp:Label ID="lblContrasena3" class="lblRegistrar" runat="server" Text="Confirmar contraseña:" visible="false" /></td>
                    <td class="tdleft"><asp:TextBox ID="txtContrasena3" class="txt" runat="server"  TextMode="Password" Visible="False" Height="20px" Width="144px" /></td>
                </tr>
        </table>
        </div>
    </div>
    </form>
</asp:Content>