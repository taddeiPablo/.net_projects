using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Facade.apis
{
    public class HotelesApi
    {
        public void buscarHoteles(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            Console.WriteLine("===============================================================");
            Console.WriteLine("Hotel encontrado para : ");
            Console.WriteLine(fechaIda);
            Console.WriteLine(fechaVuelta);
            Console.WriteLine(origen);
            Console.WriteLine(destino);
            Console.WriteLine("===============================================================");
        }
    }
}
