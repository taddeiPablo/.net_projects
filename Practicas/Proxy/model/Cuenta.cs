using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Proxy.model
{
    // aqui declara una clase que era nuestro modelo central para este ejemplo
    // este modelo tiene atributos y metodos necesarios para el ejemplo
    public class Cuenta
    {
        private int idcuenta;
        private string usuario;
        private double saldoInicial;

        public int IDCuenta
        {
            get { return this.IDCuenta; }
            set { this.idcuenta = value; }
        }
        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }
        public double SaldoInicial
        {
            get { return this.saldoInicial; }
            set { this.saldoInicial = value; }
        }
        public Cuenta(int idCuenta, string usuario, double saldoInicial )
        {
            this.idcuenta = idCuenta;
            this.usuario = usuario;
            this.saldoInicial = saldoInicial;
        }
    }
}
