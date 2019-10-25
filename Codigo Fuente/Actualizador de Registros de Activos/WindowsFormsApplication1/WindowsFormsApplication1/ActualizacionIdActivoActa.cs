using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegistrosActas
{// clase que actualiza registros en la base de datos
    class ActualizacionIdActivoActa
    {
        String consulta;
        SqlCommand comando;
        ConexionActivos_Chevyplan c;
        public void actualizarActa(String IdHistorico,String IdActivo)
        {
            // Recibe el parametro del formulario y se lo pasa a una variable local
            
                c = ConexionActivos_Chevyplan.getConexionObj(); // Obtiene el Objeto Singleton de conexion con la base de datos
                // c.crearConexion(); // Crea la conexion a la base de datos               
                            
                    //consulta SQL
                    consulta = "UPDATE HISTORICO set ID_ACTIVO ='" +IdActivo+ "'where ID_HISTORICO =" + IdHistorico;
           
                comando = new SqlCommand(consulta, c.crearConexion());// comando SQLque ejecuta la consulta

                c.conectar();// conecta a la base de datos
                comando.ExecuteNonQuery();
                c.desconectar();// Cerrar la conexion con la base de datos

            }


        

        
    }
}
