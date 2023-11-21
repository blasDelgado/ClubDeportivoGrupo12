namespace ClubDeportivo
{
    partial class SinLocalizarCliente
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
            PreguntaLabel = new Label();
            MensajeLabel2 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // PreguntaLabel
            // 
            PreguntaLabel.AutoSize = true;
            PreguntaLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PreguntaLabel.Location = new Point(160, 106);
            PreguntaLabel.Name = "PreguntaLabel";
            PreguntaLabel.Size = new Size(136, 20);
            PreguntaLabel.TabIndex = 10;
            PreguntaLabel.Text = "¿Desea registrarlo?";
            PreguntaLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // MensajeLabel2
            // 
            MensajeLabel2.AutoSize = true;
            MensajeLabel2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MensajeLabel2.Location = new Point(106, 66);
            MensajeLabel2.Name = "MensajeLabel2";
            MensajeLabel2.Size = new Size(249, 20);
            MensajeLabel2.TabIndex = 12;
            MensajeLabel2.Text = "El cliente no se encuentra registrado";
            MensajeLabel2.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(51, 148);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 44);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(251, 148);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 44);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // SinLocalizarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 242);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(MensajeLabel2);
            Controls.Add(PreguntaLabel);
            Name = "SinLocalizarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente no censado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PreguntaLabel;
        private Label MensajeLabel2;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}