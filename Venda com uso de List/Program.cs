using System;
using System.Collections.Generic;

namespace Venda_com_uso_de_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            List<Cliente> cliente = new List<Cliente>();
            List<Venda> venda = new List<Venda>();
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Produtos.Add(new Produto());






            vendedores.Add(new Vendedor("Mario", 10));
            vendedores.Add(new Vendedor("Jorge", 11));




        }
    }
}
