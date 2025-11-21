using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Dao.conexiones;
using Practicas.Dao.Interface;

namespace Practicas.Dao.conexiones
{
    // aqui declaro una clase que implementara la interface de tipo Iconexiones
    // hagamos de cuenta que en este caso esta clase Conexion nos permite conectarnos a una base de datos
    // SQL SERVER, pero del mismo modo podriamos tener otra clase que implemente la misma interface y 
    // nos permita conectarnos a MYSQL SERVER
    public class Conexion: IConexiones
    {
        private string usuario;
        private string password;
        private string connection;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Connection { get => connection; set => connection = value; }
        public string Password { get => password; set => password = value; }

        public Conexion(string usuario, string conn, string password)
        {
            this.usuario = usuario;
            this.connection = conn;
            this.password = password;
        }

        public void conectar()
        {
            throw new NotImplementedException();
        }
    }
}
