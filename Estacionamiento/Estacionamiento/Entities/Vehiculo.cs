using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public enum TipoVehiculo
    {
        Auto,
        Moto,
        Camion
    }

    public abstract class Vehiculo
    {
        protected string _modelo;
        protected string _marca;
        protected string _patente;
        protected string _año;
        protected int _puertas;
        protected int _ruedas;

        public abstract string Modelo
        {
            set;
            get;
        }

        public abstract string Marca
        {
            set;
            get;
        }

        public abstract string Patente
        {
            set;
            get;
        }

        public abstract string Año
        {
            set;
            get;
        }

        public abstract int Puertas
        {
            set;
            get;
        }

        public abstract int Ruedas
        {
            set;
            get;
        }

        public abstract void SetRuedas(int ruedas);

        public virtual void SetPuertas(int puertas)
        {
            this._puertas = puertas;
        }

        public Vehiculo(string modelo, string marca, string patente, string año)
        {
            this._modelo = modelo;
            this._marca = marca;
            this._patente = patente;
            this._año = año;
        }
    }
}
