using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_Viagem
{
    public class Motorista
    {
        public int BaseId { get; set; } = 0;
        public string Nome { get; set; }
        public string End { get; set; }
        public int IdMotorista { get; set; }

        public Motorista(string nome, string end)
        {
            this.Nome = nome;
            this.End = end;
            this.IdMotorista = BaseId;
            BaseId++;
        }
        public Motorista() { }
        
    }
}
