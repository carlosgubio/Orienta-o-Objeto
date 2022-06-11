using System;
using System.Collections.Generic;
using System.Text;

namespace Venda_com_uso_de_List
{
    class Produto
    {
        public string DescricaoDoProduto { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }

        public Produto() { }

        public Produto(string descricaoDoProduto, string marca, double preco)
        {
            this.DescricaoDoProduto = descricaoDoProduto;
            this.Marca = marca;
            this.Preco = preco;
        }
    }
}
