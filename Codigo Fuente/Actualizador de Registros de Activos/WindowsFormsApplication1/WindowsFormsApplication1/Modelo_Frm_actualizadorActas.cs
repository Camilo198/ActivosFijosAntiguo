using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrosActas
{
    class Modelo_Frm_actualizadorActas
    {
        BusquedaPlacasActas bpa;
        ActualizacionIdActivoActa actIa;
        ProcesamientoDePlaca_IdActivo pro;

        public void ActualizarRegistrosHistoricos(int frmNumActa) {
            bpa = new BusquedaPlacasActas();
            actIa = new ActualizacionIdActivoActa();
            pro = new ProcesamientoDePlaca_IdActivo();
            
            bpa.buscarPLaca(frmNumActa);
            
            if (bpa.lecturaSelectIdHistorico.Count > 0)
            {
                for (int i = 0; i < bpa.lecturaSelectIdHistorico.Count;i++ ) {
                    
                    actIa.actualizarActa(bpa.lecturaSelectIdHistorico[i].ToString(), pro.procesarPlaca(bpa.lecturaSelectPlacas[i].ToString()));
                }
                MessageBox.Show("Se han actualizado " + bpa.lecturaSelectIdHistorico.Count + " Registros del Acta # " + frmNumActa);
            }
            else
            {
                MessageBox.Show("No se encontro el Numero de acta # "+frmNumActa,"Acta no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Si no existe ese registro saltara este error
                
            }

        
        }
    }
}
