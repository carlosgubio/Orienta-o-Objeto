using System;
using System.Collections.Generic;
using System.Text;

namespace Orientação_Objeto___Veículos
{
    public class Marca
    {
        public string Descricao { get; set; }
        public string PaisOrigem { get; set; }

        public Marca(string descricao, string paisOrigem)
        {
            this.Descricao = descricao;
            this.PaisOrigem = paisOrigem;
        }
    }
}