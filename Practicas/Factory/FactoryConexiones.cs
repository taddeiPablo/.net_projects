using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Factory.Interface;
using Practicas.Factory.conexiones;

namespace Practicas.Factory
{
    // creacion de esta clase que nos servira como factory y nos devovera las instancias requerida de 
    // conexion
    public class FactoryConexiones
    {
        // creamos una variable de tipo IConexiones
        private IConexiones conexiones;

        // metodo de tipo getConexion nos retornara la instancia de conexion segun el tipo
        public IConexiones getConexion(string tipo)
        {
            // aqui si no determinamos la conexion nos devuelve una a definir
            if (tipo == string.Empty || tipo == null)
            {
                conexiones = new ConexionADefinir();
            }
            // nos devuelve una conexion de tipo sql
            if (tipo == "sql")
            {
                conexiones = new ConexionSQL();
            }
            // nos devuelve una conexion de tipo mysql
            if (tipo == "mysql")
            {
                conexiones = new ConexionMysql();
            }
            // aqui devovemos el tipo de conexion requerida
            return conexiones;
        }
    }
}
