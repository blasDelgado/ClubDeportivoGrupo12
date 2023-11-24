namespace ClubDeportivo.Formularios.Clientes
{
    partial class ClienteHome
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
            btnListClientes = new Button();
            btnListDeudores = new Button();
            SuspendLayout();
            // 
            // btnListClientes
            // 
            btnListClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnListClientes.Location = new Point(225, 107);
            btnListClientes.Margin = new Padding(3, 4, 3, 4);
            btnListClientes.Name = "btnListClientes";
            btnListClientes.Size = new Size(347, 81);
            btnListClientes.TabIndex = 1;
            btnListClientes.Text = "Ver lista de clientes";
            btnListClientes.UseVisualStyleBackColor = true;
            btnListClientes.Click += btnListClientes_Click;
            // 
            // btnListDeudores
            // 
            btnListDeudores.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnListDeudores.Location = new Point(225, 256);
            btnListDeudores.Margin = new Padding(3, 4, 3, 4);
            btnListDeudores.Name = "btnListDeudores";
            btnListDeudores.Size = new Size(347, 81);
            btnListDeudores.TabIndex = 2;
            btnListDeudores.Text = "Ver lista de deudores";
            btnListDeudores.UseVisualStyleBackColor = true;
            // 
            // ClienteHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListDeudores);
            Controls.Add(btnListClientes);
            Name = "ClienteHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += ClienteHome_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnListClientes;
        private Button btnListDeudores;
    }
}