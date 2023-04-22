using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_Actualizar_Candidato
    {
        private string str_pnombre;
        private string str_snombre;
        private string str_papellido;
        private string str_sapellido;
        private string str_contacto;
        private string str_direccion;
        private string str_correo;
        private string str_edad;
        private int int_estudio;
        private string str_id;
        private string acudientes;
        private string str_msn;
        public cls_Actualizar_Candidato(string str_id, string str_pnombre, string str_snombre, string str_papellido, string str_sapellido, string str_contacto, string str_direccion, string str_correo, string str_edad, int int_estudio, string str_acudientes)
        {
            this.str_id = str_id;
            this.str_pnombre = str_pnombre;
            this.str_snombre = str_snombre;
            this.str_papellido = str_papellido;
            this.str_sapellido = str_sapellido;
            this.str_contacto = str_contacto;
            this.str_direccion = str_direccion;
            this.str_correo = str_correo;
            this.str_edad = str_edad;
            this.int_estudio = int_estudio;
            this.acudientes = str_acudientes;
            if (str_id == "" || str_pnombre == "" || str_snombre == "" || str_papellido == "" ||
                str_sapellido == "" || str_contacto == "" || str_direccion == "" ||
                str_correo == "" || str_edad == "" || str_acudientes == "")
            {
                str_msn = "Debe ingresar toda la información requerida";
            }
            else
            {
                cls_Funciones_Candidatos objActualizar = new cls_Funciones_Candidatos();
                objActualizar.fnt_Actualizar
                    (str_id, str_pnombre, str_snombre, str_papellido, str_sapellido,
                    str_contacto, str_direccion, str_correo, str_edad, int_estudio,
                    str_acudientes);
                str_msn = "El candadidato " + str_pnombre + str_snombre + str_papellido + str_sapellido + " ha sido actualizado";
            }
        }
        public string getMsn() { return  str_msn; }
    }
}