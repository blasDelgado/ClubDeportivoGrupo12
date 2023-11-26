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
    public partial class frmListarClientes : Form
    {
        public frmListarClientes()
        {
            InitializeComponent();
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            ClienteDatos clienteDatos = new ClienteDatos();
            dtgvClientes.DataSource = clienteDatos.listarClientes();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
