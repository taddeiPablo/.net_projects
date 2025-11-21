using System;
using System.Collections.Generic;
using System.Text;
using Practica_patrones_en_CSharp.Observer.Interface;

namespace Practica_patrones_en_CSharp.Observer
{
    public class Producto : ISujetoProducto
    {
        private List<IObserverUsuario> _usuarios;
        private string _nombre;
        private double _precio;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { 
            get => _precio;
            set
            {
                _precio = value;
                this.notificar();
            }
        }

        public Producto(string nombre, double precio)
        {
            _usuarios = new List<IObserverUsuario>();
            Nombre = nombre;
            Precio = precio;
        }

        public void agregar(IObserverUsuario usr)
        {
            if (!_usuarios.Contains(usr))
            {
                _usuarios.Add(usr);
            }
            else
            {
                Console.WriteLine("este usuario ya existe");
            }
        }

        public void quitar(IObserverUsuario usr)
        {
            if (!_usuarios.Contains(usr))
            {
                _usuarios.Remove(usr);
            }
            else
            {
                Console.WriteLine("no existe una subcripcion para este usuario");
            }
        }

        public void notificar()
        {
            foreach (var usuario in _usuarios)
            {
                usuario.actualizar(this);
            }

            if (_usuarios.Count == 0)
            {
                Console.WriteLine("NO EXISTEN SUBSCRIPCIONES PARA ESTE PRODUCTO");
            }
        }
    }
}
