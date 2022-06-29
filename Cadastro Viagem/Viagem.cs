using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_Viagem
{
    public class Viagem
    {
        public Caminhao Caminhao { get; set; }
        public Motorista Motorista { get; set; }
        public int IdViagem { get; set; }

        public Viagem(string caminhao, string motorista, int id)
        {
            this.IdViagem = id;
        }

        public Viagem(int idViagem)
        {
            IdViagem = idViagem;
        }
    }
}
