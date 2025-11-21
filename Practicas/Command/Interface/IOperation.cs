using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Command.Interface
{
    //Command
    // aqui declaro esta interface que solo va a tener un metodo execute que se utilizara para 
    // ejecutar los distintos comando que sean requeridos
    public interface IOperation
    {
        void execute();
    }
}
