using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBD
{
    public class ConexionBD
    {
        public static MySqlConnection ObtenerConexion()
        {
            string cadena = "Server=127.0.0.1;Port=3306;Database=bibliotecadb;Uid=root;Pwd=0000;";
            MySqlConnection conexion = new MySqlConnection(cadena);
            return conexion;
        }
    }
}
