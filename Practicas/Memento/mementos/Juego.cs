using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Memento.mementos
{
    // aqui declaro una clase juego que utilizaremos como modelo para
    // nuestro ejemplo
    public class Juego
    {
        private string nombre;
        private int checkpoint;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int CheckPoint
        {
            get { return this.checkpoint; }
            set { checkpoint = value; }
        }

        public override string ToString()
        {
            return "el juego : Nombre : " + nombre + "CheckPoint :" + checkpoint;
        }
    }
}
