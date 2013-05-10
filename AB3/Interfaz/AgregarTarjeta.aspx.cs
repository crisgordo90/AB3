using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AB3.Interfaz
{
    public partial class AgregarTarjeta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

        try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                SqlCommand cmd = new SqlCommand("insertar_Libro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ISBM", SqlDbType.Int).Value = txtISBM.Text;
                cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = txtTitulo.Text;
                cmd.Parameters.Add("@anio_publicacion", SqlDbType.Int).Value = txtAnio.Text;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = txtStock.Text;
                cmd.Parameters.Add("@costo", SqlDbType.Int).Value = txtCosto.Text;
                SqlParameter message = cmd.Parameters.Add("@strMessage", SqlDbType.VarChar, 200);
                message.Direction = ParameterDirection.Output;
                con.Open();
                cmd.ExecuteNonQuery();
                msgError.Text = cmd.Parameters["@strMessage"].Value.ToString();
                con.Close();
                Insertar_AutorLibro();
            }
            catch (Exception ex)
            {
                msgError.Text = ex.Message;
            }

            if (msgError.Text.Equals(""))
            {
                Limpiar();
            }
            else
            {
                imgError.Visible = true;
            }
            Response.Redirect("~/Interfaz/AgregarLibro.aspx");
        }
    }
}