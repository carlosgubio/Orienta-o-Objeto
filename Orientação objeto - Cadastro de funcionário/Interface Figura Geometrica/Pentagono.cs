using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Figura_Geometrica
{
    public class Pentagono : IFiguraGeometrica
    {
        private
        public double CalcularArea
        {
            get
            {

                return ComprimentoLado / 2;
            }
        }
        public int NumeroTotalDeLados { get; set; } = 5;
        public double Perimetro
        {
            get
            {
                return ComprimentoLado * 5;
            }
        }
        public double ComprimentoLado { get; set; }

    }
}
