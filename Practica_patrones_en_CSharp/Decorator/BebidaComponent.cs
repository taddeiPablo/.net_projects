using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Decorator
{
    public abstract class BebidaComponent
    {
        public abstract double Costo { get; }
        public abstract string descripcion { get; }
    }
}
