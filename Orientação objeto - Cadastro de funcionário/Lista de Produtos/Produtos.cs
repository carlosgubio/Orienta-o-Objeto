using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_de_Produtos
{
    public class Produto
    {
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public double ValorEmReal { get; set; }
        public double ValorMoedaOrigem { get; set; }
        public string PaisDeOrigem { get; set; }

        public Produto() { }

        public Produto(string marca, string descricao, double valorEmReal, double valorMoedaOrigem, string paisDeOrigem)
        {
            this.Marca = marca;
            this.Descricao = descricao;
            this.ValorEmReal = valorEmReal;
            this.ValorMoedaOrigem = valorMoedaOrigem;
            this.PaisDeOrigem = paisDeOrigem;
        }
    }
}
