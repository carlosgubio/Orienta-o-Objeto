using System;
using System.Collections.Generic;
using System.Text;

namespace Venda_com_uso_de_List
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double CPF { get; set; }
        public string Endereco { get; set; }

        public Cliente() { }


        public Cliente(int codigo, string nome, double cpf, string endereco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.CPF = cpf;
            this.Endereco = endereco;
        }
        public override string ToString()
        {
            return $"{this.Codigo} {this.Nome} {this.CPF} {Endereco}";
        }
        static void Clientes(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"Descrição: {cliente.Nome}");
                Console.WriteLine($"Marca: {cliente.CPF}");
                Console.WriteLine($"Marca: {cliente.Endereco}");
            }
        }
    }
}
