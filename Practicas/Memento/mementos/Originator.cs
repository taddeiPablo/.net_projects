using System;
using System.Collections.Generic;
using System.Text;

using Practicas.Memento.mementos;

namespace Practicas.Memento.mementos
{
    public class Originator
    {
        private Juego juego;

        public Juego Juego
        {
            get { return this.Juego; }
            set { this.juego = value; }
        }
        
        public Memento guardar()
        {
            return new Memento(this.juego);
        }

        public void restaurar(Memento e)
        {
            this.juego = e.getEstado();
        }

    }
}
