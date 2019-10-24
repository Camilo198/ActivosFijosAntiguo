using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistrosActasActivos;

namespace RegistrosActas
{
    public partial class actualizadorActivosControlador : Form
    {
        public actualizadorActivosControlador()
        {
            InitializeComponent();
        }

        private void actualizadorActivos_Load(object sender, EventArgs e)
        {

        }

        private void t2idActivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void b1BuscarActivo_Click(object sender, EventArgs e)
        {
            busquedaPlaca bPla = new busquedaPlaca();
            bPla.buscarPLaca(t1refActivo.Text);
            t2Placa.Text = bPla.lecturaSelectPlacas[0].ToString();
            t3nombreActivo.Text = bPla.lecturaSelectNombreActivos[0].ToString();
        }

        private void b3actualizarHirtoricoPlaca_Click(object sender, EventArgs e)
        {
            // crea un objeto nuevo por cada actualizacion
            //Esto garantiza que no se hagan updates con datos reciclados.
            ActualizacionPlaca aPla = new ActualizacionPlaca();
            // ejecutamos el metodo que actualiza
            //y le pasamos el parametro String que se recibe del formulario
            aPla.actualizarPlacaActivo(t5id_Historico.Text,t2Placa.Text);
            t1refActivo.Text = ""; //Limpia el campo para generar una nueva solicitud
            t2Placa.Text = "";
            t3nombreActivo.Text = "";
            t4IdActa.Text = "";
            t5id_Historico.Text = "";
        }

        private void actualizadorActivosControlador_FormClosed(object sender, FormClosedEventArgs e)
        {
            actualizadorActasControlador actc = new actualizadorActasControlador();
            actc.Show();

        }
    }
}
