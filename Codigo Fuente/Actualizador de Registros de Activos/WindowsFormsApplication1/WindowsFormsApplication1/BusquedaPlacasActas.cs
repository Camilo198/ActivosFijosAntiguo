using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrosActas
{
    class BusquedaPlacasActas
    {
        
        ConexionActivos_Chevyplan c;
        String consulta;
        SqlCommand comando;
        private SqlDataReader lecturaDatos;
        public ArrayList lecturaSelectPlacas = new ArrayList();
        public ArrayList lecturaSelectIdHistorico = new ArrayList();
        public void buscarPLaca(int frmNumActa)
        {
            // Recibe el parametro del formulario y se lo pasa a una variable local
         
            try
            {

                c = ConexionActivos_Chevyplan.getConexionObj(); // Obtiene el Objeto Singleton de conexion con la base de datos
                // c.crearConexion(); // Crea la conexion a la base de datos
                // valida que el campo recibido no sea Nulo ni vacio
                if (frmNumActa > -1)
                {
                    //consulta SQL
                    consulta = "Select ID_HISTORICO, PLACA from HISTORICO  where ACTA_ENTREGA = '" + frmNumActa + "'";


                }
                else { MessageBox.Show("Ingrese una Numero de Acta  Valido Valor Negativo", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                comando = new SqlCommand(consulta, c.crearConexion());// comando SQLque ejecuta la consulta

                c.conectar();// conecta a la base de datos
                //Indica los datos  asociados ala busqueda aproximada en psl

                lecturaDatos = comando.ExecuteReader();// Registros Leidos del Select
          
                while (lecturaDatos.Read())
                {
                    lecturaSelectPlacas.Add(lecturaDatos[1]);
                    lecturaSelectIdHistorico.Add(lecturaDatos[0]);
                }
                
                c.desconectar();// Cerrar la conexion con la base de datos

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Entrada Invalida ", "Datos Inapropiados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Muestras excepcion si no ingresa nada
            }

        }
    }
}
