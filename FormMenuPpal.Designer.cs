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
            SuspendLayout();
            // 
            // IdentificarButton
            // 
            IdentificarButton.BackColor = SystemColors.ControlDark;
            IdentificarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IdentificarButton.Location = new Point(139, 51);
            IdentificarButton.Name = "IdentificarButton";
            IdentificarButton.Size = new Size(138, 39);
            IdentificarButton.TabIndex = 0;
            IdentificarButton.Text = "Identificar";
            IdentificarButton.UseVisualStyleBackColor = false;
            IdentificarButton.Click += IdentificarButton_Click;
            // 
            // ClientesButton
            // 
            ClientesButton.BackColor = SystemColors.ControlDark;
            ClientesButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ClientesButton.Location = new Point(139, 113);
            ClientesButton.Name = "ClientesButton";
            ClientesButton.Size = new Size(138, 39);
            ClientesButton.TabIndex = 1;
            ClientesButton.Text = "Clientes";
            ClientesButton.UseVisualStyleBackColor = false;
            // 
            // ActividadesButton
            // 
            ActividadesButton.BackColor = SystemColors.ControlDark;
            ActividadesButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ActividadesButton.Location = new Point(139, 170);
            ActividadesButton.Name = "ActividadesButton";
            ActividadesButton.Size = new Size(138, 39);
            ActividadesButton.TabIndex = 2;
            ActividadesButton.Text = "Actividades";
            ActividadesButton.UseVisualStyleBackColor = false;
            // 
            // SalirButton
            // 
            SalirButton.Location = new Point(324, 235);
            SalirButton.Name = "SalirButton";
            SalirButton.Size = new Size(75, 23);
            SalirButton.TabIndex = 3;
            SalirButton.Text = "Salir";
            SalirButton.UseVisualStyleBackColor = true;
            SalirButton.Click += SalirButton_Click;
            // 
            // FormMenuPpal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 279);
            Controls.Add(SalirButton);
            Controls.Add(ActividadesButton);
            Controls.Add(ClientesButton);
            Controls.Add(IdentificarButton);
            Name = "FormMenuPpal";
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button IdentificarButton;
        private Button ClientesButton;
        private Button ActividadesButton;
        private Button SalirButton;
    }
}