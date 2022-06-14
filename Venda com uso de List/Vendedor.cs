using System;
using System.Collections.Generic;
using System.Text;

namespace Venda_com_uso_de_List
{
    public class Vendedor
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double CodigoCracha { get; set; }

        public Vendedor() { }

        public Vendedor(int codigo, string nome, double codigoCracha)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.CodigoCracha = codigoCracha;
        }
        public override string ToString()
        {
            return $"{this.Codigo} {this.Nome} {this.CodigoCracha}";
        }
        static void ListarVendedor(List<Vendedor> vendedores)
        {
            foreach (Vendedor vendedor in vendedores)
            {
                Console.WriteLine($"Descrição: {vendedor.Nome}");
                Console.WriteLine($"Marca: {vendedor.CodigoCracha}");
            }
        }
    }
}
