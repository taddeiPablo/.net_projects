using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Decorator.Interfaces;

namespace Practicas.Decorator.figuras
{
    // aqui declaro la clase circle que implementara una interface Ishape
    public class Circle : IShape
    {
        // aqui creo una variable de tipo color
        public string color;

        // constructor
        public Circle()
        {
            // seteo el color por defecto
            color = "AZUL";
        }

        // implementamos el metodo draw que nos viene de la interface
        public void draw()
        {
            // aqui mostramos el color de nuestra figura
            Console.WriteLine("COLOR ACTUAL : "+ color);
        }
    }
}
