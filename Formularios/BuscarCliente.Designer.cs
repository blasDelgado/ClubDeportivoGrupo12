namespace ClubDeportivo
{
    partial class BuscarCliente
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
            txtBuscarCliente = new Label();
            lblDni = new Label();
            txtDni = new TextBox();
            btnBuscarDni = new Button();
            btnMenu = new Button();
            AsteriscoLabel1 = new Label();
            MensajeLabel1 = new Label();
            MensajeLabel2 = new Label();
            SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.AutoSize = true;
            txtBuscarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCliente.Location = new Point(165, 22);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(108, 21);
            txtBuscarCliente.TabIndex = 0;
            txtBuscarCliente.Text = "Buscar Cliente";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(64, 95);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(37, 21);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(107, 95);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(220, 23);
            txtDni.TabIndex = 2;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarDni.Location = new Point(237, 162);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(142, 44);
            btnBuscarDni.TabIndex = 3;
            btnBuscarDni.Text = "BUSCAR";
            btnBuscarDni.UseVisualStyleBackColor = true;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(24, 180);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(68, 26);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // AsteriscoLabel1
            // 
            AsteriscoLabel1.AutoSize = true;
            AsteriscoLabel1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            AsteriscoLabel1.ForeColor = Color.Red;
            AsteriscoLabel1.Location = new Point(333, 95);
            AsteriscoLabel1.Name = "AsteriscoLabel1";
            AsteriscoLabel1.Size = new Size(21, 25);
            AsteriscoLabel1.TabIndex = 7;
            AsteriscoLabel1.Text = "*";
            AsteriscoLabel1.Visible = false;
            // 
            // MensajeLabel1
            // 
            MensajeLabel1.AutoSize = true;
            MensajeLabel1.ForeColor = Color.Red;
            MensajeLabel1.Location = new Point(107, 121);
            MensajeLabel1.Name = "MensajeLabel1";
            MensajeLabel1.Size = new Size(143, 15);
            MensajeLabel1.TabIndex = 8;
            MensajeLabel1.Text = "Este campo es obligatorio";
            MensajeLabel1.Visible = false;
            // 
            // MensajeLabel2
            // 
            MensajeLabel2.AutoSize = true;
            MensajeLabel2.ForeColor = SystemColors.Highlight;
            MensajeLabel2.Location = new Point(76, 121);
            MensajeLabel2.Name = "MensajeLabel2";
            MensajeLabel2.Size = new Size(292, 15);
            MensajeLabel2.TabIndex = 0;
            MensajeLabel2.Text = "Formato inválido, el DNI debe contener solo números.";
            MensajeLabel2.Visible = false;
            // 
            // BuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 242);
            ControlBox = false;
            Controls.Add(MensajeLabel2);
            Controls.Add(AsteriscoLabel1);
            Controls.Add(MensajeLabel1);
            Controls.Add(btnMenu);
            Controls.Add(btnBuscarDni);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtBuscarCliente);
            Name = "BuscarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuscarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtBuscarCliente;
        private Label lblDni;
        private TextBox txtDni;
        private Button btnBuscarDni;
        private Button btnMenu;
        private Label AsteriscoLabel1;
        private Label MensajeLabel1;
        private Label MensajeLabel2;
    }
}