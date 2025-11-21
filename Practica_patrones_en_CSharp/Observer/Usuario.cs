using System;
using System.Collections.Generic;
using System.Text;

using Practica_patrones_en_CSharp.Observer.Interface;

namespace Practica_patrones_en_CSharp.Observer
{
    public class Usuario: IObserverUsuario
    {
        private string nombre;
        private string apellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public void actualizar(Producto product)
        {
            Console.WriteLine($"se actualizo el precio del producto : { product.Nombre}");
        }
    }
}
