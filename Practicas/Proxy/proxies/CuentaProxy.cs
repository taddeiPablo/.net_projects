using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Proxy.Interface;
using Practicas.Proxy.model;
using Practicas.Proxy.implementacion;

namespace Practicas.Proxy.proxies
{
    // finalmente creo una clase de tipo cuentaProxy que tambien implementara la interface de tipo Icuenta
    // pero a su vez ara referencia a la clase que implementa tambien la interface pero en donde se realiza la logica de negocio
    // nota : esto tambien se podria hacer por parametro por el constructor para darle mayor flexibilidad y no tener que 
    // dejar este proxy atado a una sola implementacion sino multiples
    public class CuentaProxy : ICuenta
    {
        private CuentaBancoAImpl cBancoAImpl;
        private Cuenta result;

        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            try
            {
                if (cBancoAImpl == null)
                {
                    cBancoAImpl = new CuentaBancoAImpl();
                    result = cBancoAImpl.depositarDinero(cuenta, monto);
                }
                else
                {
                    result = cBancoAImpl.depositarDinero(cuenta, monto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        public void mostrarSaldo(Cuenta cuenta)
        {
            if (cBancoAImpl == null)
            {
                cBancoAImpl = new CuentaBancoAImpl();
                cBancoAImpl.mostrarSaldo(cuenta);
            }
            else
            {
                cBancoAImpl.mostrarSaldo(cuenta);
            }
        }
        public Cuenta retirardinero(Cuenta cuenta, double monto)
        {
            try
            {
                if (cBancoAImpl == null)
                {
                    cBancoAImpl = new CuentaBancoAImpl();
                    result = cBancoAImpl.retirardinero(cuenta, monto);
                }
                else
                {
                    result = cBancoAImpl.retirardinero(cuenta, monto);
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
