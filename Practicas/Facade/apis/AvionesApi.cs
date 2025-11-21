using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Facade.apis
{
    public class AvionesApi
    {
        public void buscarVuelos(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            Console.WriteLine("===============================================================");
            Console.WriteLine("vuelo encontrado para : ");
            Console.WriteLine(fechaIda);
            Console.WriteLine(fechaVuelta);
            Console.WriteLine(origen);
            Console.WriteLine(destino);
            Console.WriteLine("===============================================================");
        }
    }
}
