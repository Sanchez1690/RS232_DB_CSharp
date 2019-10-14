using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MYSQL_DB.Clases
{
    public class Usuario
    {
        public int id_p { get; set; }
        public string titulo { get; set; }
        public string valor { get; set; }


        public Usuario() { }
        public Usuario(int pId_p, string pTitulo, string pValor) 
        {
            this.id_p = pId_p;
            this.titulo = pTitulo;
            this.valor = pValor;
        }

        public static int Agregar(MySqlConnection conexion,Usuario pusuario)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO prueba2 ( id_p,titulo,valor) VALUES ('{0}','{1}','{2}')",pusuario.id_p,pusuario.titulo,pusuario.valor), conexion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        //public static int Actualizar()
        //{

        //}

        //public static int Eliminar()
        //{

        //}

        public static IList<Usuario> Buscar(MySqlConnection conexion, string pTitulo, string pValor)
        {
            List<Usuario> lista = new List<Usuario>();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT id_p,titulo,valor FROM prueba2 WHERE titulo LIKE ('%{0}%')",pTitulo,pValor),conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read()) 
            {
                Usuario pUsuario = new Usuario();
                pUsuario.id_p = reader.GetInt32(0);
                pUsuario.titulo = reader.GetString(1);
                pUsuario.valor = reader.GetString(2);

                lista.Add(pUsuario);
            }
            return lista;
        }


    }
}
