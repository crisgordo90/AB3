using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AB3.Clases
{
    public class cEmpleosDatos
    {
        Service1 webService = new Service1();

        /**
         * inserta puestos
         */
        public string insertar(string p_IdCatEmpleo, string p_Descripcion)
        {
            if (p_Descripcion != "" && p_IdCatEmpleo != "")
            {
                if (Numero(p_IdCatEmpleo))
                {
                    int _iId_CatEmpleo = Convert.ToInt32(p_IdCatEmpleo);
                    try
                    {
                        webService.Insert_Puesto(p_Descripcion, _iId_CatEmpleo);
                        return "Puesto Insertado con Exito";
                    }
                    catch (Exception e) {
                        return e.Message;
                    }
                }
            }else {
                return "Campos Incompletos";
            }
            return "";
        }

        /**
         * Modificar Puesto
         */
        public void modificar(string p_IdPuesto,string p_Descripcion,string p_IdCatEmpleo) {
            if (p_IdPuesto != "" && p_Descripcion != "" && p_IdCatEmpleo != "")
            {
                if (Numero(p_IdPuesto) && Numero(p_IdCatEmpleo)) {
                    int _iIdPuesto = Convert.ToInt32(p_IdPuesto);
                    int _iIdCatEmpleo = Convert.ToInt32(p_IdCatEmpleo);
                    try
                    {
                        webService.Update_Puesto(_iIdPuesto, p_Descripcion, _iIdCatEmpleo);
                    }
                    catch (Exception e){ }
                }
            }
        }

        /**
         * eliminar puesto
         */
        public void eliminar(string p_IdPuesto) { 
            if (Numero(p_IdPuesto)) {
                int _iIdPuesto = Convert.ToInt32(p_IdPuesto);
                try {
                    webService.Delete_Puesto(_iIdPuesto);
                }
                catch(Exception e){}
            }
        }

        /**
         * valida si el parametro es un numero
         */
        protected Boolean Numero(String p_numero)
        {
            int _iNumero = 0;
            return (int.TryParse(p_numero, out _iNumero));
        }
    }
}