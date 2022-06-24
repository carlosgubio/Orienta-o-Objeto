using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Figura_Geometrica
{
    public class Hexagono : IFiguraGeometrica
    {
        public double CalcularArea
        {
            get
            {
                double AoQuadrado = Math.Pow(ComprimentoLado, 2);
                double Raiz = Math.Sqrt(3);
                return Math.Round(3 * Raiz * AoQuadrado / 2, 2);
            }
        }
        public int NumeroTotalDeLados
        {
            get
            {
                return 6;
            }
        }
        public double Perimetro
        {
            get
            {
                return ComprimentoLado * 6; 
            }
        }
        public double ComprimentoLado { get; set; }
    }
}
