using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoCsharp.Controllers;
using BancoCsharp.Models;
using System.Windows.Forms;

namespace BancoCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;

            try
            {
                Pessoa res = new CreateUser().criaUsuario(nome);
                MessageBox.Show("conta: " + res.Conta + "\nsenha: "+res.Senha);

            }
            catch
            {
                MessageBox.Show("ERRO AO CRIAR CONTA");
            }



            
        }
    }
}
