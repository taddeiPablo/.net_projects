using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.AbstractFactory.Interface
{
    // aqui declaro esta interface la cual utilizaremos 
    // para la creacion de fabricas, las clases que implementen esta 
    // interface seran fabricas.
    public interface IAbstractFactory
    {
        IShape getShape(string figura);
        IColor getColor(string color);
    }
}
