using System;
using System.Collections.Generic;
using System.Text;
using Practicas.AbstractFactory.Interface;
using Practicas.AbstractFactory.figuras;

namespace Practicas.AbstractFactory
{
    // aqui creamos una clase que implementa la interface de tipo IAbstractFactory 
    // en esta fabrica creamos objetos de tipo figuras geometricas y las devolvemos
    public class ShapeFactory : IAbstractFactory
    {
        // aqui declaro una variable del tipo shape
        private IShape shape;

        // aqui este metodo debemos implementarlo de todas maneras aunque no lo utilizaremos en esta 
        // factory ya que solo lo utilizaremos en el factory de colores
        public IColor getColor(string color)
        {
            throw new NotImplementedException();
        }

        // aqui en este metodo recibimos un nombre de figura geometrica
        public IShape getShape(string figura)
        {
            if (figura == "circle")
            {
                // aqui instaciamos un tipo circulo
                shape = new Circle();
            }
            if (figura == "square")
            {
                // aqui instanciamos un tipo cuadrado
                shape = new Square();
            }
            if (figura == "rectangle")
            {
                // aqui instanciamos un tipo rectangulo
                shape = new Rectangle();
            }
            // aqui devolvemos una figura instanciada
            return shape;
        }
    }
}
