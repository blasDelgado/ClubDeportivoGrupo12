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
    public partial class ClienteLocalizado : Form
    {
        public ClienteLocalizado()
        {
            InitializeComponent();
        }

        internal Cliente? cliente;


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void ClienteLocalizado_Load(object sender, EventArgs e)
        {
            UsuarioLabel.Text = cliente.getNombre() + " " + cliente.getApellido();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {

        }
    }
}