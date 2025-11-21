using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Entities;

namespace Estacionamiento.Models
{
    public class EstacionamientoModel
    {
        private Dictionary<Entities.Ticket, Entities.Dueño> EstacionamientoDic;
        private Ticket ticket;
        private Dueño dueño;
        private Vehiculo vehiculo;

        public Dictionary<Entities.Ticket, Entities.Dueño> Get_Estacionamiento
        {
            get => this.EstacionamientoDic;
            set => this.EstacionamientoDic = value;
        }

        public EstacionamientoModel()
        {
            this.EstacionamientoDic = new Dictionary<Ticket, Dueño>();
        }

        public bool nuevaEntrada(string date, string nombreEstacionamiento, string[] dueño, string[] vehiculo, TipoVehiculo tipo)
        {
            Random codigo = new Random();
            ticket = new Ticket(codigo.Next(), date, nombreEstacionamiento);
            string nombre = dueño[0];
            string apellido = dueño[1];
            string dni = dueño[2];
            string domicilio = dueño[3];
            this.dueño = new Dueño(nombre, apellido, dni, domicilio);
            switch (tipo)
            {
                case TipoVehiculo.Auto:
                    this.dueño.Vehiculo = new Auto(vehiculo[0], vehiculo[1], vehiculo[2], vehiculo[3]);
                    break;
                case TipoVehiculo.Moto:
                    this.dueño.Vehiculo = new Moto(vehiculo[0], vehiculo[1], vehiculo[2], vehiculo[3]);
                    break;
                case TipoVehiculo.Camion:
                    this.dueño.Vehiculo = new Camion(vehiculo[0], vehiculo[1], vehiculo[2], vehiculo[3]);
                    break;
                default:
                    break;
            }
            this.EstacionamientoDic.Add(ticket, this.dueño);
            return true;
        }


    }
}
