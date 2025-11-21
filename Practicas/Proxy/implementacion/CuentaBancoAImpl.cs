using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Proxy.Interface;
using Practicas.Proxy.model;

namespace Practicas.Proxy.implementacion
{
    // aqui declaro esta clase que implementa la interface de tipo Icuenta 
    // esta clase es declarada para poder implementar la interface y sus metodos
    public class CuentaBancoAImpl : ICuenta
    {
        // implementamos el metodo depositar de la interface
        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            double saldoActual = cuenta.SaldoInicial + monto;
            cuenta.SaldoInicial = saldoActual;
            return cuenta;
        }

        // implementamos el metodo mostrarSaldo de la interface
        public void mostrarSaldo(Cuenta cuenta)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("Nombre Cliente :" + cuenta.Usuario);
            Console.WriteLine("Saldo : " + cuenta.SaldoInicial);
            Console.WriteLine("===============================================");
        }

        // implementamos el metodo retirar de la interface
        public Cuenta retirardinero(Cuenta cuenta, double monto)
        {
            double saldoActual = cuenta.SaldoInicial - monto;
            cuenta.SaldoInicial = saldoActual;
            return cuenta;
        }
    }
}
