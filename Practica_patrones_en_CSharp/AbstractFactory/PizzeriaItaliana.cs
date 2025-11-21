using System;
using System.Collections.Generic;
using System.Text;

using Practica_patrones_en_CSharp.AbstractFactory.AbstractClasses;

namespace Practica_patrones_en_CSharp.AbstractFactory
{
    class PizzeriaItaliana : Pizzeria
    {
        public override Pizza crearPizza()
        {
            return new PizzaNapolitana();
        }
    }
}
