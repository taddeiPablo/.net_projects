using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Adapter
{
    // aqui declaro una clase del tipo motosNaftero la cual hereda de Motor y 
    // a lo mismo que motorDiesel se deberan implementar los metodos heredados de la clase base ya que 
    // estos metodos son abstractos al igual que la clase base
    public class MotorNaftero : Motor
    {
        public override void acelerar()
        {
            throw new NotImplementedException();
        }

        public override void apagar()
        {
            throw new NotImplementedException();
        }

        public override void arrancar()
        {
            throw new NotImplementedException();
        }

        public override void cargarCombustible()
        {
            throw new NotImplementedException();
        }
    }
}
