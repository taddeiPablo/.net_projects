using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Decorator.Interfaces
{
    // aqui declaro una interface que sera utilizada en toda la aplicacion
    // tanto en las clases que seran nuestras figuras y nuestra clase abstract 
    // y clases que hereden de la clase abstract
    public interface IShape
    {
        void draw();
    }
}
