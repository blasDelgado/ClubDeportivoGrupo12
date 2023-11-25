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
    public partial class MenuCliente : Form
    {
        private CuotaDatos cuotaDatos;
        public MenuCliente()
        {
            InitializeComponent();
            cuotaDatos = new CuotaDatos();
        }


        internal Cliente? cliente;

        private void btnMenuPpal_Click(object sender, EventArgs e)
        {
            this.Close();
            Form buscarClienteForm = Application.OpenForms["BuscarCliente"];

            if (buscarClienteForm != null)
            {
                buscarClienteForm.Close();
            }

        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {
            lblCliente.Text = cliente.getNombre() + " " + cliente.getApellido();
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            ActualizarCliente actualizarCliente = new ActualizarCliente();
            actualizarCliente.cliente = cliente;
            actualizarCliente.Show();
        }

        private void ContratarButton_Click(object sender, EventArgs e)
        {
            ContratarActividad contratarActividad = new ContratarActividad();
            contratarActividad.Show();
        }

        private void AsociarButton_Click(object sender, EventArgs e)
        {
            Asociar asociar = new Asociar();
            asociar.cliente = cliente;
            asociar.Show();
        }

        private void CobrarButton_Click(object sender, EventArgs e)
        {
            List<Cuota> cuotasPendientes = cuotaDatos.ObtenerCuotasPendientes(cliente.getCLIENTE_ID());

            if (cuotasPendientes.Count == 0)
            {
                MessageBox.Show("El cliente no tiene deuda pendiente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Cobrar formularioCobro = new Cobrar();
                formularioCobro.cliente = cliente;
                formularioCobro.cuotasPendientes = cuotasPendientes;

                formularioCobro.Show();
            }
        }
    }
}
