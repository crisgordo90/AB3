using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Web.DynamicData;
using AB3.Clases;
using System.Data.SqlClient;

namespace AB3
{
    
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from tabla_libro", con);
            
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

             SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
             DataTable dt = new DataTable();
             dt.Load(dr);
             gvLibros.DataSource = dt;
             gvLibros.DataBind();
            con.Close();
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            SqlCommand cmd = new SqlCommand("loginCheck2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = txtCorreo.Text;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtContrasena.Text;
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            Console.WriteLine("{0}, {1}", dr.GetName(0), dr.GetName(1));

            while (dr.Read())
            {
                Console.WriteLine("{0}, ${1}", dr.GetString(0), dr.GetDecimal(1));
            }

            btnIniciarSesion.Visible = false;
            txtContrasena.Visible = false;
            txtCorreo.Visible = false;
            LblLogin.Text = txtCorreo.Text;
            dr.Close();
            con.Close();
        }

        protected void prueba_Click(object sender, EventArgs e)
        {
            
        }

         protected void Limpiar()
        {
            imgError.Visible = false;
            txtContrasena.Text = "";
            txtCorreo.Text = "";
            msgError.Text = "";
        }
    }
}
