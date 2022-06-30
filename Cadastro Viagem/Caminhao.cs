using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_Viagem
{
    public class Caminhao
    {
        public int BaseId { get; set; } = 0;
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int IdCaminhao { get; set; }

        public Caminhao(string modelo, string placa, int id)
        {
            this.Modelo = modelo;
            this.Placa = placa;
            this.IdCaminhao = BaseId;
            BaseId++;
        }
        public Caminhao() { }
    }
}
