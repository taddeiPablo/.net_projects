using System;
using System.Collections.Generic;
using System.Text;

using Practica_patrones_en_CSharp.Factory_Method.AbstractClasses;

namespace Practica_patrones_en_CSharp.Factory_Method
{
    public class PizzaNapolitana: Pizza
    {
        public PizzaNapolitana(string descripcion)
        {
            this.Descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"Este tipo de pizza es : {this.Descripcion}";
        }
    }
}
