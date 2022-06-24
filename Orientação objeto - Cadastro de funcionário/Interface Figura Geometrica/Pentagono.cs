using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Figura_Geometrica
{
    public class Pentagono : IFiguraGeometrica
    {
        private double tangente36Graus = 0.726542528;

        public double CalcularArea
        {
            get
            {
                var metadeLado = ComprimentoLado / 2;
                var altura = metadeLado / tangente36Graus;
                var areaTriangulo = (metadeLado * altura) / 2;
                return Math.Round (areaTriangulo * 10, 2);
            }
        }
        public int NumeroTotalDeLados 
        {
            get
            {
                return 5;
            }
        }
        public double Perimetro
        {
            get
            {
                return NumeroTotalDeLados * ComprimentoLado;
            }
        }
        public double ComprimentoLado { get; set; }

    }
}
