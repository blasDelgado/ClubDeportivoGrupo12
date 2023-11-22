using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
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
    public partial class ListarActividades : Form
    {
        public ListarActividades()
        {
            InitializeComponent();
        }

        private void dtgvActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarActividades_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAgregar_click(object sender, EventArgs e)
        {
            Form FormAgregarActividad = new AgregarActividades();
            FormAgregarActividad.ShowDialog();

        }

        private void btnVolver_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
