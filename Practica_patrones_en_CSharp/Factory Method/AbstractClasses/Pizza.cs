using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Factory_Method.AbstractClasses
{
    public abstract class Pizza
    {
        private string descripcion;
        protected string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
