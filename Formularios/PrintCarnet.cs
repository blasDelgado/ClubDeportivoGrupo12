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
        internal long dni;

        public PrintCarnet(long dni)
        {
            this.dni = dni;
            InitializeComponent();
            
        }

        private void PrintCarnet_Load(object sender, EventArgs e)
        {
            // buscar al cliente en la base de datos
            Datos.ClienteDatos cli = new Datos.ClienteDatos();
            Cliente cliente = cli.IdentificarCliente(this.dni);


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
            /* -----------------------------------------------------
             * Ocultamos los botones que no pertenecen al diseño
             * pero si para la funcionalidad
             * Usamos la propiedad VISIBLE y los posibles
             * valores son True o False
             * ---------------------------------------------------- */
            btnImprimir.Visible = false;
            /* ---------------------------------------
            * creamos los objetos para la impresion
            * ------------------------------------------ */
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimir.Visible = true; // visualizamos nuevamente el objeto
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


            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // private void PrintCarnet_Load(object sender, EventArgs e)
        ///{

        //}
    }
}
