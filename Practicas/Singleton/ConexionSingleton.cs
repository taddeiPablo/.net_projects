using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Singleton
{
    public class ConexionSingleton
    {
        private static ConexionSingleton instance;
        private string mensaje = string.Empty;

        private ConexionSingleton()
        {
            // constructor private, realiza la misma funcion que un constructor publico
            // instancia un object a partir de esta clase pero no es visible desde afuera 
            // ya que solo lo utilizaremos en getInstance para crear el objecto una unica vez 
        }

        // metodo por el cual vamos a consultar la instancia de esta clase el objeto
        public static ConexionSingleton getInstance()
        {
            if (instance == null)
            {
                instance = new ConexionSingleton();
            }
            return instance;
        }

        public string mensage()
        {
            mensaje = "Hola esto es un ejemplo de patron singleton !!!";
            return mensaje;
        }
    }
}
