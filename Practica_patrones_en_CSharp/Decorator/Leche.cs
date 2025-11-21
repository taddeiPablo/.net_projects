using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Decorator
{
    public class Leche : AgregadoDecorator
    {
        public Leche(BebidaComponent bebida) : base(bebida)
        {
            // aqui contructor propio de la clase leche
        }
        public override double Costo => _bebida.Costo + 2;
        public override string descripcion => string.Format($"{_bebida.descripcion}, Leche");
    }
}
