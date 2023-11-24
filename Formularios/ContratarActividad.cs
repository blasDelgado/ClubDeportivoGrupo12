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

namespace ClubDeportivo.Formularios
{
    public partial class ContratarActividad : Form
    {
        Datos.ActividadesDatos sqlCon = new Datos.ActividadesDatos();

        public ContratarActividad()
        {
            InitializeComponent();
            try
            {
                MySqlDataReader lector = sqlCon.listarActividades();
                while (lector.Read())
                {
                    cboActividad.Items.Add(lector.GetString(1));
                }
                lector.Close();
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
