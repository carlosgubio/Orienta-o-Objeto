using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Figura_Geometrica
{
    public class TrianguloEquilatero : IFiguraGeometrica
    {
        public double CalcularArea
        {
            get
            {
                return ComprimentoLado * ComprimentoLado / 2; 
            }
        }
        public int NumeroTotalDeLados
        {
            get
            {
                return 3;
            }
        }
        public double Perimetro 
        { 
            get
            {
                return ComprimentoLado * 3;
            }
        }
        public double ComprimentoLado { get; set; }
    }
}
