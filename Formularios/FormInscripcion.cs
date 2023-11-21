using ClubDeportivo.Datos;
using ClubDeportivo.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{

    public partial class FormInscripcion : Form
    {

        private ClienteDatos clienteDatos;

        public FormInscripcion()
        {
            InitializeComponent();
            clienteDatos = new ClienteDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenuPpal_Click(object sender, EventArgs e)
        {
            this.Close();
            Form? buscarClienteForm = Application.OpenForms["BuscarCliente"];

            if (buscarClienteForm != null)
            {
                buscarClienteForm.Close();
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dniText = txtDni.Text;
            string domicilio = txtDomicilio.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;

            validarDatos(nombre, apellido, dniText, domicilio, email, telefono);

            if (string.IsNullOrEmpty(dniText) || !EsNumero(dniText) || string.IsNullOrEmpty(telefono) || !EsNumero(dniText))
            {
                lblMensaje2.Visible = true;
            }
            else
            {

                long dni = long.Parse(dniText);
                DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;
                DateTime fechaAptoFisico = dateTimePickerFechaAptoFisico.Value;

                Random random = new Random();
                int carnetID = random.Next(1000, 9999);

                bool aptoFisicoVigente = (fechaAptoFisico.Date >= DateTime.Now.Date);


                Cliente nuevoCliente = new Cliente(
                    nombre,
                    apellido,
                    fechaNacimiento,
                    domicilio,
                    email,
                    telefono,
                    dni,
                    aptoFisicoVigente,
                    carnetID
                );


                try
                {
                    clienteDatos.GuardarNuevoCliente(nuevoCliente);
                    this.Close();
                    MenuCliente menuCliente = new MenuCliente();
                    menuCliente.cliente = clienteDatos.IdentificarCliente(dni);
                    menuCliente.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void validarDatos(String nombre, String apellido, String dni, String domicilio, String email, String telefono)
        {
            int validadorString = 0;
            if (string.IsNullOrEmpty(nombre))
            {
                lblAsterisco1.Visible = true;
                validadorString++;
            }
            if (string.IsNullOrEmpty(apellido))
            {
                lblAsterisco2.Visible = true;
                validadorString++;
            }
            if (string.IsNullOrEmpty(dni))
            {
                lblAsterisco3.Visible = true;
                validadorString++;
            }
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblAsterisco1.Visible = false;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            lblAsterisco2.Visible = false;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            lblAsterisco3.Visible = false;
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;

            
            OcultarMensajesValidacion();
        }
        private void OcultarMensajesValidacion()
        {
            lblAsterisco1.Visible = false;
            lblAsterisco2.Visible = false;
            lblAsterisco3.Visible = false;
            lblAsterisco4.Visible = false;
            lblAsterisco5.Visible = false;
            lblAsterisco6.Visible = false;
            lblMensaje1.Visible = false;
            lblMensaje2.Visible = false;
        }

    }
}
