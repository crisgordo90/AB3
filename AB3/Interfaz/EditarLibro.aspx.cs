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
    public partial class EditarLibro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insertar_usuario", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ISBM", SqlDbType.VarChar).Value = txtISBM.Text;
            cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = txtTitulo.Text;
            cmd.Parameters.Add("@autor", SqlDbType.VarChar).Value = txtAutor.Text;
            cmd.Parameters.Add("@anio_publicacion", SqlDbType.VarChar).Value = txtAnio.Text;
            cmd.Parameters.Add("@stock", SqlDbType.VarChar).Value = txtStock.Text;
            cmd.Parameters.Add("@costo", SqlDbType.VarChar).Value = txtCosto.Text;
            cmd.Parameters.Add("@tienda", SqlDbType.VarChar).Value = txtTienda.Text;
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
                Response.Redirect("~/Interfaz/Default.aspx");
                Limpiar();
            }
            else
            {
                imgError.Visible = true;
            }
            con.Close();
        }


        protected void Limpiar()
        {
            imgError.Visible = false;
            txtISBM.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtAnio.Text = "";
            txtStock.Text = "";
            txtCosto.Text = "";
            txtTienda.Text = "";
        }
    }
}