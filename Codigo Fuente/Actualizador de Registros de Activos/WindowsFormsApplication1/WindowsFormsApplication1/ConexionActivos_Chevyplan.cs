using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegistrosActas
{
    //Clase que se conecta con la base de datos.
  public  class ConexionActivos_Chevyplan
    {
        private ConexionActivos_Chevyplan()
        {
        }
        //Parametros para conectarce a la base de datos
        private static ConexionActivos_Chevyplan conexionObj;
        private String serverID = "SBOGCHE037v";
        private String dataBase = "Activos_Chevyplan";
        // private String Security= "true";
        private String usuario = "usr_activos";

        private string password = "4ct1v0s";

        private SqlConnection sqlConexion;

        //Metodo que retorna el onjeto de tipo Conexion
        public static ConexionActivos_Chevyplan getConexionObj()
        {
            if (conexionObj == null)
            {
                conexionObj = new ConexionActivos_Chevyplan();
                return conexionObj;
            }
            else
            {

                return conexionObj;
            }

        }

        //Metodo que Crea la conexion a la base de datos
        public SqlConnection crearConexion()
        {

            sqlConexion = new SqlConnection("server=" + serverID + ";database=" + dataBase + ";user id=" + usuario +
                                        ";password=" + password);

            //";integrated security =" + Security
            return sqlConexion;
        }

        //Metodo que se conecta con la base de datos
        public void conectar()
        {

            sqlConexion.Open();
            //MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");

        }
        //Metodo que se desconecta con la base de datos
        public void desconectar()
        {
            sqlConexion.Close();
            //MessageBox.Show("Se cerró la conexión.");
        }
    }
}
