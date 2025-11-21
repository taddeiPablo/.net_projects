using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Factory.Interface;

namespace Practicas.Factory.conexiones
{
    public class ConexionSQL : IConexiones
    {
        public ConexionSQL()
        {

        }
        public string Conectar()
        {
            return "se establecio la conexion a SQL correctamente !!!!";
        }

        public string Desconectar()
        {
            return "se desconecto correctamente !!!!";
        }
    }
}
