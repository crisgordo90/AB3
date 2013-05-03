using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AB3.Interfaz
{
    public partial class ModificarPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void hplCedula_Click(object sender, EventArgs e)
        { }

        protected void hplNombre_Click(object sender, EventArgs e)
        {
            lblNombre.Visible = false;
            txtNombre.Visible = true;
            txtNombre.Text = lblNombre.Text;
            hplNombre.Visible = false;
            DesactivarTelefono();
            DesactivarIdioma();
            DesactivarCondicion();
            DesactivarContrasena();
            DesactivarDireccion();
        }

        protected void hplTelefono_Click(object sender, EventArgs e)
        {
            lblTelefono.Visible = false;
            txtTelefono.Visible = true;
            txtTelefono.Text = lblTelefono.Text;
            hplTelefono.Visible = false;
            DesactivarNombre();
            DesactivarIdioma();
            DesactivarCondicion();
            DesactivarContrasena();
            DesactivarDireccion();
        }

        protected void hplIdioma_Click(object sender, EventArgs e)
        {
            lblIdioma.Visible = false;
            btnIdioma.Visible = true;
            cmbIdioma.Visible = true;
            cmbIdioma.Text = lblIdioma.Text;
            hplIdioma.Visible = false;
            DesactivarNombre();
            DesactivarTelefono();
            DesactivarCondicion();
            DesactivarContrasena();
            DesactivarDireccion();
        }

        protected void hplCondicion_Click(object sender, EventArgs e)
        {
            lblCondicion.Visible = false;
            cmbCondicion.Visible = true;
            cmbCondicion.Text = lblCondicion.Text;
            hplCondicion.Visible = false;
            DesactivarNombre();
            DesactivarTelefono();
            DesactivarIdioma();
            DesactivarContrasena();
            DesactivarDireccion();
        }

        protected void hplContrasena_Click(object sender, EventArgs e)
        {
            lblContrasena1.Text = "Contraseña actual:";
            lblContrasena.Visible = false;
            txtContrasena1.Visible = true;
            lblContrasena2.Visible = true;
            txtContrasena2.Visible = true;
            lblContrasena3.Visible = true;
            txtContrasena3.Visible = true;
            hplContrasena.Visible = false;
            DesactivarNombre();
            DesactivarTelefono();
            DesactivarIdioma();
            DesactivarCondicion();
            DesactivarDireccion();
        }

        protected void hplDireccion_Click(object sender, EventArgs e)
        {
            lblDireccion.Visible = false;
            txtDireccion.Visible = true;
            txtDireccion.Text = lblDireccion.Text;
            hplDireccion.Visible = false;
            DesactivarNombre();
            DesactivarTelefono();
            DesactivarIdioma();
            DesactivarCondicion();
            DesactivarContrasena();
        }

        protected void DesactivarNombre()
        {
            lblNombre.Visible = true;
            txtNombre.Visible = false;
            lblNombre.Text = txtNombre.Text;
            hplNombre.Visible = true;
        }

        protected void DesactivarTelefono()
        {
            lblTelefono.Visible = true;
            txtTelefono.Visible = false;
            lblTelefono.Text = txtTelefono.Text;
            hplTelefono.Visible = true;
        }

        protected void DesactivarIdioma()
        {
            lblIdioma.Visible = true;
            cmbIdioma.Visible = false;
            lblIdioma.Text = cmbIdioma.Text;
            hplIdioma.Visible = true;
        }

        protected void DesactivarCondicion()
        {
            lblCondicion.Visible = true;
            cmbCondicion.Visible = false;
            lblCondicion.Text = cmbCondicion.Text;
            hplCondicion.Visible = true;
        }

        protected void DesactivarContrasena()
        {
            lblContrasena1.Text = "Contraseña:";
            lblContrasena.Visible = true;
            txtContrasena1.Visible = false;
            lblContrasena2.Visible = false;
            txtContrasena2.Visible = false;
            lblContrasena3.Visible = false;
            txtContrasena3.Visible = false;
            hplContrasena.Visible = true;
        }

        protected void DesactivarDireccion()
        {
            lblDireccion.Visible = true;
            txtDireccion.Visible = false;
            lblDireccion.Text = txtDireccion.Text;
            hplDireccion.Visible = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            DesactivarNombre();
            DesactivarTelefono();
            DesactivarIdioma();
            DesactivarCondicion();
            DesactivarContrasena();
            DesactivarDireccion();
            Response.Redirect("~/Interfaz/Default.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            DesactivarNombre();
            DesactivarTelefono();
            DesactivarIdioma();
            DesactivarCondicion();
            DesactivarContrasena();
            DesactivarDireccion();
            cPersonaDatos ins = new cPersonaDatos();
            //ins.modificar();
            Response.Redirect("~/Interfaz/Default.aspx");
        }
    }
}