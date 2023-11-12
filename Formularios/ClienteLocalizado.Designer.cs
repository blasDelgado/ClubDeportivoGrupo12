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
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(252, 141);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 44);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(52, 141);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 44);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // UserPictureBox
            // 
            UserPictureBox.Image = Properties.Resources.usuario;
            UserPictureBox.Location = new Point(97, 47);
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
            UsuarioLabel.Location = new Point(168, 70);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.Size = new Size(136, 20);
            UsuarioLabel.TabIndex = 9;
            UsuarioLabel.Text = "Nombre y Apellido";
            UsuarioLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // ClienteLocalizado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 242);
            ControlBox = false;
            Controls.Add(UsuarioLabel);
            Controls.Add(UserPictureBox);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "ClienteLocalizado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private PictureBox UserPictureBox;
        private Label UsuarioLabel;
    }
}