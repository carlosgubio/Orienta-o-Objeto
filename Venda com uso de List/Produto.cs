using System;
using System.Collections.Generic;
using System.Text;

namespace Venda_com_uso_de_List
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string DescricaoDoProduto { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }

        public Produto() { }

        public Produto(int codigo, string descricaoDoProduto, string marca, double preco)
        {
            this.Codigo = codigo;
            this.DescricaoDoProduto = descricaoDoProduto;
            this.Marca = marca;
            this.Preco = preco;
        }
        public override string ToString()
        {
            return $" {this.Codigo} {this.DescricaoDoProduto} {this.Marca}  {this.Preco}";
        }
        static void ListarProdutos(List<Produto> produtos)
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Descrição: {produto.DescricaoDoProduto}");
                Console.WriteLine($"Marca: {produto.Marca}");
                Console.WriteLine($"Preço: {produto.Preco}");
            }
        }
    }
}
