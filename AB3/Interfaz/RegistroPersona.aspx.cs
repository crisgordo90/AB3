using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace AB3
{
    public partial class RegistroPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            //SqlCommand cmd = new SqlCommand("INSERT INTO tabla_usuario (nombre,	direccion, ciudad, estado, codigo_postal, telefono, email, activo) VALUES (@nombre,	@direccion, @ciudad, @estado, @codigo_postal, @telefono, @email, @activo)", conn);
            SqlCommand cmd = new SqlCommand("inserta_usuario", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtDireccion.Text;
            cmd.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = txtCiudad.Text;
            cmd.Parameters.Add("@codigo_postal", SqlDbType.VarChar).Value = txtCodigoPostal.Text;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = txtTelefono.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtCorreo.Text;
            cmd.Parameters.Add("@activo", SqlDbType.Char).Value = '1';
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                msgError.Text = ex.Message;
            }

            if (msgError.Text.Equals(""))
            {
                //persona.EnviarCorreo();
                Response.Redirect("~/Interfaz/Default.aspx");
                Limpiar();
            }
            else
            {
                imgError.Visible = true;
            }
            con.Close();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Interfaz/Default.aspx");
            Limpiar();
        }

        protected void Limpiar()
        {
            imgError.Visible = false;
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            msgError.Text = "";
        }
    }
}