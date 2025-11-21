using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Builder.Core
{
    public class Pizza
    {
        private Masa masa;
        private Salsa salsa;
        private string tipo;
        private Agregados agregado;

        public Pizza(Masa masa, Salsa salsa, Agregados agregado, string tipo)
        {
            this.masa = masa;
            this.salsa = salsa;
            this.agregado = agregado;
            this.tipo = tipo;
        }

    }
}
