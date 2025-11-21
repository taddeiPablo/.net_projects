using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Decorator.claseAbstract;
using Practicas.Decorator;
using Practicas.Decorator.Interfaces;
using Practicas.Decorator.figuras;
namespace Practicas.Decorator
{
    // aqui declaro una clase que hereda de la clase abstract creada anteriormente
    // recibimos por constructor una figura Ishape que es una interface
    // y luego pasamos este parametro al constructor de la clase base
    public class RedShapeDecorator : ShapeDecorator
    {
        // constructor de la clase RedShapeDecorator
        // y llamado al constructor de la clase base
        public RedShapeDecorator(IShape figura):base(figura)
        {
        }

        // aqui en este metodo seteo el nuevo color para nuestro color
        // en este caso rojo
        public void setNewColor(string nuevoColor)
        {
            // TODO : aqui evaluo que tipo de valor tiene this.shape
            // si es del tipo circle, para luego poder castear el valor y poder modificar su variable
            if (this.shape.GetType() == typeof(Circle))
            {
                // casting
                Circle circle = (Circle)this.shape;
                circle.color = nuevoColor;
                this.shape = circle;
            }
        }
    }
}
