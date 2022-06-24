using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_de_Produtos
{
    public class Macarrao : IProduto
    {
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public double ValorEmReal { get; set; } 
        public string PaisDeOrigem { get; set; }
        
        public double ValorMoedaOrigem
        {
            get
            {
                return ValorEmReal / 5.51;
            }
        }

    }
}

