using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Prototype.Interface;

namespace Practicas.Prototype
{
    // Creamos una clase llamada cuenta ademas implementamos la interface ICuenta 
    // luego implementamos los metodos clonar y clone de la interface, el metodo clonar
    // fue creado por nosotros y el clone es propio de la interface
    class CuentaAHImpl : ICuenta
    {
        private string tipo;
        private double monto;

        public double Monto
        {
            get { return this.monto; }
            set { this.monto = value; }
        }
        public CuentaAHImpl()
        {
            tipo = "AHORRO";
        }
        // aqui en el metodo clonar realizamos el clonado de esta cuenta
        public ICuenta clonar()
        {
            CuentaAHImpl cuenta = null;
            try
            {
                cuenta = (CuentaAHImpl)Clone();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cuenta;
        }
        // ATENCION : este metodo debemos implementarlo ya que es propio de la interface 
        // simplemente devolvemos la propia instancia con this.
        public object Clone()
        {
            return this;
        }
        // como dato de color sobreescribimos el metodo tostring
        public override string ToString()
        {
            return "CuentaAHImpl : su cuenta de ahorros ya esta abierta y funcionando";
        }
    }
}
