using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Observer.Interface
{
    public interface ISujetoProducto
    {
        void agregar(IObserverUsuario usr);
        void quitar(IObserverUsuario usr);
        void notificar();
    }
}
