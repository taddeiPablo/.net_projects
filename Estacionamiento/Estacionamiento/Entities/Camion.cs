using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class Camion : Vehiculo
    {
        private Dueño dueño;

        public Dueño Dueño
        {
            get => this.dueño;
            set => this.dueño = value;
        }
        public override string Modelo
        {
            get => base._modelo;
            set => base._modelo = value;
        }
        public override string Marca
        {
            get => base._marca;
            set => base._marca = value;
        }
        public override string Patente
        {
            get => base._patente;
            set => base._patente = value;
        }
        public override string Año
        {
            get => base._año;
            set => base._año = value;
        }
        public override int Puertas
        {
            get => base._puertas;
            set => base._puertas = value;
        }
        public override int Ruedas
        {
            get => base._ruedas;
            set => base._ruedas = value;
        }

        public override void SetRuedas(int ruedas)
        {
            base._ruedas = ruedas;
        }

        public Camion(string modelo, string marca, string patente, string año) 
            : base(modelo,marca,patente,año)
        {

        }
    }
}
