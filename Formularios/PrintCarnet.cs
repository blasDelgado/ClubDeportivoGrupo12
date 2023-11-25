using ClubDeportivo.Datos;
using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClubDeportivo.Formularios
{
    public partial class PrintCarnet : Form
    {

        public PrintCarnet()
        {
            InitializeComponent();

        }
        internal Cliente? cliente;
        private void PrintCarnet_Load(object sender, EventArgs e)
        {          
            labelNombre.Text = cliente.getNombre();
            lblApellido.Text = cliente.getApellido();
            lblDni.Text = cliente.getDni().ToString();
            lblFecha.Text = cliente.getFec_nacimiento().ToString();
            lblEmail.Text = cliente.getEmail();
            lblTelefono.Text = cliente.getTelefono();
            lblSocio.Text = cliente.getCLIENTE_ID().ToString();
            lblDfecha.Text = DateTime.UtcNow.ToShortDateString();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            btnImprimir.Visible = false; // se oculta el boton momentaneamente para que no salga en la impresion del documento

            // Creamos una instancia PrintDialog. 
            PrintDialog printDialog = new PrintDialog();

            // Mostramos la ventana para elegir impresora y almacenamos su return en una variable tipo DialogResult
            DialogResult result = printDialog.ShowDialog();

            // Si el usuario hace click en Imprimir del cuadro de dialogo anterior
            if (result == DialogResult.OK)
            {
                // Logica de impresión
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);

                // Agregamos al objeto PrintDocument la impresora seleccionada
                pd.PrinterSettings = printDialog.PrinterSettings;

                // se inicia la impresion
                pd.Print();
            }

            btnImprimir.Visible = true; // visualizamos nuevamente el objeto
            this.Close();
        }

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
