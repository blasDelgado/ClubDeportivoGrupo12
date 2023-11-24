using ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Formularios
{
    public partial class Asociar : Form
    {

        private ClienteDatos clienteDatos;
        private CuotaDatos cuotaDatos;
        private ActividadesDatos actividadesDatos;
        public Asociar()
        {
            InitializeComponent();
            clienteDatos = new ClienteDatos();
            cuotaDatos = new CuotaDatos();
            actividadesDatos = new ActividadesDatos();
        }

        internal Cliente? cliente;

        private void Asociar_Load(object sender, EventArgs e)
        {
            lblNombre.Text = cliente.getNombre() + " " + cliente.getApellido();
            lblDni.Text = "DNI: " + cliente.getDni().ToString();

        }

        private void btnMenuPpal_Click(object sender, EventArgs e)
        {
            this.Close();
            Form buscarClienteForm = Application.OpenForms["BuscarCliente"];

            if (buscarClienteForm != null)
            {
                buscarClienteForm.Close();
            }

            Form menuClienteForm = Application.OpenForms["MenuCliente"];
            if (menuClienteForm != null)
            {
                menuClienteForm.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Actividad actividad = actividadesDatos.BuscarActividadPorNombre("membresia");
            DateTime fechaHoy = DateTime.Today;
            DateTime fechaVencimiento = new DateTime(fechaHoy.Year, fechaHoy.Month, 10).AddMonths(1);

            if (fechaHoy.Day >= 10)
            {
                fechaVencimiento = fechaVencimiento.AddMonths(1);
            }

            if (actividad != null)
            {
                try
                {
                    clienteDatos.AsociarCliente(cliente.getCLIENTE_ID(), actividad.getPrecioActividad(), fechaHoy, fechaVencimiento );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return; 
                }
                this.Close();

            }
        }

    }
}
