namespace ClubDeportivo.Formularios.Clientes
{
    partial class ListarClientes
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
            dtgvClientes = new DataGridView();
            lblTitCliente = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dtgvClientes
            // 
            dtgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvClientes.Location = new Point(39, 63);
            dtgvClientes.Margin = new Padding(3, 4, 3, 4);
            dtgvClientes.Name = "dtgvClientes";
            dtgvClientes.RowHeadersWidth = 51;
            dtgvClientes.RowTemplate.Height = 25;
            dtgvClientes.Size = new Size(718, 324);
            dtgvClientes.TabIndex = 2;
            dtgvClientes.Tag = "Listado Clientes";
            dtgvClientes.CellContentClick += dtgvClientes_CellContentClick;
            // 
            // lblTitCliente
            // 
            lblTitCliente.AutoSize = true;
            lblTitCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitCliente.Location = new Point(39, 20);
            lblTitCliente.Name = "lblTitCliente";
            lblTitCliente.Size = new Size(92, 28);
            lblTitCliente.TabIndex = 14;
            lblTitCliente.Text = "Clientes:";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ButtonHighlight;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(575, 422);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(182, 69);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ListarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(btnVolver);
            Controls.Add(lblTitCliente);
            Controls.Add(dtgvClientes);
            Name = "ListarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de clientes";
            Load += ListarClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvClientes;
        private Label lblTitCliente;
        private Button btnVolver;
    }
}