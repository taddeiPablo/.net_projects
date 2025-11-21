using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Adapter
{
    // aqui declaro la clase MotorElectricoAdapter el cual hereda de la clase base Motor
    // y implementara los metodos de esta clase base, ademas tendra una asociacion a la clase MotorElectrico
    // para poder llamar a sus metodos dentro de los metodos implementados de la clase base.
    // de esta manera podemos adaptar una clase distinta dentro de este modelo
    public class MotorElectricoAdapter : Motor
    {
        // aqui creamos una variable de MotorElectrico para luego crear la instancia de la misma
        // y poder utilizar sus metodos dentro de los metodos heredados de la clase base
        private MotorElectrico melectrico;
        public MotorElectricoAdapter()
        {
            melectrico = new MotorElectrico();
        }
        public override void acelerar()
        {
            melectrico.Mover();
        }

        public override void apagar()
        {
            melectrico.desactivar();
        }

        public override void arrancar()
        {
            melectrico.conectar();
            melectrico.Activar();
        }

        public override void cargarCombustible()
        {
            melectrico.enchufar();
        }
    }
}
