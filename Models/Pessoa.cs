using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCsharp.Models
{
    class Pessoa
    {
        private string nome;
        private string conta;
        private string senha;


        public Pessoa(string novoNome, string novaConta, string novaSenha)
        {
            nome = novoNome;
            conta = novaConta;
            senha = novaConta;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Conta
        {
            get { return conta; }
            set { conta = value; }
        }



        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
