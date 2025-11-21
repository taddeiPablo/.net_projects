using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Observer
{
    public abstract class Observador
    {
        protected Subject sujeto;
        public abstract void actualizar();
    }
}
