using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace ClubDeportivo.Formularios
{
    public partial class ContratarActividad : Form
    {
        Datos.ActividadesDatos sqlCon = new Datos.ActividadesDatos();
        internal Cliente? cliente;

        public ContratarActividad()
        {
            InitializeComponent();
            try
            {
                MySqlDataReader lector = sqlCon.listarActividades();
                while (lector.Read())
                {
                    if (lector.GetString(1) != "membresia")
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

        private void btnContratar_Click(object sender, EventArgs e)
        {
         

            // si el cliente es Socio
            if (cliente!.ValidarSocio())
            {
                MessageBox.Show("El cliente es Socio, tiene todas las actividades incluidas","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // si no está inscripto como noSocio
                if (!cliente.ValidarNoSocio())
                {
                    cliente.InscribirNoSocio();
                }

                // Consultar actividades diarias ya contratadas para la fecha actual y colocarlas en una lista
                List<Actividad> actividades = new List<Actividad>();
                ClienteDatos clienteDatos = new ClienteDatos();
                actividades = clienteDatos.ActividadesCliente(cliente.getCLIENTE_ID());

                // SI el cliente ya tiene contratada esa actividad para esa fecha
                string actividadAContratar = cboActividad.Text;
                if (ActividadYaContratada(actividades, actividadAContratar))
                {
                    MessageBox.Show("El cliente ya tiene esa actividad contratada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Abrir Form Pago.cs
                    frmMedioDePago medioDePago = new frmMedioDePago();
                    ActividadesDatos actividadesDatos = new ActividadesDatos();
                    Actividad actividad = actividadesDatos.BuscarActividadPorNombre(actividadAContratar);
                    medioDePago.nombre = "Actividad: " + actividad.getNombreActividad();
                    medioDePago.importe = (actividad.getPrecioActividad()).ToString("$ #.#,##", System.Globalization.CultureInfo.GetCultureInfo("ar-AR")); ;
                    medioDePago.frecuencia = "Frecuencia: " + actividad.getFrecuencia();
                    medioDePago.fVencimiento = DateTime.UtcNow.ToShortDateString();
                    medioDePago.cliente = cliente;
                    medioDePago.ShowDialog();

                    // Si el pago retornó OK, hacer el insert SQL de la actividad en ActividadesContratadas de la Entidad actividad_cliente
                    if(medioDePago.pagoOK)
                    {
                        cliente.ContratarActividad(actividadAContratar);
                        //MessageBox.Show("Actividad Contratada (simulacro)");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al pagar. Actividad no contratada. Por favor intente nuevamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


            bool ActividadYaContratada (List<Actividad> actividades, string nombreActividad)
            {
                bool encontrado = false;

                foreach (Actividad actividad in actividades)
                {
                    if (actividad.getNombreActividad() == nombreActividad)
                    {
                        encontrado = true;
                        break;
                    }
                }
                return encontrado;
            }
        }
    }
}
