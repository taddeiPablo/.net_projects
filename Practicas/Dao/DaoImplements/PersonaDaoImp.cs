using System;
using System.Collections.Generic;
using System.Text;
using Practicas.Dao.Interface;
using Practicas.Dao.Model;

namespace Practicas.Dao.DaoImplements
{
    // AQUI CREAMOS UNA CLASE PERSONADAOIMP QUE IMPLEMENTARA LA INTERFACE IPERSONADAO
    public class PersonaDaoImp : IPersonaDao
    {
        private IConexiones conexion;
        private List<Persona> listPersonas;

        public PersonaDaoImp(IConexiones conn)
        {
            this.conexion = conn;
            listPersonas = new List<Persona>();
            listPersonas.Add(new Persona(1000, "pablo"));
            listPersonas.Add(new Persona(1001, "tito"));
            listPersonas.Add(new Persona(1002, "roberto"));
            listPersonas.Add(new Persona(1003, "alejandro"));
            listPersonas.Add(new Persona(1004, "federico"));
            listPersonas.Add(new Persona(1005, "iker"));
            listPersonas.Add(new Persona(1006, "aristobulo"));
            listPersonas.Add(new Persona(1007, "jose"));
            listPersonas.Add(new Persona(1008, "ismael"));
        }

        public void actualizar(Persona persona)
        {
            for (int index = 0; index < listPersonas.Count; index++)
            {
                if (listPersonas[index].Id == persona.Id)
                {
                    listPersonas[index] = persona;
                }
            }
        }

        public void eliminar(int id)
        {
            foreach (Persona item in listPersonas)
            {
                if (item.Id == id)
                {
                    listPersonas.Remove(item);
                }
            }
        }

        public Persona leerPorId(int id)
        {
            Persona person = new Persona();
            foreach (Persona item in listPersonas)
            {
                if (item.Id == id)
                {
                    person = item;
                }
            }
            return person;
        }

        public List<Persona> ListaTodos()
        {
            return listPersonas;
        }

        public void registrar(Persona persona)
        {
            listPersonas.Add(persona);
        }
    }
}
