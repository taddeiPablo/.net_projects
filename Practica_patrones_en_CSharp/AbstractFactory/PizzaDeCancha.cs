using System;
using System.Collections.Generic;
using System.Text;

using Practica_patrones_en_CSharp.AbstractFactory.AbstractClasses;

namespace Practica_patrones_en_CSharp.AbstractFactory
{
    public class PizzaDeCancha: Pizza
    {
        public PizzaDeCancha()
        {
            this.Descripcion = "Pizza de Cancha";
        }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
