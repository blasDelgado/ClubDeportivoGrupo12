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
    public partial class ActualizarCliente : Form
    {
        private ClienteDatos clienteDatos;
        public ActualizarCliente()
        {
            InitializeComponent();
            clienteDatos = new ClienteDatos();
        }

        internal Cliente? cliente;

        private void ActualizarCliente_Load(object sender, EventArgs e)
        {
            lblNombre.Text = cliente.getNombre();
            lblApellido.Text = cliente.getApellido();
            lblDni.Text = cliente.getDni().ToString();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDomicilio.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;

            OcultarMensajesValidacion();
        }

        private void OcultarMensajesValidacion()
        {
            lblAsterisco4.Visible = false;
            lblAsterisco5.Visible = false;
            lblAsterisco6.Visible = false;
            lblMensaje1.Visible = false;
            lblMensaje2.Visible = false;
        }

        public void validarDatos(String domicilio, String email, String telefono)
        {
            int validadorString = 0;

            if (string.IsNullOrEmpty(domicilio))
            {
                lblAsterisco4.Visible = true;
                validadorString++;
            }
            if (string.IsNullOrEmpty(email))
            {
                lblAsterisco5.Visible = true;
                validadorString++;
            }
            if (string.IsNullOrEmpty(telefono))
            {
                lblAsterisco6.Visible = true;
                validadorString++;
            }

            if (validadorString > 0)
            {
                lblMensaje1.Visible = true;
            }
        }

        private bool EsNumero(string dniText)
        {
            foreach (char c in dniText)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {
            lblAsterisco4.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblAsterisco5.Visible = false;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            lblAsterisco6.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string domicilio = txtDomicilio.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;

            validarDatos(domicilio, email, telefono);

            if (string.IsNullOrEmpty(telefono) || !EsNumero(telefono))
            {
                lblMensaje2.Visible = true;
            }
            else
            {
                cliente.setDomicilio(domicilio);
                cliente.setEmail(email);
                cliente.setTelefono(telefono);


                try
                {
                    clienteDatos.ActualizarCliente(cliente);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
