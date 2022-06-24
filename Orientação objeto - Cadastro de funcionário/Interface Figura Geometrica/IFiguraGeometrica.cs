using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Figura_Geometrica
{
    public interface IFiguraGeometrica
    {
        public double CalcularArea { get; }
        public int NumeroTotalDeLados { get; }
        public double Perimetro { get; }
        public double ComprimentoLado { get; set; }
        
    }

}
