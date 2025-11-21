using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Strategy
{
    public abstract class AnalisisAvanzado : IEstrategia
    {
        public void analizar()
        {
            iniciar();
            analizarMemoria();
            saltarZip();
            detener();
        }
        public abstract void iniciar();
        public abstract void analizarMemoria();
        public abstract void saltarZip();
        public abstract void detener();
    }
}
