using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Facade.apis;

namespace Practicas.Facade.fachada
{
    public class CheckFacade
    {
        private AvionesApi vuelosApi;
        private HotelesApi hoteles_api;

        public CheckFacade()
        {
            vuelosApi = new AvionesApi();
            hoteles_api = new HotelesApi();
        }

        public void buscar(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            vuelosApi.buscarVuelos(fechaIda, fechaVuelta, origen, destino);
            hoteles_api.buscarHoteles(fechaIda, fechaVuelta, origen, destino);
        }
    }
}
