using System;
using System.Collections.Generic;
using System.Text;

using Practica_patrones_en_CSharp.Factory_Method.AbstractClasses;

namespace Practica_patrones_en_CSharp.Factory_Method
{
    public class PizzaDeCancha: Pizza
    {
        public PizzaDeCancha(string descripcion)
        {
            this.Descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"Esta es una pizza de tipo : {this.Descripcion}";
        }
    }
}
