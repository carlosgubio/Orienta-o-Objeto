using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Venda_com_uso_de_List
{
    public class Venda
    {
        public double ValorTotal
        {
            get
            {
                double total = 0;
                if (Produto != null && Produto.Any())
                {
                    foreach (Produto p in Produto)
                    {
                        total += p.Preco;
                    }
                }
                return total;
            }
        internal bool Finalizada;

        public int Codigo { get; set; }
        public List<Produto> ListaDeProdutos { get; set; } 
        public double ValorTotalVenda { get; set; }
        public bool StatusDaVenda { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        public Venda() { }

        public Venda(int codigo, List<Produto> listaDeProdutos, double valorTotalVenda, bool statusDaVenda, Vendedor vendedor, Cliente cliente)
        {
            this.Codigo = codigo;
            this.ListaDeProdutos = listaDeProdutos;
            this.ValorTotalVenda = valorTotalVenda;
            this.StatusDaVenda = statusDaVenda;
            this.Vendedor = vendedor;
            this.Cliente = cliente;
        }
        
    }
}
