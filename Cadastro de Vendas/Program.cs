using System;

namespace Cadastro_de_Vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor1 = new Vendedor("Marcelo", 26);
            Vendedor vendedor2 = new Vendedor("Claudia", 12);

            Cliente cliente1 = new Cliente("Lucas", 85687412500, "Rua F, Qd 22 Itajaí-SC");
            Cliente cliente2 = new Cliente("Luana", 52487458922, "Av. R, 123 Itajaí-SC");

            Venda venda1 = new Venda(2000, vendedor1, cliente1);
            Venda venda2 = new Venda(1500, vendedor2, cliente2);

            Console.WriteLine("1º Venda");
            Console.WriteLine("Vendedor:" + venda1.Vendedor.Nome);
            Console.WriteLine("Crachá nº:" + venda1.Vendedor.CodigoCracha);
            Console.WriteLine("Cliente:" + venda1.Cliente.Nome);
            Console.WriteLine("CPF:" + venda1.Cliente.CPF);
            Console.WriteLine("Endereço:" + venda1.Cliente.Endereco);
            Console.WriteLine("Valor da Venda:" + venda1.ValorTotalVenda);
            Console.WriteLine();
            Console.WriteLine("2º Venda");
            Console.WriteLine("Vendedor:" + venda2.Vendedor.Nome);
            Console.WriteLine("Crachá nº:" + venda2.Vendedor.CodigoCracha);
            Console.WriteLine("Cliente:" + venda2.Cliente.Nome);
            Console.WriteLine("CPF:" + venda2.Cliente.CPF);
            Console.WriteLine("Endereço:" + venda2.Cliente.Endereco);
            Console.WriteLine("Valor da Venda:" + venda2.ValorTotalVenda);
        }
    }
}
