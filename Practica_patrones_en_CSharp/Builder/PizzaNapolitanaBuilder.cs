using System;
using System.Collections.Generic;
using System.Text;
using Practica_patrones_en_CSharp.Builder.Core;

namespace Practica_patrones_en_CSharp.Builder
{
    public class PizzaNapolitanaBuilder : PizzaBuilder
    {
        public PizzaNapolitanaBuilder()
        {
            this.descripcion = "NAPO";
        }

        public override Agregados BuildAgregado()
        {
            return new Oregano();
        }

        public override Masa BuildMasa()
        {
            return new Almolde();
        }

        public override Salsa BuildSalsa()
        {
            return new SalsaDeTomate();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
