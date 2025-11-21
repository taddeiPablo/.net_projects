using System;
using System.Collections.Generic;
using System.Text;

using Practicas.Command.Interface;

namespace Practicas.Command.commands
{
    // aqui creamos una clase RetirarImpl en la cual implementamos la Interface IOperation
    // esta clase la utilizaremos como commando
    public class RetirarImpl : IOperation
    {

        private Cuenta cuenta;
        private double monto;

        // constructor
        public RetirarImpl(Cuenta cuenta, double monto)
        {
            this.cuenta = cuenta;
            this.monto = monto;
        }
        // implementamos el metodo de la interface IOperator
        public void execute()
        {
            this.cuenta.retirar(monto);
        }
    }
}
