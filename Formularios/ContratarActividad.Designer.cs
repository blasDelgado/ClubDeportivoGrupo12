namespace ClubDeportivo.Formularios
{
    partial class ContratarActividad
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
            lblActividad = new Label();
            cboActividad = new ComboBox();
            btnCancelar = new Button();
            btnContratar = new Button();
            SuspendLayout();
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblActividad.Location = new Point(74, 93);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(74, 21);
            lblActividad.TabIndex = 1;
            lblActividad.Text = "Actividad";
            // 
            // cboActividad
            // 
            cboActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActividad.FormattingEnabled = true;
            cboActividad.Location = new Point(172, 93);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(134, 23);
            cboActividad.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(51, 204);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnContratar
            // 
            btnContratar.Location = new Point(226, 204);
            btnContratar.Name = "btnContratar";
            btnContratar.Size = new Size(120, 40);
            btnContratar.TabIndex = 4;
            btnContratar.Text = "Contratar";
            btnContratar.UseVisualStyleBackColor = true;
            btnContratar.Click += btnContratar_Click;
            // 
            // ContratarActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 277);
            Controls.Add(btnContratar);
            Controls.Add(btnCancelar);
            Controls.Add(cboActividad);
            Controls.Add(lblActividad);
            Name = "ContratarActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContratarActividad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblActividad;
        private ComboBox cboActividad;
        private Button btnCancelar;
        private Button btnContratar;
    }
}