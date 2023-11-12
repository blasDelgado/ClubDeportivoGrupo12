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
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }


        public void validarDatos(String dni)
        {
            if (string.IsNullOrEmpty(dni))
            {
                AsteriscoLabel1.Visible = true;
                MensajeLabel1.Visible = true;

            }
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            MensajeLabel2.Visible = false;
            string dni;
            long dniNum=0;

            dni = txtDni.Text.Trim();

            validarDatos(dni);


            if (!EsNumero(dni))
            {
                MensajeLabel2.Visible = true;
            }
            else
            {
                dniNum = long.Parse(dni);
            }

            if (dniNum > 0)
            {
                // buscar al cliente en la base de datos
                Cliente cliente;

                if (dniNum == 123456) // Cambiar 123456 por el valor buscado
                {
                    ClienteLocalizado clienteLocalizado = new ClienteLocalizado();
                    clienteLocalizado.Show();
                }
                else
                {
                    SinLocalizarCliente sinLocalizarCliente = new SinLocalizarCliente();
                    sinLocalizarCliente.Show();
                    
                }
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            AsteriscoLabel1.Visible = false;
            MensajeLabel1.Visible = false;
        }


        private bool EsNumero(string dni)
        {
            foreach (char c in dni)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
