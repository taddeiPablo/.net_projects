using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Composite
{
    public abstract class Componente
    {
        string _nombre;

        public Componente(string nombre)
        {
            this._nombre = nombre;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public abstract void agregarHijo(Componente componente);
        public abstract IList<Componente> obtenerHijos();
        public abstract int ObtenerTamaño { get; }
    }
}
