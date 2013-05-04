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
    public partial class BajaPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from tabla_usuario", con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(dr);
            gvBuscar.DataSource = dt;
            gvBuscar.DataBind();
            txtNombre.DataSource = dt;
            txtNombre.DataTextField = "Titulo";
            //txtNombre.DataValueField = "";
            txtNombre.DataBind();
            con.Close();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}