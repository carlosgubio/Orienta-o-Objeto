using System;
using Orientação_objeto___Cadastro_de_funcionário;

namespace Orientação_objeto___Cadastro_de_funcionário
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ativo = true; 
            Console.WriteLine("Nome do Funcionário:");
            string Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Departamento:");
            String Departamento = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Salário:");
            double Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Data da Admissão:");
            String DataAdmissao = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("RG nº:");
            String Rg = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Se o funcionário estiver ativo, digite 1, se não digite 2");
            int sim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Valor a Bonificar:");
            double Bonifica = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Funcionario funcionario = new Funcionario(Nome, Departamento, Salario, DataAdmissao, Rg, ativo, Bonifica);

            if (sim == 2)
                funcionario.Demite();

            funcionario.Bonifica(Bonifica);
            
            Console.WriteLine("Nome:" + funcionario.Nome);
            Console.WriteLine("Departamento:" + funcionario.Departamento);
            Console.WriteLine("Salário:" + funcionario.Salario);
            Console.WriteLine("Data da Admissão:" + funcionario.DataAdmissao);
            Console.WriteLine("RG nº:" + funcionario.Rg);
            Console.WriteLine("O valor do benefício é:" + funcionario.Bonificar);
            Console.WriteLine("O valor total do salário é R$:" + funcionario.Salario);
            Console.WriteLine("Este funcionário trabalha na Empresa? " + funcionario.Ativo);
           
        }
    }
}
