using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Builder.Core
{
    public abstract class Masa
    {
        private string descripcion;
        protected string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
