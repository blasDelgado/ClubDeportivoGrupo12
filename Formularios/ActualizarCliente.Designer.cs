namespace ClubDeportivo.Formularios
{
    partial class ActualizarCliente
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
            lblMensaje2 = new Label();
            lblMensaje1 = new Label();
            lblAsterisco6 = new Label();
            lblAsterisco5 = new Label();
            lblAsterisco4 = new Label();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDomicilio = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            UsuarioLabel = new Label();
            btnMenuPpal = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            SuspendLayout();
            // 
            // lblMensaje2
            // 
            lblMensaje2.AutoSize = true;
            lblMensaje2.ForeColor = SystemColors.Highlight;
            lblMensaje2.Location = new Point(475, 293);
            lblMensaje2.Name = "lblMensaje2";
            lblMensaje2.Size = new Size(313, 15);
            lblMensaje2.TabIndex = 55;
            lblMensaje2.Text = "Formato inválido, el telefono debe contener solo números";
            lblMensaje2.Visible = false;
            // 
            // lblMensaje1
            // 
            lblMensaje1.AutoSize = true;
            lblMensaje1.ForeColor = Color.Red;
            lblMensaje1.Location = new Point(618, 272);
            lblMensaje1.Name = "lblMensaje1";
            lblMensaje1.Size = new Size(170, 21);
            lblMensaje1.TabIndex = 54;
            lblMensaje1.Text = "Estos campos son obligatorios";
            lblMensaje1.UseCompatibleTextRendering = true;
            lblMensaje1.Visible = false;
            // 
            // lblAsterisco6
            // 
            lblAsterisco6.AutoSize = true;
            lblAsterisco6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsterisco6.ForeColor = Color.Red;
            lblAsterisco6.Location = new Point(794, 224);
            lblAsterisco6.Name = "lblAsterisco6";
            lblAsterisco6.Size = new Size(21, 25);
            lblAsterisco6.TabIndex = 53;
            lblAsterisco6.Text = "*";
            lblAsterisco6.Visible = false;
            // 
            // lblAsterisco5
            // 
            lblAsterisco5.AutoSize = true;
            lblAsterisco5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsterisco5.ForeColor = Color.Red;
            lblAsterisco5.Location = new Point(794, 176);
            lblAsterisco5.Name = "lblAsterisco5";
            lblAsterisco5.Size = new Size(21, 25);
            lblAsterisco5.TabIndex = 52;
            lblAsterisco5.Text = "*";
            lblAsterisco5.Visible = false;
            // 
            // lblAsterisco4
            // 
            lblAsterisco4.AutoSize = true;
            lblAsterisco4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsterisco4.ForeColor = Color.Red;
            lblAsterisco4.Location = new Point(794, 127);
            lblAsterisco4.Name = "lblAsterisco4";
            lblAsterisco4.Size = new Size(21, 25);
            lblAsterisco4.TabIndex = 51;
            lblAsterisco4.Text = "*";
            lblAsterisco4.Visible = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(388, 369);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(142, 44);
            btnLimpiar.TabIndex = 47;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(135, 369);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 44);
            btnCancelar.TabIndex = 46;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(625, 369);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 44);
            btnAceptar.TabIndex = 45;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = SystemColors.WindowText;
            txtTelefono.Location = new Point(559, 220);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(229, 29);
            txtTelefono.TabIndex = 42;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = SystemColors.WindowText;
            txtEmail.Location = new Point(559, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 29);
            txtEmail.TabIndex = 41;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDomicilio.ForeColor = SystemColors.WindowText;
            txtDomicilio.Location = new Point(559, 127);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(229, 29);
            txtDomicilio.TabIndex = 40;
            txtDomicilio.TextChanged += txtDomicilio_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(456, 220);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 35;
            label6.Text = "Telefono";
            label6.TextAlign = ContentAlignment.BottomRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(456, 172);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 34;
            label5.Text = "Email";
            label5.TextAlign = ContentAlignment.BottomRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(456, 127);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 33;
            label4.Text = "Domicilio";
            label4.TextAlign = ContentAlignment.BottomRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 220);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 31;
            label2.Text = "DNI:";
            label2.TextAlign = ContentAlignment.BottomRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 172);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 30;
            label1.Text = "Apellido:";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // UsuarioLabel
            // 
            UsuarioLabel.AutoSize = true;
            UsuarioLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UsuarioLabel.Location = new Point(74, 127);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.Size = new Size(79, 20);
            UsuarioLabel.TabIndex = 29;
            UsuarioLabel.Text = "Nombre/s:";
            UsuarioLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnMenuPpal
            // 
            btnMenuPpal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuPpal.Location = new Point(646, 24);
            btnMenuPpal.Name = "btnMenuPpal";
            btnMenuPpal.Size = new Size(142, 44);
            btnMenuPpal.TabIndex = 56;
            btnMenuPpal.Text = "HOME";
            btnMenuPpal.UseVisualStyleBackColor = true;
            btnMenuPpal.Click += btnMenuPpal_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(165, 127);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(109, 20);
            lblNombre.TabIndex = 57;
            lblNombre.Text = "nombre cliente";
            lblNombre.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(165, 172);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(112, 20);
            lblApellido.TabIndex = 58;
            lblApellido.Text = "apellido cliente";
            lblApellido.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(165, 220);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(78, 20);
            lblDni.TabIndex = 59;
            lblDni.Text = "dni cliente";
            lblDni.TextAlign = ContentAlignment.BottomRight;
            // 
            // ActualizarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 502);
            ControlBox = false;
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnMenuPpal);
            Controls.Add(lblMensaje2);
            Controls.Add(lblMensaje1);
            Controls.Add(lblAsterisco6);
            Controls.Add(lblAsterisco5);
            Controls.Add(lblAsterisco4);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtDomicilio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UsuarioLabel);
            Name = "ActualizarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActualizarCliente";
            Load += ActualizarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje2;
        private Label lblMensaje1;
        private Label lblAsterisco6;
        private Label lblAsterisco5;
        private Label lblAsterisco4;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtDomicilio;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label UsuarioLabel;
        private Button btnMenuPpal;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
    }
}