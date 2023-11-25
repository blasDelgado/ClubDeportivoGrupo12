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
    public partial class Cobrar : Form
    {
        public Cobrar()
        {
            InitializeComponent();
        }
        internal Cliente? cliente;
        internal List<Cuota> cuotasPendientes;
        private int seleccionarColumnIndex;
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

            dgvCuotas.CellValueChanged += DgvCuotas_CellValueChanged;
        }


        private void DgvCuotas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda modificada pertenece a la columna "Seleccionar"
            if (e.ColumnIndex == seleccionarColumnIndex && e.RowIndex >= 0)
            {
                // Actualiza el valor del lblImporte según la lógica que necesites
                ActualizarImporte();
            }
        }

        private void ActualizarImporte()
        {
            // Lógica para recalcular el importe según los checkboxes seleccionados
            float importeTotal = 0;

            foreach (DataGridViewRow row in dgvCuotas.Rows)
            {
                bool seleccionado = Convert.ToBoolean(row.Cells["Seleccionar"].Value ?? false);

                if (seleccionado)
                {
                    float importe = Convert.ToSingle(row.Cells["importe"].Value);
                    importeTotal += importe;
                }
            }

            // Actualiza el valor del lblImporte
            lblImporte.Text = $"$ {importeTotal:F2}";
        }




    }
}
