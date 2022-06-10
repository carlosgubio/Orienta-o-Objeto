using System;
using System.Collections.Generic;
using System.Text;

namespace Orientação_Objeto___Veículos
{ 
    public class Motor
    {
        public string TipoDeMotor { get; set;}
        public string TipoDeCombustivel { get; set; }
        public string Descricao { get; set; }
        public string Potencia { get; set; }
        public string Torque { get; set; }

        public Motor(string tipoDeMotor, string tipoDeCombustivel, string descricao, string potencia, string torque)
        {
            this.TipoDeMotor = tipoDeMotor;
            this.TipoDeCombustivel = tipoDeCombustivel;
            this.Descricao = descricao;
            this.Potencia = potencia;
            this.Torque = torque;
        }
    }
}
