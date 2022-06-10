using System;

namespace Orientação_Objeto___Veículos
{
    public class Veiculo
    {
        public string Chassis { get; set; }
        public string Ano { get; set; }
        public Modelo Modelo { get; set; }
        public Marca Marca { get; set; }
        public string Preco { get; set; }
        public Motor Motor { get; set; }
        public Veiculo(string chassis, string ano, string preco)
        {
            this.Chassis = chassis;
            this.Ano = ano;
            this.Preco = preco;
        }
    }
}
