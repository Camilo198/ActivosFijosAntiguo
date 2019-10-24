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
  public  class ConexionPSL
    {
        private ConexionPSL()
        {
        }
        //Parametros para conectarce a la base de datos
        private static ConexionPSL conexionObj;
        private String serverID = "SDATCHE004FV";
        private String dataBase = "PSL";
        // private String Security= "true";
        private String usuario = "userpsl";

        private string password = "Erppsl2017";

        private SqlConnection sqlConexion;

        //Metodo que retorna el onjeto de tipo Conexion
        public static ConexionPSL getConexionObj()
        {
            if (conexionObj == null)
            {
                conexionObj = new ConexionPSL();
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
