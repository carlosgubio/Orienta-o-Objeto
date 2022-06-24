using System;

namespace Interface_Figura_Geometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Hexagono hexagono = new Hexagono() { ComprimentoLado = 9 };
            Console.WriteLine(hexagono.CalcularArea);
        }
    }
}
