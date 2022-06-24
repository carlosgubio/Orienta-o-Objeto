using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_de_Produtos
{
    public interface IProduto
    {

        public string Descricao { get; set; }
        public string Marca { get; set; }
        public double ValorEmReal { get; set; }
        public double ValorMoedaOrigem { get;  }

        public string PaisDeOrigem { get; set; }

        public string ToString()
        {
            return $"Descrição: {Descricao}, Marca: {Marca}, Valor {ValorEmReal}, Valor de Origem {ValorMoedaOrigem}";
        }

    }
}
