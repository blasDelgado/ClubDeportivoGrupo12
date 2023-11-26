namespace ClubDeportivo.Formularios
{
    partial class frmImprimirTicket
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
            pnlTitulo = new Panel();
            label1 = new Label();
            pnlDatos = new Panel();
            lblFormaDePago = new Label();
            lblTitFormaDePago = new Label();
            lblImporte = new Label();
            lblVencimiento = new Label();
            lblNumero = new Label();
            lblCategoria = new Label();
            lblNombre = new Label();
            lblTitImporte = new Label();
            lblTitVencimiento = new Label();
            lblTitCategoria = new Label();
            lblTitNumero = new Label();
            lblTitNombre = new Label();
            btnImprimir = new Button();
            pnlDatosGym = new Panel();
            lblConcepto = new Label();
            lblFecha = new Label();
            lblTitConcepto = new Label();
            lblTitFecha = new Label();
            label2 = new Label();
            pnlTitulo.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlDatosGym.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = SystemColors.Info;
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Location = new Point(28, 12);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(691, 51);
            pnlTitulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(217, 11);
            label1.Name = "label1";
            label1.Size = new Size(265, 30);
            label1.TabIndex = 0;
            label1.Text = "COMPROBANTE DE PAGO";
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = SystemColors.Info;
            pnlDatos.Controls.Add(lblFormaDePago);
            pnlDatos.Controls.Add(lblTitFormaDePago);
            pnlDatos.Controls.Add(lblImporte);
            pnlDatos.Controls.Add(lblVencimiento);
            pnlDatos.Controls.Add(lblNumero);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Controls.Add(lblTitImporte);
            pnlDatos.Controls.Add(lblTitVencimiento);
            pnlDatos.Controls.Add(lblTitCategoria);
            pnlDatos.Controls.Add(lblTitNumero);
            pnlDatos.Controls.Add(lblTitNombre);
            pnlDatos.Location = new Point(28, 176);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(691, 217);
            pnlDatos.TabIndex = 1;
            // 
            // lblFormaDePago
            // 
            lblFormaDePago.AutoSize = true;
            lblFormaDePago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFormaDePago.Location = new Point(166, 123);
            lblFormaDePago.Name = "lblFormaDePago";
            lblFormaDePago.Size = new Size(123, 21);
            lblFormaDePago.TabIndex = 17;
            lblFormaDePago.Text = "Efectivo / Tarjeta";
            // 
            // lblTitFormaDePago
            // 
            lblTitFormaDePago.AutoSize = true;
            lblTitFormaDePago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitFormaDePago.Location = new Point(43, 123);
            lblTitFormaDePago.Name = "lblTitFormaDePago";
            lblTitFormaDePago.Size = new Size(117, 21);
            lblTitFormaDePago.TabIndex = 16;
            lblTitFormaDePago.Text = "Forma de Pago:";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblImporte.Location = new Point(553, 174);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(118, 25);
            lblImporte.TabIndex = 15;
            lblImporte.Text = "$ XXXXX.XX";
            // 
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVencimiento.Location = new Point(545, 25);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(110, 21);
            lblVencimiento.TabIndex = 14;
            lblVencimiento.Text = "XX / XX / XXXX";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumero.Location = new Point(463, 73);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(165, 21);
            lblNumero.TabIndex = 13;
            lblNumero.Text = "Socio_ID / NoSocio_ID";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.Location = new Point(131, 73);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(121, 21);
            lblCategoria.TabIndex = 12;
            lblCategoria.Text = "Socio / NoSocio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(131, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(129, 21);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre Apellido";
            // 
            // lblTitImporte
            // 
            lblTitImporte.AutoSize = true;
            lblTitImporte.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitImporte.Location = new Point(364, 174);
            lblTitImporte.Name = "lblTitImporte";
            lblTitImporte.Size = new Size(183, 25);
            lblTitImporte.TabIndex = 10;
            lblTitImporte.Text = "Importe Abonado: ";
            // 
            // lblTitVencimiento
            // 
            lblTitVencimiento.AutoSize = true;
            lblTitVencimiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitVencimiento.Location = new Point(375, 25);
            lblTitVencimiento.Name = "lblTitVencimiento";
            lblTitVencimiento.Size = new Size(164, 21);
            lblTitVencimiento.TabIndex = 9;
            lblTitVencimiento.Text = "Fecha de Vencimiento:";
            // 
            // lblTitCategoria
            // 
            lblTitCategoria.AutoSize = true;
            lblTitCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitCategoria.Location = new Point(43, 73);
            lblTitCategoria.Name = "lblTitCategoria";
            lblTitCategoria.Size = new Size(80, 21);
            lblTitCategoria.TabIndex = 8;
            lblTitCategoria.Text = "Categoria:";
            // 
            // lblTitNumero
            // 
            lblTitNumero.AutoSize = true;
            lblTitNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitNumero.Location = new Point(375, 73);
            lblTitNumero.Name = "lblTitNumero";
            lblTitNumero.Size = new Size(71, 21);
            lblTitNumero.TabIndex = 7;
            lblTitNumero.Text = "Numero:";
            // 
            // lblTitNombre
            // 
            lblTitNombre.AutoSize = true;
            lblTitNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitNombre.Location = new Point(43, 25);
            lblTitNombre.Name = "lblTitNombre";
            lblTitNombre.Size = new Size(71, 21);
            lblTitNombre.TabIndex = 6;
            lblTitNombre.Text = "Nombre:";
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.Location = new Point(612, 406);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(107, 30);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // pnlDatosGym
            // 
            pnlDatosGym.BackColor = Color.Thistle;
            pnlDatosGym.Controls.Add(lblConcepto);
            pnlDatosGym.Controls.Add(lblFecha);
            pnlDatosGym.Controls.Add(lblTitConcepto);
            pnlDatosGym.Controls.Add(lblTitFecha);
            pnlDatosGym.Controls.Add(label2);
            pnlDatosGym.Location = new Point(28, 69);
            pnlDatosGym.Name = "pnlDatosGym";
            pnlDatosGym.Size = new Size(691, 101);
            pnlDatosGym.TabIndex = 1;
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblConcepto.Location = new Point(445, 59);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(135, 21);
            lblConcepto.TabIndex = 5;
            lblConcepto.Text = "Concepto de Pago";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(511, 21);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(78, 21);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "xx/xx/xxxx";
            // 
            // lblTitConcepto
            // 
            lblTitConcepto.AutoSize = true;
            lblTitConcepto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitConcepto.Location = new Point(349, 59);
            lblTitConcepto.Name = "lblTitConcepto";
            lblTitConcepto.Size = new Size(79, 21);
            lblTitConcepto.TabIndex = 3;
            lblTitConcepto.Text = "Concepto:";
            // 
            // lblTitFecha
            // 
            lblTitFecha.AutoSize = true;
            lblTitFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitFecha.Location = new Point(375, 21);
            lblTitFecha.Name = "lblTitFecha";
            lblTitFecha.Size = new Size(53, 21);
            lblTitFecha.TabIndex = 2;
            lblTitFecha.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 36);
            label2.Name = "label2";
            label2.Size = new Size(260, 30);
            label2.TabIndex = 1;
            label2.Text = "Club Deportivo - Grupo 3";
            // 
            // frmImprimirTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(pnlDatosGym);
            Controls.Add(btnImprimir);
            Controls.Add(pnlDatos);
            Controls.Add(pnlTitulo);
            Name = "frmImprimirTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ImprimirTicket";
            Load += ImprimirTicket_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlDatosGym.ResumeLayout(false);
            pnlDatosGym.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label label1;
        private Panel pnlDatos;
        private Button btnImprimir;
        private Panel pnlDatosGym;
        private Label lblFecha;
        private Label lblTitConcepto;
        private Label lblTitFecha;
        private Label label2;
        private Label lblTitCategoria;
        private Label lblTitNumero;
        private Label lblTitNombre;
        private Label lblConcepto;
        private Label lblImporte;
        private Label lblVencimiento;
        private Label lblNumero;
        private Label lblCategoria;
        private Label lblNombre;
        private Label lblTitImporte;
        private Label lblTitVencimiento;
        private Label lblFormaDePago;
        private Label lblTitFormaDePago;
    }
}