using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaHerancaVeiculo
{
    public class Moto : Veiculo
    {
        public string Relacao { get; set; }
        public string Paralama { get; set; }
        public string Manetes { get; set; }
        public string PedalDePartida { get; set; }
        
        public Moto(string relacao, string paralama, string manetes, string pedalDePartida)
        {
            this.Relacao = relacao;
            this.Paralama = paralama;
            this.Manetes = manetes;
            this.PedalDePartida = pedalDePartida;
        }




    }
}
