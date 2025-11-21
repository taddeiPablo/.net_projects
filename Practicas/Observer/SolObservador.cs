using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Observer
{
    public class SolObservador : Observador
    {

        private double valorCambio = 3.80;

        public SolObservador(Subject sujeto)
        {
            this.sujeto = sujeto;
            this.sujeto.agregar(this);
        }

        public override void actualizar()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("SOL PERUANO : " + (sujeto.Estado * valorCambio));
            Console.WriteLine("----------------------------------------------");
        }
    }
}
