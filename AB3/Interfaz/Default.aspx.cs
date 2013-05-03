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

namespace AB3
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Site.USUARIO.equal("")) 
            //{
 
            //}
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
          /* String usuario = persona.IniciarSesion(txtCorreo.Text, txtContrasena.Text);
            if (usuario.Equals(""))
            {

            }
            else 
            {
                ClientScript.RegisterStartupScript(GetType(), "UsuarioActual", "Sesion('"+ usuario +"')", true);
            }
            */

            //cCorreoComunicacion ins = new cCorreoComunicacion();
            //txtCorreo.Text = ins.SendMail("jeragones@hotmail.com", "jeragones@gmail.com", "Hola", "Si funciona !!!");
        }

        protected void prueba_Click(object sender, EventArgs e)
        {
            
        }

    }
}
