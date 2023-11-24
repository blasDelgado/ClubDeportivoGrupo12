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

            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;
            ActividadesDatos sqlCon = new ActividadesDatos();
            try
            {
                resultado = sqlCon.listarActividades();
                dataTable.Load(resultado);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };

            dtgvActividades.DataSource = dataTable;


        }

        private void btnAgregar_click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormAgregarActividad = new AgregarActividades();
            FormAgregarActividad.ShowDialog();


        }

        private void btnVolver_click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormHome = new ActividadesHome();
            FormHome.ShowDialog();
        }
    }
}
