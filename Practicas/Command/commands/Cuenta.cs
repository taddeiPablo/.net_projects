using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Command.commands
{
    // aqui declaro la clase cuenta que sera utilizada
    // como modelo para este ejemplo
    public class Cuenta
    {
        private int idcuenta;
        private double saldo;

        public Cuenta(double saldo, int id)
        {
            this.idcuenta = id;
            this.saldo = saldo;
        }

        // tendra un metodo retirar
        public void retirar(double monto)
        {
            this.saldo = this.saldo - monto;
        }

        // tendra un metodo depositar
        public void depositar(double monto)
        {
            this.saldo = this.saldo + monto;
        }
    }
}
