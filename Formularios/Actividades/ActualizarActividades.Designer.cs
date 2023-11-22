namespace ClubDeportivo
{
    partial class ActualizarActividades
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
            comboBoxActividad = new ComboBox();
            comboBoxFrecuencia = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtBoxPrecio = new TextBox();
            label4 = new Label();
            btnActualizar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // comboBoxActividad
            // 
            comboBoxActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxActividad.FormattingEnabled = true;
            comboBoxActividad.Location = new Point(219, 103);
            comboBoxActividad.Name = "comboBoxActividad";
            comboBoxActividad.Size = new Size(200, 23);
            comboBoxActividad.TabIndex = 10;
            comboBoxActividad.SelectedIndexChanged += comboBox_change;
            // 
            // comboBoxFrecuencia
            // 
            comboBoxFrecuencia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFrecuencia.FormattingEnabled = true;
            comboBoxFrecuencia.Items.AddRange(new object[] { "Diario", "Semanal", "Mensual" });
            comboBoxFrecuencia.Location = new Point(219, 144);
            comboBoxFrecuencia.Name = "comboBoxFrecuencia";
            comboBoxFrecuencia.Size = new Size(200, 23);
            comboBoxFrecuencia.TabIndex = 12;
            comboBoxFrecuencia.SelectedIndexChanged += comboBoxFrecuencia_change;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(95, 146);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 11;
            label1.Text = "Frecuencia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(95, 105);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 9;
            label3.Text = "Actividad";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(182, 44);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 13;
            label2.Text = "Actualizar Precio:";
            // 
            // txtBoxPrecio
            // 
            txtBoxPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtBoxPrecio.Location = new Point(219, 188);
            txtBoxPrecio.Name = "txtBoxPrecio";
            txtBoxPrecio.Size = new Size(200, 23);
            txtBoxPrecio.TabIndex = 15;
            txtBoxPrecio.TextChanged += txtBoxPrecio_changed;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(95, 188);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 14;
            label4.Text = "Precio";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ButtonHighlight;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Location = new Point(270, 242);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(108, 42);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseCompatibleTextRendering = true;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonHighlight;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(122, 242);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 42);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_click;
            // 
            // ActualizarActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 339);
            Controls.Add(btnActualizar);
            Controls.Add(btnCancelar);
            Controls.Add(txtBoxPrecio);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(comboBoxFrecuencia);
            Controls.Add(label1);
            Controls.Add(comboBoxActividad);
            Controls.Add(label3);
            Name = "ActualizarActividades";
            Text = "Actualizar precio";
            Load += ActualizarActividades_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxActividad;
        private ComboBox comboBoxFrecuencia;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtBoxPrecio;
        private Label label4;
        private Button btnActualizar;
        private Button btnCancelar;
    }
}