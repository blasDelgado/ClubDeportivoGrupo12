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
    public partial class ActualizarActividades : Form
    {
        public ActualizarActividades()
        {
            InitializeComponent();
            btnActualizar.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_click(object sender, EventArgs e)
        {
            string actividad = comboBoxActividad.Text;
            string frecuencia = comboBoxFrecuencia.Text;
            string precioStr = txtBoxPrecio.Text;
            long precio = 0;
            long numero;
            bool esLong = long.TryParse(precioStr, out numero);
            if (esLong)
            {
                precio = numero;
                Actividad Actividad = new Actividad (actividad, precio, frecuencia);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Ingrese un precio válido", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                btnActualizar.Enabled = false;
            }

        }

        private void comboBox_change(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxFrecuencia.Text) && !string.IsNullOrEmpty(comboBoxActividad.Text) && !string.IsNullOrEmpty(txtBoxPrecio.Text))
            { btnActualizar.Enabled = true; }
        }

        private void comboBoxFrecuencia_change(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxFrecuencia.Text) && !string.IsNullOrEmpty(comboBoxActividad.Text) && !string.IsNullOrEmpty(txtBoxPrecio.Text))
            { btnActualizar.Enabled = true; }
        }

        private void txtBoxPrecio_changed(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxFrecuencia.Text) && !string.IsNullOrEmpty(comboBoxActividad.Text) && !string.IsNullOrEmpty(txtBoxPrecio.Text))
            { btnActualizar.Enabled = true; }
        }
    }
}
