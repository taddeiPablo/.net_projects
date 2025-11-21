using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Memento.mementos;
namespace Practicas.Memento.mementos
{
    //aqui declaro esta clase que nos ayudara a contener una lista de mementos
    // por la cual podremos ir recuperando los estados guardados
    public class CareTaker
    {
        private List<Memento> listadoMemento = new List<Memento>();

        public void addMemento(Memento me)
        {
            listadoMemento.Add(me);
        }

        public Memento getMemento(int index)
        {
            return listadoMemento[index];
        }
    }
}
