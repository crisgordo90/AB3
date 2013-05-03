/////////////////////////////////////////////////////////////////////////////
// Instituto Tecnológico de Costa Rica
// Proyecto: Framework Bolsa de empleo de la carrera de turismo
// Descripción: Clase de acceso a datos para tabla 'CEEMPRESAS'
// Generado por ITCR Gen v1.0.0.0 
// Fecha: Miercoles, 20 de Marzo de 2013, 3:30:00 p.m.
////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AB3.Clases;

namespace AB3
{
    public class cEmpresaDatos
    {
        Service1 webservice = new Service1();
        cGeneralMetodos Metodos = new cGeneralMetodos();
        // telefono
        public String insertar(String p_nombre, String p_cedula, String p_correo, 
                               String p_sitio)
        {
            String[] _sFracmentar;
            char[] _cSeparadorCedula = { '-' };
            _sFracmentar = Metodos.Fragmentar(p_cedula, _cSeparadorCedula);
            if (p_nombre.Equals("") | p_correo.Equals("") | _sFracmentar[0].Equals("") | 
                _sFracmentar[1].Equals("") | _sFracmentar[2].Equals(""))
            {
                return ("Existen campos vacíos que son requeridos.");
            }

            if (_sFracmentar.Length != 3 | !Metodos.Numero(_sFracmentar[0]) | !Metodos.Numero(_sFracmentar[1]) |
               !Metodos.Numero(_sFracmentar[2]) | p_cedula.Length != 12) 
            {
                return ("Cedula jurídica inválida.");
            }
            char[] _cSeparadorCorreo1 = { ' ', ',', '!', '#', '$', '%', '^', '&', '*', 
                                          '(', ')', '+', '/', ';', ':', '"', '/' };
            char[] _cSeparadorCorreo2 = { '@', '.' };
            _sFracmentar = Metodos.Fragmentar(p_correo, _cSeparadorCorreo1);
            if (_sFracmentar.Length != 1)
            {
                return ("Correo inválido.");
            }
            _sFracmentar = Metodos.Fragmentar(p_correo, _cSeparadorCorreo2);
            if (_sFracmentar.Length != 3)
            {
                return ("Correo inválido.");
            }
            if (_sFracmentar[0].Equals("") | _sFracmentar[1].Equals("") | _sFracmentar[2].Equals(""))
            {
                return ("Correo inválido.");
            }
            try
            {
                webservice.Insert_Empresa(p_correo, "", "", "", p_nombre, p_cedula, p_sitio);
            }
            catch (Exception e) { }
            return ("");
        }

        public void modificar(String p_nombre, String p_cedula, String p_correo, String p_sitio, 
                             String p_contrasena, String p_descripcion, String p_direccion)
        {
            try
            {
                webservice.Update_Empresa(p_correo, p_contrasena, p_descripcion, p_direccion, 
                                          p_nombre, p_cedula, p_sitio);
            } 
            catch(Exception e) {}
        }

        public void eliminar()
        {
        }
    }
}