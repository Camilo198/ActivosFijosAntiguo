using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrosActas
{
    class ActualizacionPlaca
    {
        String F_IdHistorico;
        String F_Placa;
        ConexionActivos_Chevyplan c;
                String consulta;
        SqlCommand comando;
        String registrosAfectados;
        
        public void actualizarPlacaActivo(String frmIdHistorico,String FrmPlaca)
        {
            // Recibe el parametro del formulario y se lo pasa a una variable local
            F_IdHistorico = frmIdHistorico;
            try
            {

                c = ConexionActivos_Chevyplan.getConexionObj(); // Obtiene el Objeto Singleton de conexion con la base de datos
                // c.crearConexion(); // Crea la conexion a la base de datos
                // valida que el campo recibido no sea Nulo ni vacio
                if (F_IdHistorico != null && F_IdHistorico != "")
                {
                    if(F_Placa!=null && F_Placa!=""){
                    //consulta SQL
                    consulta = "UPDATE HISTORICO set PLACA ="+F_Placa +"where ID_HISTORICO =" + F_IdHistorico;
                    }
                    else{MessageBox.Show("Consulte un Numero de PLACA Por favor", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
                }
                else { MessageBox.Show("Ingrese un Numero de ID_Historico Por favor", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                comando = new SqlCommand(consulta, c.crearConexion());// comando SQLque ejecuta la consulta

                c.conectar();// conecta a la base de datos
                registrosAfectados = comando.ExecuteNonQuery().ToString();//identifica cuantos registros fueron afectados por el Query
                //Indica si se actualizaron o no los datos asociados al numero de ID_HISTORICO
                if (registrosAfectados != "0")
                {
                    MessageBox.Show("Se actualizaron " + registrosAfectados + "  registros del ID_HISTORICO # " + F_IdHistorico, "Actualización Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No hay registros asociados al ID_HISTORICO # " + F_IdHistorico, "Sin Actualización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                c.desconectar();// Cerrar la conexion con la base de datos

            }
            // Manejo de actas
            catch (SqlException)
            {
                MessageBox.Show("Ingrese solo numeros", "Letras detectadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Muestras excepcion si ingresa algo que no sean numeros

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No se encontro este Numero de ID_HISTORICO \n", "Acta No Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Si no existe ese registro saltara este error
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Entrada Invalida ", "Datos Inapropiados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Muestras excepcion si no ingresa nada
            }
        }
    }
}
