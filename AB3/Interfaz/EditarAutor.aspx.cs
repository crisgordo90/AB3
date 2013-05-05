﻿using System;
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
    public partial class EditarAutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insertar_usuario", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text;
            cmd.Parameters.Add("@fecha_nac", SqlDbType.VarChar).Value = txtNacimiento.Text;
            cmd.Parameters.Add("@fecha_fallecimiento", SqlDbType.VarChar).Value = txtFallecimiento.Text;
            cmd.Parameters.Add("@edad", SqlDbType.VarChar).Value = txtEdad.Text;
            cmd.Parameters.Add("@pais", SqlDbType.VarChar).Value = txtPais.Text;
            cmd.Parameters.Add("@biografia", SqlDbType.VarChar).Value = txtBiografia.Text;

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

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Interfaz/Default.aspx");
            Limpiar();
        }

        protected void Limpiar()
        {
            imgError.Visible = false;
            txtNombre.Text = "";
            txtNacimiento.Text = "";
            txtFallecimiento.Text = "";
            txtEdad.Text = "";
            txtPais.Text = "";
            txtBiografia.Text = "";
        }

    }
}