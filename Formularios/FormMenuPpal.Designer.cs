namespace ClubDeportivo
{
    partial class FormMenuPpal
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
            IdentificarButton = new Button();
            ClientesButton = new Button();
            ActividadesButton = new Button();
            SalirButton = new Button();
            pictureBox1 = new PictureBox();
            lblRol = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // IdentificarButton
            // 
            IdentificarButton.BackColor = SystemColors.ControlDark;
            IdentificarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IdentificarButton.Location = new Point(148, 150);
            IdentificarButton.Name = "IdentificarButton";
            IdentificarButton.Size = new Size(138, 100);
            IdentificarButton.TabIndex = 0;
            IdentificarButton.Text = "Identificar";
            IdentificarButton.UseVisualStyleBackColor = false;
            IdentificarButton.Click += IdentificarButton_Click;
            // 
            // ClientesButton
            // 
            ClientesButton.BackColor = SystemColors.ControlDark;
            ClientesButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ClientesButton.Location = new Point(383, 150);
            ClientesButton.Name = "ClientesButton";
            ClientesButton.Size = new Size(138, 100);
            ClientesButton.TabIndex = 1;
            ClientesButton.Text = "Clientes";
            ClientesButton.UseVisualStyleBackColor = false;
            // 
            // ActividadesButton
            // 
            ActividadesButton.BackColor = SystemColors.ControlDark;
            ActividadesButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ActividadesButton.Location = new Point(606, 150);
            ActividadesButton.Name = "ActividadesButton";
            ActividadesButton.Size = new Size(138, 100);
            ActividadesButton.TabIndex = 2;
            ActividadesButton.Text = "Actividades";
            ActividadesButton.UseVisualStyleBackColor = false;
            ActividadesButton.Click += ActividadesButton_Click;
            // 
            // SalirButton
            // 
            SalirButton.Location = new Point(530, 348);
            SalirButton.Name = "SalirButton";
            SalirButton.Size = new Size(229, 32);
            SalirButton.TabIndex = 3;
            SalirButton.Text = "Salir";
            SalirButton.UseVisualStyleBackColor = true;
            SalirButton.Click += SalirButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario;
            pictureBox1.Location = new Point(682, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRol.Location = new Point(736, 41);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(56, 15);
            lblRol.TabIndex = 5;
            lblRol.Text = "Hola, Rol";
            // 
            // FormMenuPpal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 502);
            ControlBox = false;
            Controls.Add(lblRol);
            Controls.Add(pictureBox1);
            Controls.Add(SalirButton);
            Controls.Add(ActividadesButton);
            Controls.Add(ClientesButton);
            Controls.Add(IdentificarButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "FormMenuPpal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += FormMenuPpal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IdentificarButton;
        private Button ClientesButton;
        private Button ActividadesButton;
        private Button SalirButton;
        private PictureBox pictureBox1;
        private Label lblRol;
    }
}