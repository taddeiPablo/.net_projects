using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Adapter
{
    // aqui declaro una clase de tipo motorDiesel que hereda de Motor
    // para implementar los metodos que trae la clase base que es abstracta y sus metodos tambien
    // por lo que deberemos implementar si o si
    public class MotorDiesel : Motor
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
