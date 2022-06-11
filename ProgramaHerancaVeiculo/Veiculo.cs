using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaHerancaVeiculo
{
    public class Veiculo
    {
        public string Chassis { get; set; }
        public string Ano { get; set; }
        public Modelo Modelo { get; set; }
        public Marca Marca { get; set; }
        public double Preco { get; set; }
        public Motor Motor { get; set; }
        public Veiculo()
        {

        }

        public Veiculo(string chassis, string ano, double preco)
        {
            this.Chassis = chassis;
            this.Ano = ano;
            this.Preco = preco;
        }
    }
}
