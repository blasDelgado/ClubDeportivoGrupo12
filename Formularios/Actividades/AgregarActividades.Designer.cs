namespace ClubDeportivo
{
    partial class AgregarActividades
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxNombre = new TextBox();
            txtBoxPrecio = new TextBox();
            comboBoxFrecuencia = new ComboBox();
            btnCancelar = new Button();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(93, 79);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(93, 122);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 4;
            label2.Text = "Precio";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(93, 165);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 5;
            label3.Text = "Frecuencia";
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            txtBoxNombre.Location = new Point(217, 79);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(200, 23);
            txtBoxNombre.TabIndex = 6;
            txtBoxNombre.ModifiedChanged += txtBoxNombre_ModifiedChanged;
            txtBoxNombre.TextChanged += txtBoxNombre_ModifiedChanged;
            // 
            // txtBoxPrecio
            // 
            txtBoxPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtBoxPrecio.Location = new Point(217, 122);
            txtBoxPrecio.Name = "txtBoxPrecio";
            txtBoxPrecio.Size = new Size(200, 23);
            txtBoxPrecio.TabIndex = 7;
            txtBoxPrecio.TextChanged += txtBoxPrecio_TextChanged;
            // 
            // comboBoxFrecuencia
            // 
            comboBoxFrecuencia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFrecuencia.FormattingEnabled = true;
            comboBoxFrecuencia.Items.AddRange(new object[] { "Mensual", "Semanal", "Diario" });
            comboBoxFrecuencia.Location = new Point(217, 163);
            comboBoxFrecuencia.Name = "comboBoxFrecuencia";
            comboBoxFrecuencia.Size = new Size(200, 23);
            comboBoxFrecuencia.TabIndex = 8;
            comboBoxFrecuencia.SelectedIndexChanged += comboBoxFrecuencia_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonHighlight;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(133, 236);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 42);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ButtonHighlight;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(281, 236);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 42);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseCompatibleTextRendering = true;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AgregarActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 339);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Controls.Add(comboBoxFrecuencia);
            Controls.Add(txtBoxPrecio);
            Controls.Add(txtBoxNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarActividades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Actividad";
            Load += AgregarActividades_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxNombre;
        private TextBox txtBoxPrecio;
        private ComboBox comboBoxFrecuencia;
        private Button btnCancelar;
        private Button btnAgregar;
    }
}