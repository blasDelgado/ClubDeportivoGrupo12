namespace ClubDeportivo
{
    partial class FormInscripcion
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
            UsuarioLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtDomicilio = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            dateTimePickerFechaNacimiento = new DateTimePicker();
            dateTimePickerFechaAptoFisico = new DateTimePicker();
            btnAceptar = new Button();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            btnMenuPpal = new Button();
            lblAsterisco1 = new Label();
            lblAsterisco2 = new Label();
            lblAsterisco3 = new Label();
            lblAsterisco4 = new Label();
            lblAsterisco5 = new Label();
            lblAsterisco6 = new Label();
            lblMensaje1 = new Label();
            lblMensaje2 = new Label();
            SuspendLayout();
            // 
            // UsuarioLabel
            // 
            UsuarioLabel.AutoSize = true;
            UsuarioLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UsuarioLabel.Location = new Point(90, 129);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.Size = new Size(76, 20);
            UsuarioLabel.TabIndex = 1;
            UsuarioLabel.Text = "Nombre/s";
            UsuarioLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(90, 174);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 2;
            label1.Text = "Apellido";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(90, 222);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "DNI";
            label2.TextAlign = ContentAlignment.BottomRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(90, 275);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha de nacimiento";
            label3.TextAlign = ContentAlignment.BottomRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(472, 129);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 5;
            label4.Text = "Domicilio";
            label4.TextAlign = ContentAlignment.BottomRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(472, 174);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Email";
            label5.TextAlign = ContentAlignment.BottomRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(472, 222);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 7;
            label6.Text = "Telefono";
            label6.TextAlign = ContentAlignment.BottomRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(472, 275);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 8;
            label7.Text = "Fecha Apto Fisico*";
            label7.TextAlign = ContentAlignment.BottomRight;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = SystemColors.WindowText;
            txtNombre.Location = new Point(191, 129);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(229, 29);
            txtNombre.TabIndex = 9;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = SystemColors.WindowText;
            txtApellido.Location = new Point(191, 174);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(229, 29);
            txtApellido.TabIndex = 10;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.ForeColor = SystemColors.WindowText;
            txtDni.Location = new Point(191, 222);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(229, 29);
            txtDni.TabIndex = 11;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDomicilio.ForeColor = SystemColors.WindowText;
            txtDomicilio.Location = new Point(575, 129);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(229, 29);
            txtDomicilio.TabIndex = 12;
            txtDomicilio.TextChanged += txtDomicilio_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = SystemColors.WindowText;
            txtEmail.Location = new Point(575, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 29);
            txtEmail.TabIndex = 13;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = SystemColors.WindowText;
            txtTelefono.Location = new Point(575, 222);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(229, 29);
            txtTelefono.TabIndex = 14;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaNacimiento.Location = new Point(242, 270);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(178, 27);
            dateTimePickerFechaNacimiento.TabIndex = 15;
            // 
            // dateTimePickerFechaAptoFisico
            // 
            dateTimePickerFechaAptoFisico.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFechaAptoFisico.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaAptoFisico.Location = new Point(626, 270);
            dateTimePickerFechaAptoFisico.Name = "dateTimePickerFechaAptoFisico";
            dateTimePickerFechaAptoFisico.Size = new Size(178, 27);
            dateTimePickerFechaAptoFisico.TabIndex = 16;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(641, 391);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 44);
            btnAceptar.TabIndex = 17;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(151, 391);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 44);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(404, 391);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(142, 44);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMenuPpal
            // 
            btnMenuPpal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuPpal.Location = new Point(662, 32);
            btnMenuPpal.Name = "btnMenuPpal";
            btnMenuPpal.Size = new Size(142, 44);
            btnMenuPpal.TabIndex = 20;
            btnMenuPpal.Text = "HOME";
            btnMenuPpal.UseVisualStyleBackColor = true;
            btnMenuPpal.Click += btnMenuPpal_Click;
            // 
            // lblAsterisco1
            // 
            lblAsterisco1.AutoSize = true;
            lblAsterisco1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsterisco1.ForeColor = Color.Red;
            lblAsterisco1.Location = new Point(426, 133);
            lblAsterisco1.Name = "lblAsterisco1";
            lblAsterisco1.Size = new Size(21, 25);
            lblAsterisco1.TabIndex = 21;
            lblAsterisco1.Text = "*";
            lblAsterisco1.Visible = false;
            // 
            // lblAsterisco2
            // 
            lblAsterisco2.AutoSize = true;
            lblAsterisco2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsterisco2.ForeColor = Color.Red;
            lblAsterisco2.Location = new Point(426, 174);
            lblAsterisco2.Name = "lblAsterisco2";
            lblAsterisco2.Size = new Size(21, 25);
            lblAsterisco2.TabIndex = 22;
            lblAsterisco2.Text = "*";
            lblAsterisco2.Visible = false;
            // 
            // lblAsterisco3
            // 
            lblAsterisco3.AutoSize = true;
            lblAsterisco3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsterisco3.ForeColor = Color.Red;
            lblAsterisco3.Location = new Point(426, 222);
            lblAsterisco3.Name = "lblAsterisco3";
            lblAsterisco3.Size = new Size(21, 25);
            lblAsterisco3.TabIndex = 23;
            lblAsterisco3.Text = "*";
            lblAsterisco3.Visible = false;
            // 
            // lblAsterisco4
            // 
            lblAsterisco4.AutoSize = true;
            lblAsterisco4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsterisco4.ForeColor = Color.Red;
            lblAsterisco4.Location = new Point(810, 129);
            lblAsterisco4.Name = "lblAsterisco4";
            lblAsterisco4.Size = new Size(21, 25);
            lblAsterisco4.TabIndex = 24;
            lblAsterisco4.Text = "*";
            lblAsterisco4.Visible = false;
            // 
            // lblAsterisco5
            // 
            lblAsterisco5.AutoSize = true;
            lblAsterisco5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsterisco5.ForeColor = Color.Red;
            lblAsterisco5.Location = new Point(810, 178);
            lblAsterisco5.Name = "lblAsterisco5";
            lblAsterisco5.Size = new Size(21, 25);
            lblAsterisco5.TabIndex = 25;
            lblAsterisco5.Text = "*";
            lblAsterisco5.Visible = false;
            // 
            // lblAsterisco6
            // 
            lblAsterisco6.AutoSize = true;
            lblAsterisco6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsterisco6.ForeColor = Color.Red;
            lblAsterisco6.Location = new Point(810, 226);
            lblAsterisco6.Name = "lblAsterisco6";
            lblAsterisco6.Size = new Size(21, 25);
            lblAsterisco6.TabIndex = 26;
            lblAsterisco6.Text = "*";
            lblAsterisco6.Visible = false;
            // 
            // lblMensaje1
            // 
            lblMensaje1.AutoSize = true;
            lblMensaje1.ForeColor = Color.Red;
            lblMensaje1.Location = new Point(93, 325);
            lblMensaje1.Name = "lblMensaje1";
            lblMensaje1.Size = new Size(170, 21);
            lblMensaje1.TabIndex = 27;
            lblMensaje1.Text = "Estos campos son obligatorios";
            lblMensaje1.UseCompatibleTextRendering = true;
            lblMensaje1.Visible = false;
            // 
            // lblMensaje2
            // 
            lblMensaje2.AutoSize = true;
            lblMensaje2.ForeColor = SystemColors.Highlight;
            lblMensaje2.Location = new Point(447, 325);
            lblMensaje2.Name = "lblMensaje2";
            lblMensaje2.Size = new Size(357, 15);
            lblMensaje2.TabIndex = 28;
            lblMensaje2.Text = "Formato inválido, el DNI y el telefono debe contener solo números";
            lblMensaje2.Visible = false;
            // 
            // FormInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 502);
            Controls.Add(lblMensaje2);
            Controls.Add(lblMensaje1);
            Controls.Add(lblAsterisco6);
            Controls.Add(lblAsterisco5);
            Controls.Add(lblAsterisco4);
            Controls.Add(lblAsterisco3);
            Controls.Add(lblAsterisco2);
            Controls.Add(lblAsterisco1);
            Controls.Add(btnMenuPpal);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dateTimePickerFechaAptoFisico);
            Controls.Add(dateTimePickerFechaNacimiento);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtDomicilio);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UsuarioLabel);
            Name = "FormInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInscripcion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsuarioLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtDomicilio;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private DateTimePicker dateTimePickerFechaNacimiento;
        private DateTimePicker dateTimePickerFechaAptoFisico;
        private Button btnAceptar;
        private Button btnCancelar;
        private Button btnLimpiar;
        private Button btnMenuPpal;
        private Label lblAsterisco1;
        private Label lblAsterisco2;
        private Label lblAsterisco3;
        private Label lblAsterisco4;
        private Label lblAsterisco5;
        private Label lblAsterisco6;
        private Label lblMensaje1;
        private Label lblMensaje2;
    }
}