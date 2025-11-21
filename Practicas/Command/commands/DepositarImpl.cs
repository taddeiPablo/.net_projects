using System;
using System.Collections.Generic;
using System.Text;

using Practicas.Command.Interface;

namespace Practicas.Command.commands
{
    // aqui declaro una clase del tipo depositarImpl
    // la cual utilizaremos como commando y ademas implementamos la interface IOperation
    public class DepositarImpl : IOperation
    {
        private Cuenta cuenta;
        private double monto;

        // constructor que recibe la cuenta y el monto de la misma
        public DepositarImpl(Cuenta cuenta, double monto)
        {
            this.cuenta = cuenta;
            this.monto = monto;
        }

        // aqui implementamos el metodo de la interfaz execute
        public void execute()
        {
            this.cuenta.depositar(monto);
        }
    }
}
