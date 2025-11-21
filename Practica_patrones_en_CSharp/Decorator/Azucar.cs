using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Decorator
{
    public class Azucar : AgregadoDecorator
    {
        public Azucar(BebidaComponent bebida) : base(bebida)
        {
            //
        }
        public override double Costo => _bebida.Costo + 2;
        public override string descripcion => string.Format($"{_bebida.descripcion}, con azucar");
    }
}
