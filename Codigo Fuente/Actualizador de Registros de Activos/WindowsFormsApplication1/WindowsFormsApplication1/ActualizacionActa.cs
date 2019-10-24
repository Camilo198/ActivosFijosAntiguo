using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegistrosActas
{// clase que actualiza registros en la base de datos
    class ActualizacionActa
    {
        String F_Acta;
        String consulta;
        SqlCommand comando;
        ConexionActivos_Chevyplan c;
        String registrosAfectados;
        public void actualizarActa(String FrmElemento)
        {
            // Recibe el parametro del formulario y se lo pasa a una variable local
            F_Acta = FrmElemento;
            try
            {

                c = ConexionActivos_Chevyplan.getConexionObj(); // Obtiene el Objeto Singleton de conexion con la base de datos
                // c.crearConexion(); // Crea la conexion a la base de datos
                // valida que el campo recibido no sea Nulo ni vacio
                if (F_Acta != null && F_Acta != "")
                {
                    //consulta SQL
                    consulta = "UPDATE HISTORICO set ID_ACTIVO = SUBSTRING(PLACA,4,1)+SUBSTRING(PLACA,6,10) where ACTA_ENTREGA =" + F_Acta;

                }
                else { MessageBox.Show("Ingrese un Numero de Acta Por favor", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                comando = new SqlCommand(consulta, c.crearConexion());// comando SQLque ejecuta la consulta

                c.conectar();// conecta a la base de datos
                registrosAfectados = comando.ExecuteNonQuery().ToString();//identifica cuantos registros fueron afectados por el Query
                //Indica si se actualizaron o no los datos asociados al numero de actta
                if (registrosAfectados != "0")
                {
                    MessageBox.Show("Se actualizaron "+registrosAfectados+"  registros del Acta # " + F_Acta,"Actualización Correcta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("No hay registros asociados al acta # " + F_Acta, "Sin Actualización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("No se encontro este Numero de Acta \n","Acta No Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Si no existe ese registro saltara este error
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Entrada Invalida ","Datos Inapropiados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Muestras excepcion si no ingresa nada
            }
        }

        
    }
}
