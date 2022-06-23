using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_de_Produtos
{
    public class Origem
    {
        public string Italia { get; set; }
        public string India { get; set; }
        public string Brasil { get; set; }

        public Origem() { }

        public Origem(string italia, string india, string brasil)
        {
            this.Italia = italia;
            this.India = india;
            this.Brasil = brasil;
        }

    }
}
