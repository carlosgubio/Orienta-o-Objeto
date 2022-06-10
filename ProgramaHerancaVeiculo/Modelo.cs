using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaHerancaVeiculo
{
    public class Modelo
    {
        public string Descricao { get; set; }

        public Modelo(string descricao)
        {
            this.Descricao = descricao;
        }
    }
}
