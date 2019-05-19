using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoCsharp.Models;

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


            return dados;
        }

    }
}
