using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Dao.Interface
{
    // aqui declaro la interface de tipo IConexiones esta interface tendra la funcion
    // que contener el comportamiento comun para una determinada conexion a base de datos
    // que luego sera determinada en sus implementanciones
    public interface IConexiones
    {
        void conectar();
    }
}
