using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaHerancaVeiculo
{
    public class Moto : Veiculo
    {
        public string Relacao { get; set; }
        public string Manetes { get; set; }
        public string TipoDePartida { get; set; }
        
        public Moto(string relacao, string manetes, string tipoDePartida) :base()
        {
            this.Relacao = relacao;
            this.Manetes = manetes;
            this.TipoDePartida = tipoDePartida;
        }




    }
}
