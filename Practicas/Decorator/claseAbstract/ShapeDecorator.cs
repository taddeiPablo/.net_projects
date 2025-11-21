using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Decorator.Interfaces;

namespace Practicas.Decorator.claseAbstract
{
    // aqui declaro una clase abstract que implementa una interface IShape
    // esta clase nos srive para poder modificar los valores de nuestro objecto
    // circle.
    public abstract class ShapeDecorator : IShape
    {
        // aqui declaro una variable de tipo IShape
        protected IShape shape;

        // constructor que recibe un tipo IShape
        public ShapeDecorator(IShape figura)
        {
            this.shape = figura;
        }

        // implemento el metodo que viene de la interface IShape
        public void draw()
        {
            this.shape.draw();
        }
    }
}
