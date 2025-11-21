using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Composite
{
    public class Directorio : Componente
    {
        // relacion de a muchos con Componente
        private List<Componente> _listadeComponentes;

        public Directorio(string nombre) : base(nombre)
        {
            _listadeComponentes = new List<Componente>();
        }
        public override int ObtenerTamaño
        {
            get
            {
                int t = 0;
                foreach (var item in _listadeComponentes)
                {
                    t += item.ObtenerTamaño;
                }
                return t;
            }
        }
        public override void agregarHijo(Componente componente)
        {
            _listadeComponentes.Add(componente);
        }
        public override IList<Componente> obtenerHijos()
        {
            return _listadeComponentes.ToArray();
        }
    }
}
