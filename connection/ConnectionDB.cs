using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace BancoCsharp.connection
{
    class ConnectionDB
    {

          

        public void openConn()
        {
            try {
                NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=root;Database=pessoa;");
                conn.Open();

            } catch {
                Console.Write("Erro ao abrir o banco");
            }
        }
    }
}
