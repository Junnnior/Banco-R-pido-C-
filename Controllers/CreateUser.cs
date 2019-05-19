using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoCsharp.Models;
using Npgsql;
using BancoCsharp.connection;

namespace BancoCsharp.Controllers
{
    class CreateUser
    {

        public Pessoa criaUsuario(string novoNome)
        {
            Random random = new Random();

            String novaConta = random.Next(0,9999).ToString();
            String novaSenha = novoNome + "123";

            Pessoa dados = new Pessoa(novoNome, novaConta, novaSenha);

            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=root;Database=pessoa;");
            conn.Open();

            NpgsqlCommand query = new NpgsqlCommand("insert into pessoa values(1,:nome, :conta, :senha)", conn);
            query.Parameters.Add(new NpgsqlParameter("nome", novoNome));
            query.Parameters.Add(new NpgsqlParameter("conta", novaConta));
            query.Parameters.Add(new NpgsqlParameter("senha", novoNome));

            query.ExecuteNonQuery();

            return dados;
        }

    }
}
