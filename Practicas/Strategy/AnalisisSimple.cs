using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Strategy
{
    public abstract class AnalisisSimple : IEstrategia
    {
        public void analizar()
        {
            iniciar();
            saltarZip();
            detener();
        }
        public abstract void iniciar();
        public abstract void saltarZip();
        public abstract void detener();
    }
}
