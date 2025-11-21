using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Prototype.Interface
{
    // aqui creamos esta interface e implementamos la interface ICloneable 
    // para poder realizar la tarea esperada de clonar nuestros objectos 
    public interface ICuenta: ICloneable
    {
        // declaramos la firma de este metodo clonar el cual simplemente nos devuelve un tipo ICuenta
        // es el mismo tipo de la interface
        ICuenta clonar();
    }
}
