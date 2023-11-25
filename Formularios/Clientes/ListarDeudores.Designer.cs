namespace ClubDeportivo.Formularios.Clientes
{
    partial class frmListarDeudores
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
            btnVolver = new Button();
            lblTitDeudores = new Label();
            dtgvDeudores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvDeudores).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ButtonHighlight;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(577, 423);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(182, 69);
            btnVolver.TabIndex = 18;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTitDeudores
            // 
            lblTitDeudores.AutoSize = true;
            lblTitDeudores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitDeudores.Location = new Point(41, 21);
            lblTitDeudores.Name = "lblTitDeudores";
            lblTitDeudores.Size = new Size(107, 28);
            lblTitDeudores.TabIndex = 17;
            lblTitDeudores.Text = "Deudores:";
            // 
            // dtgvDeudores
            // 
            dtgvDeudores.AllowUserToAddRows = false;
            dtgvDeudores.AllowUserToDeleteRows = false;
            dtgvDeudores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDeudores.Location = new Point(41, 63);
            dtgvDeudores.Margin = new Padding(3, 4, 3, 4);
            dtgvDeudores.Name = "dtgvDeudores";
            dtgvDeudores.ReadOnly = true;
            dtgvDeudores.RowHeadersWidth = 51;
            dtgvDeudores.RowTemplate.Height = 25;
            dtgvDeudores.Size = new Size(718, 324);
            dtgvDeudores.TabIndex = 19;
            dtgvDeudores.Tag = "Listado Deudores";
            dtgvDeudores.CellContentClick += dtgvDeudores_CellContentClick_1;
            // 
            // frmListarDeudores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(dtgvDeudores);
            Controls.Add(btnVolver);
            Controls.Add(lblTitDeudores);
            Name = "frmListarDeudores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de deudores";
            Load += frmListarDeudores_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDeudores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitDeudores;
        private DataGridView dtgvDeudores;
    }
}