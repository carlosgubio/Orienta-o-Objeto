using System;

namespace Orientação_objeto___Cadastro_de_funcionário
{
    public class Funcionario
    {
        public string Nome;
        public string Departamento;
        public double Salario;
        public string DataAdmissao;
        public string Rg;
        public bool AtivoNaEmpresa;
      
        
       
        

        
        public Funcionario(string nome, string departamento, double salario, string dataAdmissao,
            string rg, bool ativoNaEmpresa)
        {
            this.Nome = nome;
            this.Departamento = departamento;
            this.Salario = salario;
            this.DataAdmissao = dataAdmissao;
            this.Rg = rg;
            this.AtivoNaEmpresa = ativoNaEmpresa;
        }

        public double Bonifica(double SalarioNovo)
        {
            return this.Salario += SalarioNovo;
        }
    }   
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
            int AtivoNaEmpresa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Valor a Bonificar:");
            double Bonifica = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            Funcionario Funcionario = new Funcionario(Nome, Departamento, Salario, DataAdmissao, Rg, ativo);
            
            if (AtivoNaEmpresa == 1)
                Console.WriteLine("Ativo.");

            Funcionario.Bonifica(Bonifica);
            
            Console.WriteLine("Nome:" + Funcionario.Nome);
            Console.WriteLine("Departamento:" + Funcionario.Departamento);
            Console.WriteLine("Salário:" + Funcionario.Salario);
            Console.WriteLine("Data da Admissão:" + Funcionario.DataAdmissao);
            Console.WriteLine("RG nº:" + Funcionario.Rg);
            Console.WriteLine("O valor total do salário é R$:" + Funcionario.Salario);
            Console.WriteLine("O funcionário está" + Funcionario.AtivoNaEmpresa);
        }
    }
}
