using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Proxy.model;

namespace Practicas.Proxy.Interface
{
    // aqui crear una interface necesaria para crear este patron
    public interface ICuenta
    {
        // declaro tres metodos que vamos a utilizar (depositar, retirar y mostrar)
        Cuenta retirardinero(Cuenta cuenta, double monto);
        Cuenta depositarDinero(Cuenta cuenta, double monto);
        void mostrarSaldo(Cuenta cuenta);

    }
}
