using System;
using System.Collections.Generic;
using System.Text;

using Practicas.Command;
using Practicas.Command.Interface;

namespace Practicas.Command.commands
{
    // aqui creo una clase Invoker que sera la encargada de ejecutar los comandos que se 
    // van a ir juntando en una lista de comandos
    public class Invoker
    {
        private List<IOperation> listaOperaciones = new List<IOperation>();


        public void recibirOperaciones(IOperation operacion)
        {
            this.listaOperaciones.Add(operacion);
        }
        public void realizarOperaciones()
        {
            foreach (IOperation ope in this.listaOperaciones)
            {
                ope.execute();
            }
            this.listaOperaciones.Clear();
        }
    }
}
