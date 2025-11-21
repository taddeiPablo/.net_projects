using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Factory_Method.AbstractClasses
{
    public abstract class Pizzeria
    {
        public abstract Pizza crearPizza(string tipoPizza);
    }
}
