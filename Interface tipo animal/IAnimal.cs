using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_tipo_animal
{
    public interface IAnimal
    {
        public void Respirar();
        public void Caminhar();
        public void Levantar();
        public void Correr();
        public bool Vivo { get; set; }
        public TipoAlimentacao TipoAlimentacaoAnimal
        public bool ComeAnimaisVivos { get; set; }
    }
}
