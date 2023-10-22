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
            SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.AutoSize = true;
            txtBuscarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCliente.Location = new Point(144, 22);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(108, 21);
            txtBuscarCliente.TabIndex = 0;
            txtBuscarCliente.Text = "Buscar Cliente";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(55, 83);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(37, 21);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(98, 83);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(220, 23);
            txtDni.TabIndex = 2;
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarDni.Location = new Point(238, 148);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(142, 44);
            btnBuscarDni.TabIndex = 3;
            btnBuscarDni.Text = "BUSCAR";
            btnBuscarDni.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(24, 166);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(68, 26);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // BuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 207);
            Controls.Add(btnMenu);
            Controls.Add(btnBuscarDni);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtBuscarCliente);
            Name = "BuscarCliente";
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
    }
}