using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_Viagem
{
    public class Caminhao
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int IdCaminhao { get; set; }

        public Caminhao(string modelo, string placa, int id)
        {
            this.Modelo = modelo;
            this.Placa = placa;
            this.IdCaminhao = id;
        }
        public Caminhao() { }
        public override string ToString() =>

            $"Modelo: {Modelo} | Placa: {Placa} | Id do Caminhão: {IdCaminhao}";
        
    }
}
