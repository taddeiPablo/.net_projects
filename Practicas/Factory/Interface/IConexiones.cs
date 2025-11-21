using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Factory.Interface
{
    public interface IConexiones
    {
        string Conectar();//comportamiento Conectar
        string Desconectar();//comportamiento desconectar
    }
}
