using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_de_Vendas
{
    public class Vendedor
    {
        public string Nome { get; set; }
        public double CodigoCracha { get; set; }

        public Vendedor() { }

        public Vendedor(string nome, double codigoCracha)
        {
            this.Nome = nome;
            this.CodigoCracha = codigoCracha;
        }
    }
}
