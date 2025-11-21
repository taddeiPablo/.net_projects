using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practicas.Strategy
{
    public class AntivirusSimple : AnalisisSimple
    {
        public override void detener()
        {
            Console.WriteLine("antivirus simple a finalizado");
        }

        public override void iniciar()
        {
            Console.WriteLine("inicializando el analisis");

        }

        public override void saltarZip()
        {
            Console.WriteLine("Analizando zips");
            Thread.Sleep(2500);
            Console.WriteLine("no se puede analizar estos archivos");
        }
    }
}
