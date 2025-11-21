using System;
using System.Collections.Generic;
using System.Text;
using Practica_patrones_en_CSharp.Builder.Core;

namespace Practica_patrones_en_CSharp.Builder
{
    public abstract class PizzaBuilder
    {
        protected string descripcion;
        public abstract Masa BuildMasa();
        public abstract Salsa BuildSalsa();
        public abstract Agregados BuildAgregado();

        public Pizza buildPizza()
        {
            Masa masa = BuildMasa();
            Salsa salsa = BuildSalsa();
            Agregados agregado = BuildAgregado();

            return new Pizza(masa, salsa, agregado, descripcion);
        }
    }
}
