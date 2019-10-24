using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MYSQL_DB.Clases
{
    class Conexion_2
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion_2()
        {
            try
            {
                //Data Source=.;Initial Catalog=prueba;Integrated Security=True
                cn = new SqlConnection("Data Source=.;Initial Catalog=prueba;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex) { MessageBox.Show("No se conecto :" + ex.ToString()); }
        }

        public string ingresar(string fecha, string dato)
        {
            string salida = "Dato ingresado";
            try
            {
                cmd = new SqlCommand("Insert into Table_1(Fecha,Temperatura) values('" + fecha + "','" + dato + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { salida = "No se conecto: " + ex.ToString(); }
            return salida;
        }

        public void desconectar() 
        {
            cn.Close();
            MessageBox.Show("Desconectado");
        }
    }
}
