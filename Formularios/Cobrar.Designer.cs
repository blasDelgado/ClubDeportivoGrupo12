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
            lblFormaPago = new Label();
            rbEfectivo = new RadioButton();
            rbTarjetaCredito = new RadioButton();
            cbCuotas = new ComboBox();
            btnPagar = new Button();
            btnCancelar = new Button();
            btnMenuPpal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCuotas).BeginInit();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.Location = new Point(544, 144);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(108, 21);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "Importe Total: ";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImporte.Location = new Point(714, 144);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(62, 21);
            lblImporte.TabIndex = 2;
            lblImporte.Text = "$ 00.00";
            // 
            // lblMensaje2
            // 
            lblMensaje2.AutoSize = true;
            lblMensaje2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje2.Location = new Point(149, 90);
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
            dgvCuotas.Location = new Point(149, 144);
            dgvCuotas.Name = "dgvCuotas";
            dgvCuotas.RowTemplate.Height = 25;
            dgvCuotas.Size = new Size(338, 150);
            dgvCuotas.TabIndex = 5;
            dgvCuotas.CellContentClick += dgvCuotas_CellContentClick;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFormaPago.Location = new Point(544, 192);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(204, 21);
            lblFormaPago.TabIndex = 6;
            lblFormaPago.Text = "Seleccionar Forma de Pago: ";
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(584, 233);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 7;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            rbEfectivo.CheckedChanged += rbEfectivo_CheckedChanged;
            // 
            // rbTarjetaCredito
            // 
            rbTarjetaCredito.AutoSize = true;
            rbTarjetaCredito.Location = new Point(584, 258);
            rbTarjetaCredito.Name = "rbTarjetaCredito";
            rbTarjetaCredito.Size = new Size(117, 19);
            rbTarjetaCredito.TabIndex = 8;
            rbTarjetaCredito.TabStop = true;
            rbTarjetaCredito.Text = "Tarjeta de Crédito";
            rbTarjetaCredito.UseVisualStyleBackColor = true;
            rbTarjetaCredito.CheckedChanged += rbTarjetaCredito_CheckedChanged;
            // 
            // cbCuotas
            // 
            cbCuotas.FormattingEnabled = true;
            cbCuotas.Items.AddRange(new object[] { "1 pago", "3 cuotas s/i", "6 cuotas s/i" });
            cbCuotas.Location = new Point(584, 283);
            cbCuotas.Name = "cbCuotas";
            cbCuotas.Size = new Size(121, 23);
            cbCuotas.TabIndex = 9;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.Location = new Point(584, 379);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(142, 44);
            btnPagar.TabIndex = 18;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(179, 379);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 44);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnMenuPpal
            // 
            btnMenuPpal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuPpal.Location = new Point(714, 31);
            btnMenuPpal.Name = "btnMenuPpal";
            btnMenuPpal.Size = new Size(142, 44);
            btnMenuPpal.TabIndex = 21;
            btnMenuPpal.Text = "HOME";
            btnMenuPpal.UseVisualStyleBackColor = true;
            btnMenuPpal.Click += btnMenuPpal_Click;
            // 
            // Cobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 502);
            ControlBox = false;
            Controls.Add(btnMenuPpal);
            Controls.Add(btnCancelar);
            Controls.Add(btnPagar);
            Controls.Add(cbCuotas);
            Controls.Add(rbTarjetaCredito);
            Controls.Add(rbEfectivo);
            Controls.Add(lblFormaPago);
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
        private Label lblFormaPago;
        private RadioButton rbEfectivo;
        private RadioButton rbTarjetaCredito;
        private ComboBox cbCuotas;
        private Button btnPagar;
        private Button btnCancelar;
        private Button btnMenuPpal;
    }
}