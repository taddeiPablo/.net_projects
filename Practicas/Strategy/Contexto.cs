using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Strategy
{
    public class Contexto
    {
        private IEstrategia estrategia;

        public Contexto(IEstrategia estrategia)
        {
            this.estrategia = estrategia;
        }
        public void ejecutar()
        {
            this.estrategia.analizar();
        }
    }
}
