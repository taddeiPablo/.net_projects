using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class Dueño
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string domicilio;
        private Vehiculo vehiculo;

        public Vehiculo Vehiculo
        {
            get => this.vehiculo;
            set => this.vehiculo = value;
        }
        public string Nombre
        {
            get => this.nombre;
            set => this.nombre = value;
        }
        public string Apellido
        {
            get => this.apellido;
            set => this.apellido = value;
        }
        public string Dni
        {
            get => this.dni;
            set => this.dni = value;
        }
        public string Domicilio
        {
            get => this.domicilio;
            set => this.domicilio = value;
        }

        public Dueño(string nombre, string apellido, string dni, string domicilio)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.domicilio = domicilio;
        }
    }
}
