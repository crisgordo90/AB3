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
        public string Nombre;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Site.USUARIO.equal("")) 
            //{
 
            //}
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from tabla_libro", con);
            con.Open();

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
            SqlCommand cmd = new SqlCommand("login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            Console.WriteLine("{0}, {1}", dr.GetName(0), dr.GetName(1));

            while (dr.Read())
            {
                Console.WriteLine("{0}, ${1}", dr.GetString(0), dr.GetDecimal(1));
            }

            dr.Close();
            con.Close();
        }

        protected void prueba_Click(object sender, EventArgs e)
        {
            
        }
    }
}
