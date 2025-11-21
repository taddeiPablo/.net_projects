using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas.Dao.Interface
{
    // ejemplo de como utilizar los GENERICS o genericos <T>
    // aqui reuno todas las operaciones comunes todos los comportamientos comunes
    public interface ICRUD<T>
    {
        List<T> ListaTodos();
        T leerPorId(int id);
        void registrar(T entity);
        void actualizar(T entity);
        void eliminar(int id);
    }
}
