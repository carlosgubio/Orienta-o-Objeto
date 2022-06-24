using System;

namespace Interface_Figura_Geometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            IFiguraGeometrica trianguloEquilatero = new TrianguloEquilatero() 
            { 
                ComprimentoLado = 5,
            };
            IFiguraGeometrica quadrado = new Quadrado()
            {
                ComprimentoLado = 6,
            };
            IFiguraGeometrica pentagono = new Pentagono()
            {

                ComprimentoLado = 3,
            };
            IFiguraGeometrica hexagono = new Hexagono()
            {
                ComprimentoLado = 7,
            };

            Console.WriteLine("A área do Triangulo Equilátero é: " + trianguloEquilatero.CalcularArea + " cm");
            Console.WriteLine("A área do Quadrado é: " + quadrado.CalcularArea + " cm");
            Console.WriteLine("A área do Pentágono é: " + pentagono.CalcularArea + " cm");
            Console.WriteLine("A área do Hexágono é: " + hexagono.CalcularArea + " cm");
        }
    }
}
