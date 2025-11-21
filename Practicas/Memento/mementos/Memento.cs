using System;
using System.Collections.Generic;
using System.Text;

using Practicas.Memento.mementos;

namespace Practicas.Memento.mementos
{
    // aqui declaro una clase Memento que nos ayudara para guardar y recuperar el estado 
    // de operacion de nuestro juego
    public class Memento
    {
        private Juego juego;

        public Memento(Juego j)
        {
            this.juego = j;
        }

        public Juego getEstado()
        {
            return juego;
        }
    }
}
