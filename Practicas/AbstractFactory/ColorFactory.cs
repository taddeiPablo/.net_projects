using System;
using System.Collections.Generic;
using System.Text;
using Practicas.AbstractFactory.colores;
using Practicas.AbstractFactory.Interface;

namespace Practicas.AbstractFactory
{
    // aqui creamos una clase que implementa la interface de tipo IAbstractFactory 
    // en esta fabrica creamos objetos de tipo Icolor para devolver un tipo de color y las devolvemos
    public class ColorFactory : IAbstractFactory
    {
        // aqui declaro una variable de tipo Icolor
        private IColor colores;

        // aqui en este metodo recibe un tipo de color
        public IColor getColor(string color)
        {
            if (color == "red")
            {
                // aqui instanciamos un tipo de color red
                colores = new Red();
            }
            if(color == "green")
            {
                // aqui instanciamos un tipo de color green
                colores = new Green();
            }
            if (color == "blue")
            {
                // aqui instanciamos un tipo de color Blue
                colores = new Blue();
            }
            // aqui retornamos un tipo Icolor
            return colores;
        }
        // este metodo lo implementamos pero en esta factory no lo utilizamos ya que solo lo utilizamos 
        // en el factory de shape
        public IShape getShape(string figura)
        {
            throw new NotImplementedException();
        }
    }
}
