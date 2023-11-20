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
    public partial class FormMenuPpal : Form
    {
        public FormMenuPpal()
        {
            InitializeComponent();
        }
        internal string? rol;
        private void FormMenuPpal_Load(object sender, EventArgs e)
        {
            lblRol.Text = rol;
        }
        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Login formLogin = new Login();
            formLogin.ShowDialog();


        }

        private void IdentificarButton_Click(object sender, EventArgs e)
        {
            BuscarCliente buscarCliente = new BuscarCliente();
            buscarCliente.ShowDialog();
        }


    }
}
