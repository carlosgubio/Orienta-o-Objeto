using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaHerancaVeiculo
{
    //O cavalo mecânico pode ser acoplado aos módulos de carga que podem ser fechados(baú, frigorífico, tanque, silo) ou abertos(carroceria aberta, grade baixa, cegonheiro, gaiola, caçamba e plataformas).

    public class Caminhao : Veiculo
    {
        public string Eixos { get; set; }
        public string PesoBruto { get; set; }
        public string ModuloDeCarga { get; set; }

        public Caminhao(string eixos, string pesoBruto, string moduloDeCarga):base()
        {
            this.Eixos = eixos;
            this.PesoBruto = pesoBruto;
            this.ModuloDeCarga = moduloDeCarga;
        }
    }
}
