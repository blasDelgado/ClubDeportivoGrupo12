namespace ClubDeportivo.Formularios
{
    partial class Asociar
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
            lblNombre = new Label();
            lblDni = new Label();
            btnMenuPpal = new Button();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.Location = new Point(270, 75);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(343, 28);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "¿ Confirma el alta de la membresía de ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(315, 122);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(242, 37);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre y Apellido";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(401, 175);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(46, 28);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            lblDni.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnMenuPpal
            // 
            btnMenuPpal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuPpal.Location = new Point(689, 26);
            btnMenuPpal.Name = "btnMenuPpal";
            btnMenuPpal.Size = new Size(142, 44);
            btnMenuPpal.TabIndex = 22;
            btnMenuPpal.Text = "HOME";
            btnMenuPpal.UseVisualStyleBackColor = true;
            btnMenuPpal.Click += btnMenuPpal_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(238, 285);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 44);
            btnCancelar.TabIndex = 47;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(489, 285);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 44);
            btnAceptar.TabIndex = 48;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // Asociar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 401);
            ControlBox = false;
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(btnMenuPpal);
            Controls.Add(lblDni);
            Controls.Add(lblNombre);
            Controls.Add(lblMensaje);
            Name = "Asociar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asociar";
            Load += Asociar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Label lblNombre;
        private Label lblDni;
        private Button btnMenuPpal;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}