using ClubDeportivo;
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
    public partial class ActividadesHome : Form
    {
        public ActividadesHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormListAct = new ListarActividades();
            FormListAct.ShowDialog();

        }
       

        private void btnActPrecios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormActualizarAct = new ActualizarActividades();
            FormActualizarAct.ShowDialog();
        }
    }
}
