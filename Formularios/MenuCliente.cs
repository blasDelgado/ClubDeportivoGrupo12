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
        public MenuCliente()
        {
            InitializeComponent();
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
    }
}
