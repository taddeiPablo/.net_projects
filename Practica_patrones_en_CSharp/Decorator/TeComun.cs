using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Decorator
{
    public class TeComun : BebidaComponent
    {
        public override double Costo => 8;

        public override string descripcion => "Te Comun";
    }
}
