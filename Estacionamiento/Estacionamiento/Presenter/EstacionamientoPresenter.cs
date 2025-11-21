using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Models;
using Estacionamiento.View;
using Estacionamiento.Entities;

namespace Estacionamiento.Presenter
{
    public class EstacionamientoPresenter
    {
        private EstacionamientoModel emodel;
        private Iinformation info;

        public EstacionamientoPresenter(Iinformation info)
        {
            this.emodel = new EstacionamientoModel();
            this.info = info;
        }

        public void Load_combo()
        {
            this.info.Load_combo();
        }

        public void guardar(string date, string nombreEstacionamiento, string[] dueño, string[] vehiculo, TipoVehiculo tipo)
        {
            if(this.emodel.nuevaEntrada(date, nombreEstacionamiento, dueño, vehiculo, tipo))
            {
                this.info.Refresh_data(this.emodel.Get_Estacionamiento);
            }
        }
        
    }
}
