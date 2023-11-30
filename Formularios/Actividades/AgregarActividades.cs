using System;
using ClubDeportivo.Datos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClubDeportivo.Entidades;

namespace ClubDeportivo
{
    public partial class AgregarActividades : Form
    {
        public AgregarActividades()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
        }

        private void AgregarActividades_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtBoxNombre.Text) && !string.IsNullOrEmpty(txtBoxPrecio.Text) && !string.IsNullOrEmpty(comboBoxFrecuencia.Text))
            { btnAgregar.Enabled = true; }

        }
        private void txtBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxNombre.Text) && !string.IsNullOrEmpty(txtBoxPrecio.Text) && !string.IsNullOrEmpty(comboBoxFrecuencia.Text))
            { btnAgregar.Enabled = true; }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            ListarActividades listarActividades = new ListarActividades();
            listarActividades.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            string nombre = txtBoxNombre.Text.Trim();
            string precioStr = txtBoxPrecio.Text.Trim();
            string frecuencia = comboBoxFrecuencia.Text;
            long precio = 0;
            long numero;
            bool esLong = long.TryParse(precioStr, out numero);
            if (esLong)
            {
                precio = numero;
                Actividad actividad = new Actividad(nombre, precio, frecuencia);
                ActividadesDatos sqlCon = new ActividadesDatos();
                try
                {
                    sqlCon.agregarActividad(actividad);
                    this.Close();
                    MessageBox.Show($"Actividad :  {actividad} agregada.");
                    ListarActividades listarActividades = new ListarActividades();
                    listarActividades.ShowDialog();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); };

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Ingrese un precio válido", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                btnAgregar.Enabled = false;
            }

        }

        private void txtBoxNombre_ModifiedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxNombre.Text) && !string.IsNullOrEmpty(txtBoxPrecio.Text) && !string.IsNullOrEmpty(comboBoxFrecuencia.Text))
            { btnAgregar.Enabled = true; }
        }

        private void comboBoxFrecuencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxNombre.Text) && !string.IsNullOrEmpty(txtBoxPrecio.Text) && !string.IsNullOrEmpty(comboBoxFrecuencia.Text))
            { btnAgregar.Enabled = true; }
        }
    }
}
