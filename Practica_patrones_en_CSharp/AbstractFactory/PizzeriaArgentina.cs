using System;
using System.Collections.Generic;
using System.Text;

using Practica_patrones_en_CSharp.AbstractFactory.AbstractClasses;

namespace Practica_patrones_en_CSharp.AbstractFactory
{
    public class PizzeriaArgentina : Pizzeria
    {
        public override Pizza crearPizza()
        {
            return new PizzaDeCancha();
        }
    }
}
