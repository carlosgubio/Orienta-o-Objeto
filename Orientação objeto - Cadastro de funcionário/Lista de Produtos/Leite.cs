using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_de_Produtos
{
    public class Leite : IProduto
    {
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public double ValorEmReal { get; set; }
        public string PaisDeOrigem { get; set; }
        public double ValorMoedaOrigem
        {
            get
            {
                return ValorEmReal / 14.91;
            }
        }
    }
}
