using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Dao.Model
{
    //aqui declaro una clase que me va a servir de modelo para este ejemplo
    public class Persona
    {
        private string nombre;
        private int id;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        public Persona() { }
        public Persona(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
