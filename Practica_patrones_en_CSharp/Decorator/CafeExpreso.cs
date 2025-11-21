using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Decorator
{
    public class CafeExpreso : BebidaComponent
    {
        public override double Costo => 12;

        public override string descripcion => "Cafe Expreso";
    }
}
