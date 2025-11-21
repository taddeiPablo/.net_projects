using System;
using System.Collections.Generic;
using System.Text;
using Practicas.AbstractFactory.Interface;

namespace Practicas.AbstractFactory
{
    // AQUI EN ESTA FABRICAPRODUCTO
    // aqui con esta clase hace de fabrica de fabricas de objetos
    public class FabricaProducto
    {
        // aqui creo una variable del tipo abstractFactory. Esta interface me permitira
        // definir las factories que podran ser instanciadas
        private IAbstractFactory absFactory;
        // este metodo recibe un tipo factory aqui determinamos que 
        // tipo de fabrica necesitamos crear
        public IAbstractFactory getFactory(string factory)
        {
            if (factory == "shape")
            {
                // se instancia una fabrica de tipo IAbstractFactory de nombre ShapeFactory(nos devolvera formas geometricas)
                absFactory = new ShapeFactory();
            }
            if(factory == "color")
            {
                // se instancia una fabrica de tipo IAbstractFactory de nombre ColorFactory(nos devolvera tipo de color)
                absFactory = new ColorFactory();
            }
            // retornamos un tipo IAbstractFactory
            return absFactory;
        }
    }
}
