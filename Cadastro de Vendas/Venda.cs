using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_de_Vendas
{
    public class Venda
    {
        public double ValorTotalVenda { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        public Venda() { }

        public Venda(double valorTotalVenda, Vendedor vendedor, Cliente cliente)
        {
            this.ValorTotalVenda = valorTotalVenda;
            this.Vendedor = vendedor;
            this.Cliente = cliente;
        }
    }
}
