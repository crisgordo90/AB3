﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AB3.Clases;

namespace AB3.Interfaz
{
    public partial class EditarAutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                query name = new query();
                if (!IsPostBack)
                {
                    ddlNombre.DataSource = name.querydt("select * from tabla_Autor");
                    ddlNombre.DataTextField = "Nombre";
                    ddlNombre.DataValueField = "id_Autor";
                    ddlNombre.DataBind();
                }
            }
            catch (Exception ex)
            {
                msgError.Text = ex.Message;
                imgError.Visible = true;
            }
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            SqlCommand cmd = new SqlCommand("modificar_autor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text;
            cmd.Parameters.Add("@fecha_nac", SqlDbType.VarChar).Value = txtNacimiento.Text;
            cmd.Parameters.Add("@fecha_fallecimiento", SqlDbType.VarChar).Value = txtFallecimiento.Text;
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
                msgError.Text = "Se ha actualizado con exito";
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
            txtPais.Text = "";
            txtBiografia.Text = "";
        }
        protected void btnCargar_Click(object sender, EventArgs e)
        {
            query name = new query();
            DataTable table = name.querydt("select nombre, fecha_nac,	pais, fecha_fallecimiento, biografia from tabla_Autor where id_Autor='" + ddlNombre.SelectedValue + "'");
            if (table != null)
            {
                txtNombre.Text = table.Rows[0].ItemArray[0].ToString();
                txtNacimiento.Text = table.Rows[0].ItemArray[1].ToString();
                txtFallecimiento.Text = table.Rows[0].ItemArray[2].ToString();
                txtPais.Text = table.Rows[0].ItemArray[3].ToString();
                txtBiografia.Text = table.Rows[0].ItemArray[4].ToString();
            }
        }

    }
}