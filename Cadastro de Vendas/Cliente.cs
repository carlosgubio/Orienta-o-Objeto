using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_de_Vendas
{
    public class Cliente
    {
        public string Nome { get; set; }
        public double CPF { get; set; }
        public string Endereco { get; set; }

        public Cliente() { }

        public Cliente(string nome, double cpf, string endereco)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Endereco = endereco;
        }
    }
}
