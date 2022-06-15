using System;
using System.Collections.Generic;
using System.Text;

namespace Venda_com_uso_de_List
{
    public class Venda
    {
        public List<Produto> ListaDeProdutos { get; set; } 
        public double ValorTotalVenda { get; set; }
        public bool StatusDaVenda { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        public Venda() { }

        public Venda(List<Produto> listaDeProdutos, double valorTotalVenda, bool statusDaVenda, Vendedor vendedor, Cliente cliente)
        {
            this.ListaDeProdutos = listaDeProdutos;
            this.ValorTotalVenda = valorTotalVenda;
            this.StatusDaVenda = statusDaVenda;
            this.Vendedor = vendedor;
            this.Cliente = cliente;
        }
        
    }
}
