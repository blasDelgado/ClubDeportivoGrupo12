namespace ClubDeportivo.Formularios
{
    partial class MenuCliente
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
            ActualizarButton = new Button();
            AsociarButton = new Button();
            ContratarButton = new Button();
            CobrarButton = new Button();
            ImprimirButton = new Button();
            MasButton = new Button();
            UsuarioPictureBox = new PictureBox();
            lblCliente = new Label();
            btnMenuPpal = new Button();
            ((System.ComponentModel.ISupportInitialize)UsuarioPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ActualizarButton
            // 
            ActualizarButton.BackColor = SystemColors.ControlDark;
            ActualizarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ActualizarButton.Location = new Point(156, 190);
            ActualizarButton.Name = "ActualizarButton";
            ActualizarButton.Size = new Size(138, 100);
            ActualizarButton.TabIndex = 1;
            ActualizarButton.Text = "Actualizar Datos";
            ActualizarButton.UseVisualStyleBackColor = false;
            ActualizarButton.Click += ActualizarButton_Click;
            // 
            // AsociarButton
            // 
            AsociarButton.BackColor = SystemColors.ControlDark;
            AsociarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AsociarButton.Location = new Point(388, 190);
            AsociarButton.Name = "AsociarButton";
            AsociarButton.Size = new Size(138, 100);
            AsociarButton.TabIndex = 2;
            AsociarButton.Text = "Asociar";
            AsociarButton.UseVisualStyleBackColor = false;
            AsociarButton.Click += AsociarButton_Click;
            // 
            // ContratarButton
            // 
            ContratarButton.BackColor = SystemColors.ControlDark;
            ContratarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ContratarButton.Location = new Point(594, 190);
            ContratarButton.Name = "ContratarButton";
            ContratarButton.Size = new Size(138, 100);
            ContratarButton.TabIndex = 3;
            ContratarButton.Text = "Contratar Actividades";
            ContratarButton.UseVisualStyleBackColor = false;
            ContratarButton.Click += ContratarButton_Click;
            // 
            // CobrarButton
            // 
            CobrarButton.BackColor = SystemColors.ControlDark;
            CobrarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CobrarButton.Location = new Point(156, 331);
            CobrarButton.Name = "CobrarButton";
            CobrarButton.Size = new Size(138, 100);
            CobrarButton.TabIndex = 4;
            CobrarButton.Text = "Cobrar";
            CobrarButton.UseVisualStyleBackColor = false;
            // 
            // ImprimirButton
            // 
            ImprimirButton.BackColor = SystemColors.ControlDark;
            ImprimirButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ImprimirButton.Location = new Point(388, 331);
            ImprimirButton.Name = "ImprimirButton";
            ImprimirButton.Size = new Size(138, 100);
            ImprimirButton.TabIndex = 5;
            ImprimirButton.Text = "Imprimir Carnet";
            ImprimirButton.UseVisualStyleBackColor = false;
            ImprimirButton.Click += ImprimirButton_Click;
            // 
            // MasButton
            // 
            MasButton.BackColor = SystemColors.ControlDark;
            MasButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MasButton.Location = new Point(594, 331);
            MasButton.Name = "MasButton";
            MasButton.Size = new Size(138, 100);
            MasButton.TabIndex = 6;
            MasButton.Text = "+";
            MasButton.UseVisualStyleBackColor = false;
            // 
            // UsuarioPictureBox
            // 
            UsuarioPictureBox.Image = Properties.Resources.usuario;
            UsuarioPictureBox.Location = new Point(175, 72);
            UsuarioPictureBox.Name = "UsuarioPictureBox";
            UsuarioPictureBox.Size = new Size(94, 76);
            UsuarioPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            UsuarioPictureBox.TabIndex = 7;
            UsuarioPictureBox.TabStop = false;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(275, 98);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(136, 20);
            lblCliente.TabIndex = 10;
            lblCliente.Text = "Nombre y Apellido";
            lblCliente.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnMenuPpal
            // 
            btnMenuPpal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuPpal.Location = new Point(685, 40);
            btnMenuPpal.Name = "btnMenuPpal";
            btnMenuPpal.Size = new Size(142, 44);
            btnMenuPpal.TabIndex = 21;
            btnMenuPpal.Text = "HOME";
            btnMenuPpal.UseVisualStyleBackColor = true;
            btnMenuPpal.Click += btnMenuPpal_Click;
            // 
            // MenuCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 502);
            Controls.Add(btnMenuPpal);
            Controls.Add(lblCliente);
            Controls.Add(UsuarioPictureBox);
            Controls.Add(MasButton);
            Controls.Add(ImprimirButton);
            Controls.Add(CobrarButton);
            Controls.Add(ContratarButton);
            Controls.Add(AsociarButton);
            Controls.Add(ActualizarButton);
            Name = "MenuCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuCliente";
            Load += MenuCliente_Load;
            ((System.ComponentModel.ISupportInitialize)UsuarioPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ActualizarButton;
        private Button AsociarButton;
        private Button ContratarButton;
        private Button CobrarButton;
        private Button ImprimirButton;
        private Button MasButton;
        private PictureBox UsuarioPictureBox;
        private Label lblCliente;
        private Button btnMenuPpal;
    }
}