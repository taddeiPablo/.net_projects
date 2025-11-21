using System;
using System.Collections.Generic;
using System.Text;
using Practicas.AbstractFactory.Interface;

namespace Practicas.AbstractFactory.figuras
{
    // aqui declaro una clase Rectangle que implementa la interface IShape
    // con esta clase crearemos un objecto del tipo Rectangle
    public class Rectangle : IShape
    {
        // implementamos el metodo draw que nos otorga la interface
        public void draw()
        {
            Console.WriteLine("Esta es una figura de tipo Rectangulo");
        }
    }
}
