using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Dao.Model;

namespace Practicas.Dao.Interface
{
    // aqui ya podemos definir los comportamientos mas especificos segun la entidad 
    // en este caso para Persona
    // hacemos que esta interface herede de ICRUD
    public interface IPersonaDao: ICRUD<Persona>
    {

    }
}
