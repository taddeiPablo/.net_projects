using System;
using System.Collections.Generic;
using System.Text;
using Practicas.AbstractFactory.Interface;

namespace Practicas.AbstractFactory.colores
{
    // aqui creo una clase Blue la cual implementara la interface IColor
    // con esta clase crearemos un objecto del tipo Blue que en este ejemplo representara un color
    public class Red : IColor
    {
        // implmentamos el metodo fill que nos otorga la interface
        public void fill()
        {
            Console.WriteLine("se a creado el color ROJO");
        }
    }
}
