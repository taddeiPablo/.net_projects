using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Factory.Interface;

namespace Practicas.Factory.conexiones
{
    // clase que implementa la Interface IConexiones
    // implementamos este comportamiento
    // con las demas clases es igual
    public class ConexionADefinir : IConexiones
    {
        // implementamos el metodo conectar
        public string Conectar()
        {
            return "Se establecio la conexion a la base definida !!!!";
        }

        // implementamos el metodo desconectar
        public string Desconectar()
        {
            return "se desconecto correctamente !!!!";
        }
    }
}
