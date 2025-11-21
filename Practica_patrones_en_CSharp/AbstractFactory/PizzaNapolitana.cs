using System;
using System.Collections.Generic;
using System.Text;

using Practica_patrones_en_CSharp.AbstractFactory.AbstractClasses;

namespace Practica_patrones_en_CSharp.AbstractFactory
{
    public class PizzaNapolitana: Pizza
    {
        public PizzaNapolitana()
        {
            this.Descripcion = "Pizza Napolitana";
        }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
