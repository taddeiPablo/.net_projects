using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Entities;

namespace Estacionamiento.View
{
    public interface Iinformation
    {
        void Refresh_data(Dictionary<Ticket, Dueño> data);
        void Load_combo();
    }
}
