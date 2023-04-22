using System;
using System.Data;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txt_ID_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { 
                cls_ConsultarCandidato objConsultar = new cls_ConsultarCandidato();
                objConsultar.fnt_Consultar(txt_ID.Text);
                txt_Nombres.Text = objConsultar.getPNombre() + " " + objConsultar.getSNombre() + " " + objConsultar.getPApellido() + " " + objConsultar.getSApellido();
                txt_Correo.Text = objConsultar.getCorreo();
                txt_Direccion.Text = objConsultar.getDireccion();
                txt_Contacto.Text = objConsultar.getContacto();
                ptb_Imagen.Image = objConsultar.getBmp();
            }
        }
    }
}
