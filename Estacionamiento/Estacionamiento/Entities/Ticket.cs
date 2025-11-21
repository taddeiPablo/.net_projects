using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class Ticket
    {
        private int codigo;
        private string horario_entrada;
        private string nombre_estacionamiento;

        public int Codigo
        {
            get => this.codigo;
            set => this.codigo = value;
        }

        public string HorarioEntrada
        {
            get => this.horario_entrada;
            set => this.horario_entrada = value;
        }

        public string Nombre_estacionamiento
        {
            get => this.nombre_estacionamiento;
            set => this.nombre_estacionamiento = value;
        }

        public Ticket(int codigo, string HorarioEntrada, string nombreEstacionamiento)
        {
            this.codigo = codigo;
            this.horario_entrada = HorarioEntrada;
            this.nombre_estacionamiento = nombreEstacionamiento;
        }
    }
}
