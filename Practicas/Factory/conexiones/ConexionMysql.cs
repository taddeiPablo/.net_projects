using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Factory.Interface;

namespace Practicas.Factory.conexiones
{
    public class ConexionMysql : IConexiones
    {
        public string Conectar()
        {
            return "Se establecio la conexion en mysql correctamente !!!!";
        }

        public string Desconectar()
        {
            return "Se desconecto de manera correcta !!!";
        }
    }
}
