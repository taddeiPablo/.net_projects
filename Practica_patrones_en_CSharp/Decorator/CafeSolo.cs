using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Decorator
{
    public class CafeSolo : BebidaComponent
    {
        public override double Costo => 10;

        public override string descripcion => "Cafe Solo";
    }
}
