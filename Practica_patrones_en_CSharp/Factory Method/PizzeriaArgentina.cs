using System;
using System.Collections.Generic;
using System.Text;

using Practica_patrones_en_CSharp.Factory_Method.AbstractClasses;

namespace Practica_patrones_en_CSharp.Factory_Method
{
    public class PizzeriaArgentina : Pizzeria
    {
        public override Pizza crearPizza(string tipoPizza)
        {
            if (tipoPizza == "cancha")
            {
                return new PizzaDeCancha("Argentina");
            }else if(tipoPizza == "napo")
            {
                return new PizzaNapolitana("Argentina");
            }
            else
            {
                return null;
            }
        }
    }
}
