using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Observer
{
    public class Subject
    {
        private List<Observador> listaObservadores = new List<Observador>();
        private double estado;

        public double Estado
        {
            get { return this.estado; }
            set 
            {  
                this.estado = value;
                notificarTodosObservadores();
            }
        }

        public void agregar(Observador observer)
        {
            listaObservadores.Add(observer);
        }

        public void notificarTodosObservadores()
        {
            foreach (Observador ob in listaObservadores)
            {
                ob.actualizar();
            }
        }
    }
}
