using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaHerancaVeiculo
{
    //trator é uma máquina automotriz que pode ser movida por rodas, esteiras, ou de forma mista (tipo de tração)
    //Tipo de uso: Industrial ou agrícola.
    //Tipo de Caçamba: Carregadeira e escavadeira
    public class Trator : Veiculo
    {
        public string TipoDeTracao { get; set; }
        public string TipoDeUso { get; set; }
        public string TipoDeCacamba { get; set; }
        public Trator()
        {

        }

        public Trator(string tipoDeTracao, string tipoDeUso, string tipoDeCacamba):base()
        {
            this.TipoDeTracao = tipoDeTracao;
            this.TipoDeUso = tipoDeUso;
            this.TipoDeCacamba = tipoDeCacamba;
            
        }
    }
}
