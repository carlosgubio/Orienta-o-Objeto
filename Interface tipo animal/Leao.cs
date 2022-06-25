using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_tipo_animal
{
    public class Leao : IAnimal
    {
        public void Respirar()
        {
            throw new NotImplementedException();
        }
        public void Caminhar()
        {
            throw new NotImplementedException();
        }
        public void Levantar()
        {
            Console.WriteLine("Não Levanta");
        }
        public void Correr()
        {
            throw new NotImplementedException();
        }
        public bool Vivo
        {
            get
            {
                return true;
            }
        }
        public enum TipoAlimentacao
        {
        }
        public bool ComeAnimaisVivos
        {
            get
            {
                return true;
            }
                
                
        }

        bool IAnimal.Vivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IAnimal.ComeAnimaisVivos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
