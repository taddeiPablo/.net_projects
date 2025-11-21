using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Decorator
{
    public abstract class AgregadoDecorator: BebidaComponent
    {
        protected BebidaComponent _bebida;

        public AgregadoDecorator(BebidaComponent bebida)
        {
            _bebida = bebida;
        }
    }
}
