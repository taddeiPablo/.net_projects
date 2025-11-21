using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practicas.Strategy
{
    public class AntivirusAvanzado : AnalisisAvanzado
    {
        public override void analizarMemoria()
        {
            Console.WriteLine("analisis de memoria a comenzado");
            Thread.Sleep(500);
            Console.WriteLine("analisis de memoria finalizado");
        }

        public override void detener()
        {
            Console.WriteLine("analiziz avanzado terminado");
        }

        public override void iniciar()
        {
            Console.WriteLine("comenzando el analisis avanzado");
        }

        public override void saltarZip()
        {
            Console.WriteLine("aqui analizando archivos zip en profundidad");
            Thread.Sleep(2500);
            Console.WriteLine("analisis de archivos zip finalizado");
        }
    }
}
