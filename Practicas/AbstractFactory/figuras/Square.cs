using System;
using System.Collections.Generic;
using System.Text;
using Practicas.AbstractFactory.Interface;

namespace Practicas.AbstractFactory.figuras
{
    // aqui declaro una clase Square que implementa la interface IShape
    // con esta clase crearemos un objecto del tipo Square
    public class Square : IShape
    {
        // implementamos el metodo draw que nos otorga la interface
        public void draw()
        {
            Console.WriteLine("Esta es una figura de tipo cuadrado");
        }
    }
}
