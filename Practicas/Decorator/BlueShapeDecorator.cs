using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Decorator;
using Practicas.Decorator.Interfaces;
using Practicas.Decorator.figuras;
using Practicas.Decorator.claseAbstract;

namespace Practicas.Decorator
{
    public class BlueShapeDecorator: ShapeDecorator
    {
        public BlueShapeDecorator(IShape figura) : base(figura) 
        {
        }

        public void setNewColor(string nuevocolor)
        {
            if (this.shape.GetType() == typeof(Circle))
            {
                Circle circle = (Circle)this.shape;
                circle.color = nuevocolor;
                this.shape = circle;
            }
        }
    }
}
