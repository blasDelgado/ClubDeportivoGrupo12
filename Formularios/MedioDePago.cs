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

namespace ClubDeportivo.Formularios
{
    public partial class frmMedioDePago : Form
    {
        public frmMedioDePago()
        {
            InitializeComponent();
        }
        internal bool pagoOK = false;
        internal string nombre;
        internal string importe;
        internal string frecuencia;
        internal Cliente cliente;
        internal string fVencimiento;
        private void btnPagar_Click(object sender, EventArgs e)
        {
            // imprimir
            frmImprimirTicket imprimirTicket = new frmImprimirTicket();

            if (optEfectivo.Checked)
            {
                imprimirTicket.formaPago = "Efectivo";
            }
            else if (optTarjeta3.Checked)
            {
                imprimirTicket.formaPago = "Tarjeta (3 cuotas)";
            }
            else if (optTarjeta6.Checked)
            {
                imprimirTicket.formaPago = "Tarjeta (6 cuotas)";
            }
            imprimirTicket.fechaPago = DateTime.UtcNow.ToShortDateString();
            imprimirTicket.concepto = nombre;
            imprimirTicket.nombreApellido = this.cliente.getNombre() + " " + this.cliente.getApellido();
            imprimirTicket.categoria = cliente.ValidarSocio() ? "Socio" : "No Socio";
            imprimirTicket.fVencimiento = fVencimiento;
            if (cliente.ValidarSocio())
            {
                imprimirTicket.categoria = "Socio";
                try
                {
                    using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        string consulta = $"SELECT s.Socio_ID FROM socio s INNER JOIN cliente c ON c.CLIENTE_ID = s.Cliente_ID WHERE c.CLIENTE_ID = @ClienteID";
                        cmd.Connection = sqlCon;
                        cmd.CommandText = consulta;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@ClienteID", cliente.getCLIENTE_ID());
                        sqlCon.Open();
                        imprimirTicket.numero = Convert.ToString(cmd.ExecuteScalar())!;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                imprimirTicket.categoria = "No Socio";
                try
                {
                    using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        string consulta = "SELECT n.NoSocio_ID FROM noSocio n INNER JOIN cliente c ON c.CLIENTE_ID = n.Cliente_ID WHERE c.CLIENTE_ID = @ClienteID";
                        cmd.Connection = sqlCon;
                        cmd.CommandText = consulta;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@ClienteID", cliente.getCLIENTE_ID());
                        sqlCon.Open();
                        imprimirTicket.numero = Convert.ToString(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            imprimirTicket.importe = importe;
            imprimirTicket.ShowDialog();

            pagoOK = true;
            this.Close();
        }
    }
}
