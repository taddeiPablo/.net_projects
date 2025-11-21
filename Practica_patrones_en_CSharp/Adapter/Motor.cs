using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Adapter
{
    // aqui declaro una clase abstract como clase base para esta herencia
    // esta tendra 4 tipos de comportamiento comunes a las demas clases
    public abstract class Motor
    {
        public abstract void acelerar();
        public abstract void apagar();
        public abstract void arrancar();
        public abstract void cargarCombustible();
    }
}
