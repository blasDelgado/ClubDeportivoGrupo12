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

namespace ClubDeportivo.Formularios.Clientes
{
    public partial class frmListarDeudores : Form
    {
        public frmListarDeudores()
        {
            InitializeComponent();
        }

        private void frmListarDeudores_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            ClienteDatos clienteDatos = new ClienteDatos();
            dtgvDeudores.DataSource = clienteDatos.listarDeudores();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtgvDeudores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
