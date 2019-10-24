using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistrosActas
{
  public  class busquedaPlaca
    {

            String F_RefActivo;
            ConexionPSL c;
            String consulta;
            SqlCommand comando;
            String registrosAfectados;
            private SqlDataReader lecturaDatos;
         public   ArrayList lecturaSelectPlacas = new ArrayList();
         public   ArrayList lecturaSelectNombreActivos = new ArrayList();
        public void buscarPLaca(String frmRecActivo)
        {
            // Recibe el parametro del formulario y se lo pasa a una variable local
            F_RefActivo = frmRecActivo;
            try
            {

                c = ConexionPSL.getConexionObj(); // Obtiene el Objeto Singleton de conexion con la base de datos
                // c.crearConexion(); // Crea la conexion a la base de datos
                // valida que el campo recibido no sea Nulo ni vacio
                if (F_RefActivo != null && F_RefActivo != "")
                {
                    //consulta SQL
                    consulta = "Select actcodidentinv, actnombre from af_activos  where actnombre like '%" + F_RefActivo+"%'";
                    
                    
                }
                else { MessageBox.Show("Ingrese una referencia de activo  Por favor", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                comando = new SqlCommand(consulta, c.crearConexion());// comando SQLque ejecuta la consulta

                c.conectar();// conecta a la base de datos
                //Indica los datos  asociados ala busqueda aproximada en psl

                lecturaDatos = comando.ExecuteReader();// Registros Leidos del Select
                MessageBox.Show(lecturaDatos.ToString());
                while (lecturaDatos.Read())
                {
                    lecturaSelectPlacas.Add(lecturaDatos[0]);
                    lecturaSelectNombreActivos.Add(lecturaDatos[1]);
                }



                c.desconectar();// Cerrar la conexion con la base de datos

            }
            // Manejo de actas
           /* catch (SqlException)
            {
                MessageBox.Show("Ingrese solo numeros", "Letras detectadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Muestras excepcion si ingresa algo que no sean numeros

            }*/
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
