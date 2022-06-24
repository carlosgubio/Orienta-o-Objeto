using System;
using System.Collections.Generic;
using System.Linq;


namespace Lista_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProduto> produto = new List<IProduto>();
            produto.Add(new Macarrao()
            {
                Descricao = "spaghetti",
                Marca = "Macarrone",
                ValorEmReal = 4.70,
                PaisDeOrigem = "Italia"
            });
            produto.Add(new Leite()
            {
                Descricao = "Tipo 1",
                Marca = "Vaquinha",
                ValorEmReal = 5.30,
                PaisDeOrigem = "India"
            });
            produto.Add(new Carne()
            {
                Descricao = "Picanha",
                Marca = "Boizão",
                ValorEmReal = 24,
                PaisDeOrigem = "Brasil"
            });

            foreach (IProduto produtos in produto)
            {
                Console.WriteLine(produto.ToString());
            }
        }
     
      

    }
}
