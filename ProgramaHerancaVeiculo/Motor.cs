using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaHerancaVeiculo
{
    public class Motor
    {
        public string TipoDeMotor { get; set; }
        public string TipoDeCombustivel { get; set; }
        public string DescricaoMotor { get; set; }
        public double Potencia { get; set; }
        public double Torque { get; set; }

        public Motor(string tipoDeMotor, string tipoDeCombustivel, string descricaoMotor, double potencia, double torque)
        {
            this.TipoDeMotor = tipoDeMotor;
            this.TipoDeCombustivel = tipoDeCombustivel;
            this.DescricaoMotor = descricaoMotor;
            this.Potencia = potencia;
            this.Torque = torque;
        }
    }
}
