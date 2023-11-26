namespace ClubDeportivo.Formularios
{
    partial class frmMedioDePago
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
            lblMedioDePago = new Label();
            optEfectivo = new RadioButton();
            optTarjeta3 = new RadioButton();
            optTarjeta6 = new RadioButton();
            btnPagar = new Button();
            SuspendLayout();
            // 
            // lblMedioDePago
            // 
            lblMedioDePago.AutoSize = true;
            lblMedioDePago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedioDePago.Location = new Point(159, 17);
            lblMedioDePago.Name = "lblMedioDePago";
            lblMedioDePago.Size = new Size(156, 21);
            lblMedioDePago.TabIndex = 0;
            lblMedioDePago.Text = "Elegir Medio de Pago";
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            optEfectivo.Location = new Point(91, 67);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(80, 24);
            optEfectivo.TabIndex = 1;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            // 
            // optTarjeta3
            // 
            optTarjeta3.AutoSize = true;
            optTarjeta3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            optTarjeta3.Location = new Point(91, 102);
            optTarjeta3.Name = "optTarjeta3";
            optTarjeta3.Size = new Size(294, 24);
            optTarjeta3.TabIndex = 2;
            optTarjeta3.TabStop = true;
            optTarjeta3.Text = "Tarjeta de Credito en 3 cuotas sin interés";
            optTarjeta3.UseVisualStyleBackColor = true;
            // 
            // optTarjeta6
            // 
            optTarjeta6.AutoSize = true;
            optTarjeta6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            optTarjeta6.Location = new Point(91, 141);
            optTarjeta6.Name = "optTarjeta6";
            optTarjeta6.Size = new Size(294, 24);
            optTarjeta6.TabIndex = 3;
            optTarjeta6.TabStop = true;
            optTarjeta6.Text = "Tarjeta de Credito en 6 cuotas sin interés";
            optTarjeta6.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.Location = new Point(175, 190);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(140, 49);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // frmMedioDePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 251);
            Controls.Add(btnPagar);
            Controls.Add(optTarjeta6);
            Controls.Add(optTarjeta3);
            Controls.Add(optEfectivo);
            Controls.Add(lblMedioDePago);
            Name = "frmMedioDePago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedioDePago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMedioDePago;
        private RadioButton optEfectivo;
        private RadioButton optTarjeta3;
        private RadioButton optTarjeta6;
        private Button btnPagar;
    }
}