using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estacionamiento.Entities;
using Estacionamiento.View;
using Estacionamiento.Presenter;

namespace Estacionamiento
{
    public partial class Main : Form, Iinformation
    {
        private EstacionamientoPresenter ePresenter;

        public Main()
        {
            InitializeComponent();
        }

        public void Refresh_data(Dictionary<Ticket, Dueño> data)
        {
            datagrid.DataSource = data.ToList();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ePresenter = new EstacionamientoPresenter(this);
            ePresenter.Load_combo();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            string fecha = Fecha_ingreso.Text;
            string nombre_establecimiento = txt_nombre_estacionamiento.Text;
            string[] dueño = new string[4];
            dueño[0] = txtnombre.Text;
            dueño[1] = txtapellido.Text;
            dueño[2] = txtdomicilio.Text;
            dueño[3] = txtdni.Text;
            string[] vehiculo = new string[6];
            vehiculo[0] = txtmodelo.Text;
            vehiculo[1] = txtmarca.Text;
            vehiculo[2] = txtpatente.Text;
            vehiculo[3] = txtaño.Text;
            vehiculo[4] = txtcant_ruedas.Text;
            vehiculo[5] = txtcant_puertas.Text;
            string tipo_vehiculostr = tipo_vehiculo.Text;
            TipoVehiculo tipo_vehiculoType = (TipoVehiculo)Enum.Parse(typeof(TipoVehiculo), tipo_vehiculostr);
            ePresenter.guardar(fecha, nombre_establecimiento, dueño, vehiculo, tipo_vehiculoType);
        }

        public void Load_combo()
        {
            tipo_vehiculo.DataSource = Enum.GetValues(typeof(TipoVehiculo));
        }
    }
}
