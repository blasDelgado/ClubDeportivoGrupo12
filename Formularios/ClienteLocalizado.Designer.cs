namespace ClubDeportivo
{
    partial class ClienteLocalizado
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            UserPictureBox = new PictureBox();
            UsuarioLabel = new Label();
            btnActualizarDatos = new Button();
            btnAsociar = new Button();
            btnContratarActividad = new Button();
            btnCobrar = new Button();
            btnImprimirCarnet = new Button();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(242, 555);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 27);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(40, 555);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 27);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // UserPictureBox
            // 
            UserPictureBox.Image = Properties.Resources.usuario;
            UserPictureBox.Location = new Point(119, 58);
            UserPictureBox.Name = "UserPictureBox";
            UserPictureBox.Size = new Size(65, 59);
            UserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            UserPictureBox.TabIndex = 8;
            UserPictureBox.TabStop = false;
            // 
            // UsuarioLabel
            // 
            UsuarioLabel.AutoSize = true;
            UsuarioLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UsuarioLabel.Location = new Point(190, 81);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.Size = new Size(136, 20);
            UsuarioLabel.TabIndex = 9;
            UsuarioLabel.Text = "Nombre y Apellido";
            UsuarioLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnActualizarDatos
            // 
            btnActualizarDatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizarDatos.Location = new Point(119, 165);
            btnActualizarDatos.Name = "btnActualizarDatos";
            btnActualizarDatos.Size = new Size(207, 47);
            btnActualizarDatos.TabIndex = 10;
            btnActualizarDatos.Text = "Actualizar Datos";
            btnActualizarDatos.UseVisualStyleBackColor = true;
            btnActualizarDatos.Click += btnActualizarDatos_Click;
            // 
            // btnAsociar
            // 
            btnAsociar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAsociar.Location = new Point(119, 233);
            btnAsociar.Name = "btnAsociar";
            btnAsociar.Size = new Size(207, 47);
            btnAsociar.TabIndex = 11;
            btnAsociar.Text = "Asociar";
            btnAsociar.UseVisualStyleBackColor = true;
            // 
            // btnContratarActividad
            // 
            btnContratarActividad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnContratarActividad.Location = new Point(119, 302);
            btnContratarActividad.Name = "btnContratarActividad";
            btnContratarActividad.Size = new Size(207, 47);
            btnContratarActividad.TabIndex = 12;
            btnContratarActividad.Text = "Contratar Actividad";
            btnContratarActividad.UseVisualStyleBackColor = true;
            // 
            // btnCobrar
            // 
            btnCobrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCobrar.Location = new Point(119, 369);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(207, 47);
            btnCobrar.TabIndex = 13;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = true;
            // 
            // btnImprimirCarnet
            // 
            btnImprimirCarnet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimirCarnet.Location = new Point(119, 439);
            btnImprimirCarnet.Name = "btnImprimirCarnet";
            btnImprimirCarnet.Size = new Size(207, 47);
            btnImprimirCarnet.TabIndex = 14;
            btnImprimirCarnet.Text = "Imprimir Carnet";
            btnImprimirCarnet.UseVisualStyleBackColor = true;
            // 
            // ClienteLocalizado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 594);
            ControlBox = false;
            Controls.Add(btnImprimirCarnet);
            Controls.Add(btnCobrar);
            Controls.Add(btnContratarActividad);
            Controls.Add(btnAsociar);
            Controls.Add(btnActualizarDatos);
            Controls.Add(UsuarioLabel);
            Controls.Add(UserPictureBox);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "ClienteLocalizado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            Load += ClienteLocalizado_Load;
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private PictureBox UserPictureBox;
        private Label UsuarioLabel;
        private Button btnActualizarDatos;
        private Button btnAsociar;
        private Button btnContratarActividad;
        private Button btnCobrar;
        private Button btnImprimirCarnet;
    }
}