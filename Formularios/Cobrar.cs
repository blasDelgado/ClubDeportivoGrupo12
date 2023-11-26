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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubDeportivo.Formularios
{
    public partial class Cobrar : Form
    {

        

        public Cobrar()
        {
            InitializeComponent();
            cuotasPagar = new List<Cuota>();
            cuotaDatos = new CuotaDatos();
            metodoPago = 0;
        }
        private List<Cuota> cuotasPagar;
        private int metodoPago;
        private CuotaDatos cuotaDatos;
        internal Cliente? cliente;
        internal List<Cuota> cuotasPendientes;
        private int seleccionarColumnIndex;
        float importe = 0;

        private void Cobrar_Load(object sender, EventArgs e)
        {
            lblCliente.Text = cliente.getNombre() + " " + cliente.getApellido();

            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Seleccionar";
            checkboxColumn.Name = "Seleccionar";
            dgvCuotas.Columns.Add(checkboxColumn);
            seleccionarColumnIndex = dgvCuotas.Columns["Seleccionar"].Index;


            dgvCuotas.Columns.Add("cuota", "Tipo de Cuota");
            dgvCuotas.Columns.Add("importe", "Importe");

            dgvCuotas.DataSource = null;
            dgvCuotas.AllowUserToAddRows = false;

            foreach (Cuota cuota in cuotasPendientes)
            {
                dgvCuotas.Rows.Add(false, cuota.getCuota().ToString(), cuota.getImporte());
            }

            dgvCuotas.CellContentClick += dgvCuotas_CellContentClick;
        }


        private float ActualizarImporte()
        {
            float importeTotal = 0;

            foreach (DataGridViewRow row in dgvCuotas.Rows)
            {
                bool seleccionado = Convert.ToBoolean(row.Cells["Seleccionar"].EditedFormattedValue);

                if (seleccionado)
                {
                    float importe = Convert.ToSingle(row.Cells["importe"].Value);
                    importeTotal += importe;
                }
            }

            lblImporte.Text = $"$ {importeTotal:F2}";
            return importeTotal;
        }

        private void dgvCuotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)dgvCuotas.Rows[e.RowIndex].Cells["Seleccionar"];
            bool seleccionado = Convert.ToBoolean(checkboxCell.EditedFormattedValue);

            Cuota cuotaActual = cuotasPendientes[e.RowIndex];

            if (seleccionado && !cuotasPagar.Contains(cuotaActual))
            {
                cuotasPagar.Add(cuotaActual);
            }
            else if (!seleccionado && cuotasPagar.Contains(cuotaActual))
            {
                cuotasPagar.Remove(cuotaActual);
            }

            importe = ActualizarImporte();
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            metodoPago = 1;
            HabilitarDesabilitarComboBox();
        }

        private void rbTarjetaCredito_CheckedChanged(object sender, EventArgs e)
        {
            metodoPago = 2;
            HabilitarDesabilitarComboBox();
        }
        private void HabilitarDesabilitarComboBox()
        {
            cbCuotas.Enabled = rbTarjetaCredito.Checked;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (cuotasPagar.Count == 0)
            {
                MessageBox.Show("Debe seleccionar las cuotas a pagar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (metodoPago == 1 || metodoPago == 2)
            {
                string formaDePago;
                if (metodoPago == 1)
                {
                    formaDePago = FormaDePagoEnum.EFECTIVO.ToString();
                }
                else
                {
                    formaDePago = FormaDePagoEnum.TARJETA.ToString();
                }
                DateTime fechaPago = DateTime.Now;
                cuotaDatos.PagarCuotas(cuotasPagar, formaDePago, fechaPago);

                MessageBox.Show("Pago procesado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Close();


                //--------------------*******----------------
                // Agregar aca la union con el ticket para imprimirlo
                frmImprimirTicket imprimirTicket = new frmImprimirTicket();
                imprimirTicket.fechaPago = fechaPago.ToShortDateString();
                imprimirTicket.concepto = "Cuota Socio";
                imprimirTicket.nombreApellido = this.cliente.getNombre() + " " + this.cliente.getApellido();
                imprimirTicket.categoria = "Socio";
                imprimirTicket.formaPago = formaDePago;
                imprimirTicket.fVencimiento = cuotasPagar[0].getFechaDeVencimiento().ToShortDateString();
                imprimirTicket.importe = $"$ {importe:F2}";

                // obtener numero de socio
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
                imprimirTicket.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la forma de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenuPpal_Click(object sender, EventArgs e)
        {
            this.Close();
            Form? buscarClienteForm = Application.OpenForms["BuscarCliente"];

            if (buscarClienteForm != null)
            {
                buscarClienteForm.Close();
            }
            Form? menuClienteForm = Application.OpenForms["MenuCliente"];

            if (menuClienteForm != null)
            {
                menuClienteForm.Close();
            }

        }
    }
}

