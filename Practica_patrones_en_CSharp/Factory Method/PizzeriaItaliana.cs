using System;
using System.Collections.Generic;
using System.Text;

using Practica_patrones_en_CSharp.Factory_Method.AbstractClasses;

namespace Practica_patrones_en_CSharp.Factory_Method
{
    public class PizzeriaItaliana : Pizzeria
    {
        public override Pizza crearPizza(string tipoPizza)
        {
            if (tipoPizza == "cancha")
            {
                return new PizzaDeCancha("italiana");
            }else if(tipoPizza == "Napo")
            {
                return new PizzaNapolitana("italiana");
            }
            else
            {
                return null;
            }
        }
    }
}
