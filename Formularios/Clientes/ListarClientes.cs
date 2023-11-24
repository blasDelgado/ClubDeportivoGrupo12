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
    public partial class ListarClientes : Form
    {
        public ListarClientes()
        {
            InitializeComponent();
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;
            ClientesDatos sqlCon = new ClientesDatos();
            try
            {
                resultado = sqlCon.listarClientes();
                dataTable.Load(resultado);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };

            dtgvClientes.DataSource = dataTable;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
