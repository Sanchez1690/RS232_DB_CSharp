using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MYSQL_DB.Clases
{
    public class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("server=127.0.0.1;port=3306;database=prueba_vs;Uid=Luis;pwd=123");
        }

        public bool AbrirConexion() 
        {
            try { conexion.Open(); return true; }
            catch (MySqlException ex) { return false; throw ex; }
            
        }

        public bool CerrarConexion() 
        {
            try { conexion.Close(); return true; }
            catch (MySqlException ex) { return false; throw ex; }

        }
    }
}
