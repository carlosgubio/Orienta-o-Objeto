using System;
using System.Collections.Generic;
using System.Text;

namespace Orientação_objeto___Cadastro_de_funcionário
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public double Salario { get; set; }
        public string DataAdmissao { get; set; }
        public string Rg { get; set; }
        public bool Ativo { get; set; }
        public double Bonificar { get; set; }

        public bool Demite()
        {
            return this.Ativo = false;
        }
        public double Bonifica(double SalarioTotal)
        {
            return this.Salario += SalarioTotal;
        }

        public Funcionario(string nome, string departamento, double salario, string dataAdmissao,
            string rg, bool ativo, double Bonifica)
        {
            this.Nome = nome;
            this.Departamento = departamento;
            this.Salario = salario;
            this.DataAdmissao = dataAdmissao;
            this.Rg = rg;
            this.Ativo = ativo;


        }
    }
}
