using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Composite
{
    public class Archivo : Componente
    {
        int _tamaño;

        public Archivo(string nombre, int tam) : base(nombre)
        {
            Tamaño = tam;
        }

        public override int ObtenerTamaño
        {
            get
            {
                return _tamaño;
            }
        }
        public int Tamaño { get => _tamaño; set => _tamaño = value; }

        public override void agregarHijo(Componente componente)
        {
            throw new NotImplementedException();
        }

        public override IList<Componente> obtenerHijos()
        {
            throw new NotImplementedException();
        }
    }
}
