using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class ConexaoModel
    {
        // Conexão com o BD
        MySqlConnection con = new MySqlConnection();

        // Construtor
        public ConexaoModel()
        {
            con.ConnectionString = @"server=127.0.0.1;port=3312;User Id=root;Database=eventos";
        }

        // Método Conectar
        public MySqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        // Método Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
