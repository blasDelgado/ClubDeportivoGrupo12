namespace ClubDeportivo.Formularios
{
    partial class Cobrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMensaje = new Label();
            lblImporte = new Label();
            lblMensaje2 = new Label();
            lblCliente = new Label();
            dgvCuotas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCuotas).BeginInit();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.Location = new Point(495, 356);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(108, 21);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "Importe Total: ";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImporte.Location = new Point(635, 356);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(62, 21);
            lblImporte.TabIndex = 2;
            lblImporte.Text = "$ 00.00";
            // 
            // lblMensaje2
            // 
            lblMensaje2.AutoSize = true;
            lblMensaje2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje2.Location = new Point(197, 90);
            lblMensaje2.Name = "lblMensaje2";
            lblMensaje2.Size = new Size(65, 21);
            lblMensaje2.TabIndex = 3;
            lblMensaje2.Text = "Cliente: ";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(283, 90);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(141, 21);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Nombre y Apellido";
            // 
            // dgvCuotas
            // 
            dgvCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuotas.Location = new Point(283, 144);
            dgvCuotas.Name = "dgvCuotas";
            dgvCuotas.RowTemplate.Height = 25;
            dgvCuotas.Size = new Size(338, 150);
            dgvCuotas.TabIndex = 5;
            // 
            // Cobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 502);
            ControlBox = false;
            Controls.Add(dgvCuotas);
            Controls.Add(lblCliente);
            Controls.Add(lblMensaje2);
            Controls.Add(lblImporte);
            Controls.Add(lblMensaje);
            Name = "Cobrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cobrar";
            Load += Cobrar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCuotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMensaje;
        private Label lblImporte;
        private Label lblMensaje2;
        private Label lblCliente;
        private DataGridView dgvCuotas;
    }
}