using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
        ActividadesDatos sqlCon = new ActividadesDatos();
        public ActualizarActividades()
        {
            InitializeComponent();
            btnActualizar.Enabled = false;


            try
            {
                MySqlDataReader lector = sqlCon.listarActividades();
                while (lector.Read())
                {
                    comboBoxActividad.Items.Add(lector.GetString(1));
                }
                lector.Close();
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormHome = new ActividadesHome();
            FormHome.ShowDialog();
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
                Actividad act = new Actividad(actividad, precio, frecuencia);
                try
                {
                    sqlCon.actualizarActividad(act);
                    txtBoxPrecio.Text = "";
                    MessageBox.Show($"Actividad :  {actividad} actualizada.");
                    
                   
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); };
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Ingrese un precio válido", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                btnActualizar.Enabled = false;
            }

        }

        private void comboBox_change(object sender, EventArgs e)
        {

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

        private void ActualizarActividades_Load(object sender, EventArgs e)
        {

        }
    }
}
