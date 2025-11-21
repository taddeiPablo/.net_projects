using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Observer
{
    public class PesoArgObservador: Observador
    {
        private double valorCambio = 178.14;


        public PesoArgObservador(Subject sujeto)
        {
            this.sujeto = sujeto;
            this.sujeto.agregar(this);
        }

        public override void actualizar()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("PESOS ARGENTINOS : " + (sujeto.Estado * valorCambio));
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
