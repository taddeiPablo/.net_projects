using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Decorator
{
    public class CafeDescafeinado : BebidaComponent
    {
        public override double Costo => 15;

        public override string descripcion => "Cafe Decafeinado";
    }
}
