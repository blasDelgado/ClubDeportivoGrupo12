namespace ClubDeportivo;

partial class Login
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        UsuarioLabel = new Label();
        ContrasenaLabel = new Label();
        UsuarioTextBox = new TextBox();
        ContrasenaTextBox = new TextBox();
        LoginButton = new Button();
        AsteriscoLabel1 = new Label();
        MensajeLabel1 = new Label();
        UserPictureBox = new PictureBox();
        PassPictureBox = new PictureBox();
        AsteriscoLabel2 = new Label();
        MensajeLabel2 = new Label();
        OlvidoLinkLabel = new LinkLabel();
        RegistroLinkLabel = new LinkLabel();
        RecordarmeCheckBox = new CheckBox();
        ErrorPanel = new Panel();
        MensajeLabel3 = new Label();
        panel1 = new Panel();
        pictureBox1 = new PictureBox();
        pictureBox2 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PassPictureBox).BeginInit();
        ErrorPanel.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // UsuarioLabel
        // 
        UsuarioLabel.AutoSize = true;
        UsuarioLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        UsuarioLabel.Location = new Point(69, 67);
        UsuarioLabel.Name = "UsuarioLabel";
        UsuarioLabel.Size = new Size(59, 20);
        UsuarioLabel.TabIndex = 0;
        UsuarioLabel.Text = "Usuario";
        UsuarioLabel.TextAlign = ContentAlignment.BottomRight;
        // 
        // ContrasenaLabel
        // 
        ContrasenaLabel.AutoSize = true;
        ContrasenaLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        ContrasenaLabel.Location = new Point(69, 136);
        ContrasenaLabel.Name = "ContrasenaLabel";
        ContrasenaLabel.Size = new Size(89, 20);
        ContrasenaLabel.TabIndex = 1;
        ContrasenaLabel.Text = "Constraseña";
        // 
        // UsuarioTextBox
        // 
        UsuarioTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        UsuarioTextBox.ForeColor = SystemColors.WindowText;
        UsuarioTextBox.Location = new Point(66, 86);
        UsuarioTextBox.Name = "UsuarioTextBox";
        UsuarioTextBox.Size = new Size(229, 29);
        UsuarioTextBox.TabIndex = 2;
        UsuarioTextBox.TextChanged += UsuarioTextBox_TextChanged;
        // 
        // ContrasenaTextBox
        // 
        ContrasenaTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        ContrasenaTextBox.Location = new Point(66, 156);
        ContrasenaTextBox.Name = "ContrasenaTextBox";
        ContrasenaTextBox.Size = new Size(229, 29);
        ContrasenaTextBox.TabIndex = 3;
        ContrasenaTextBox.UseSystemPasswordChar = true;
        ContrasenaTextBox.TextChanged += ContrasenaTextBox_TextChanged;
        // 
        // LoginButton
        // 
        LoginButton.BackColor = Color.Transparent;
        LoginButton.FlatAppearance.BorderColor = Color.Gray;
        LoginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(124, 123, 255);
        LoginButton.FlatStyle = FlatStyle.Flat;
        LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        LoginButton.Location = new Point(66, 247);
        LoginButton.Name = "LoginButton";
        LoginButton.Size = new Size(229, 32);
        LoginButton.TabIndex = 4;
        LoginButton.Text = "Ingresar";
        LoginButton.UseVisualStyleBackColor = false;
        LoginButton.Click += LoginButton_Click_1;
        // 
        // AsteriscoLabel1
        // 
        AsteriscoLabel1.AutoSize = true;
        AsteriscoLabel1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        AsteriscoLabel1.ForeColor = Color.Red;
        AsteriscoLabel1.Location = new Point(303, 90);
        AsteriscoLabel1.Name = "AsteriscoLabel1";
        AsteriscoLabel1.Size = new Size(21, 25);
        AsteriscoLabel1.TabIndex = 5;
        AsteriscoLabel1.Text = "*";
        AsteriscoLabel1.Visible = false;
        // 
        // MensajeLabel1
        // 
        MensajeLabel1.AutoSize = true;
        MensajeLabel1.ForeColor = Color.Red;
        MensajeLabel1.Location = new Point(67, 115);
        MensajeLabel1.Name = "MensajeLabel1";
        MensajeLabel1.Size = new Size(143, 15);
        MensajeLabel1.TabIndex = 6;
        MensajeLabel1.Text = "Este campo es obligatorio";
        MensajeLabel1.Visible = false;
        // 
        // UserPictureBox
        // 
        UserPictureBox.Image = Properties.Resources.usuario;
        UserPictureBox.Location = new Point(32, 88);
        UserPictureBox.Name = "UserPictureBox";
        UserPictureBox.Size = new Size(34, 25);
        UserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        UserPictureBox.TabIndex = 7;
        UserPictureBox.TabStop = false;
        // 
        // PassPictureBox
        // 
        PassPictureBox.Image = Properties.Resources.candado;
        PassPictureBox.Location = new Point(32, 158);
        PassPictureBox.Name = "PassPictureBox";
        PassPictureBox.Size = new Size(34, 25);
        PassPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        PassPictureBox.TabIndex = 8;
        PassPictureBox.TabStop = false;
        // 
        // AsteriscoLabel2
        // 
        AsteriscoLabel2.AutoSize = true;
        AsteriscoLabel2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        AsteriscoLabel2.ForeColor = Color.Red;
        AsteriscoLabel2.Location = new Point(303, 160);
        AsteriscoLabel2.Name = "AsteriscoLabel2";
        AsteriscoLabel2.Size = new Size(21, 25);
        AsteriscoLabel2.TabIndex = 9;
        AsteriscoLabel2.Text = "*";
        AsteriscoLabel2.Visible = false;
        // 
        // MensajeLabel2
        // 
        MensajeLabel2.AutoSize = true;
        MensajeLabel2.ForeColor = Color.Red;
        MensajeLabel2.Location = new Point(67, 185);
        MensajeLabel2.Name = "MensajeLabel2";
        MensajeLabel2.Size = new Size(143, 15);
        MensajeLabel2.TabIndex = 10;
        MensajeLabel2.Text = "Este campo es obligatorio";
        MensajeLabel2.Visible = false;
        // 
        // OlvidoLinkLabel
        // 
        OlvidoLinkLabel.AutoSize = true;
        OlvidoLinkLabel.LinkColor = Color.Gray;
        OlvidoLinkLabel.Location = new Point(172, 211);
        OlvidoLinkLabel.Name = "OlvidoLinkLabel";
        OlvidoLinkLabel.Size = new Size(128, 15);
        OlvidoLinkLabel.TabIndex = 11;
        OlvidoLinkLabel.TabStop = true;
        OlvidoLinkLabel.Text = "¿Olvido su contraseña?";
        // 
        // RegistroLinkLabel
        // 
        RegistroLinkLabel.AutoSize = true;
        RegistroLinkLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        RegistroLinkLabel.LinkColor = Color.Gray;
        RegistroLinkLabel.Location = new Point(142, 299);
        RegistroLinkLabel.Name = "RegistroLinkLabel";
        RegistroLinkLabel.Size = new Size(76, 19);
        RegistroLinkLabel.TabIndex = 12;
        RegistroLinkLabel.TabStop = true;
        RegistroLinkLabel.Text = "Registrarse";
        // 
        // RecordarmeCheckBox
        // 
        RecordarmeCheckBox.AutoSize = true;
        RecordarmeCheckBox.ForeColor = SystemColors.GrayText;
        RecordarmeCheckBox.Location = new Point(71, 211);
        RecordarmeCheckBox.Name = "RecordarmeCheckBox";
        RecordarmeCheckBox.Size = new Size(90, 19);
        RecordarmeCheckBox.TabIndex = 13;
        RecordarmeCheckBox.Text = "Recordarme";
        RecordarmeCheckBox.UseVisualStyleBackColor = true;
        // 
        // ErrorPanel
        // 
        ErrorPanel.BackColor = SystemColors.GradientActiveCaption;
        ErrorPanel.Controls.Add(MensajeLabel3);
        ErrorPanel.Location = new Point(3, 11);
        ErrorPanel.Name = "ErrorPanel";
        ErrorPanel.Size = new Size(345, 40);
        ErrorPanel.TabIndex = 14;
        ErrorPanel.Visible = false;
        // 
        // MensajeLabel3
        // 
        MensajeLabel3.AutoSize = true;
        MensajeLabel3.ForeColor = SystemColors.Highlight;
        MensajeLabel3.Location = new Point(13, 13);
        MensajeLabel3.Name = "MensajeLabel3";
        MensajeLabel3.Size = new Size(309, 15);
        MensajeLabel3.TabIndex = 0;
        MensajeLabel3.Text = "Usuario y/o Contraseña incorrecta. Intentelo nuevamente";
        // 
        // panel1
        // 
        panel1.Controls.Add(ErrorPanel);
        panel1.Controls.Add(RecordarmeCheckBox);
        panel1.Controls.Add(UsuarioTextBox);
        panel1.Controls.Add(RegistroLinkLabel);
        panel1.Controls.Add(UsuarioLabel);
        panel1.Controls.Add(OlvidoLinkLabel);
        panel1.Controls.Add(ContrasenaLabel);
        panel1.Controls.Add(MensajeLabel2);
        panel1.Controls.Add(ContrasenaTextBox);
        panel1.Controls.Add(AsteriscoLabel2);
        panel1.Controls.Add(LoginButton);
        panel1.Controls.Add(PassPictureBox);
        panel1.Controls.Add(AsteriscoLabel1);
        panel1.Controls.Add(UserPictureBox);
        panel1.Controls.Add(MensajeLabel1);
        panel1.Location = new Point(68, 107);
        panel1.Name = "panel1";
        panel1.Size = new Size(351, 339);
        panel1.TabIndex = 15;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.f2e73ad2ef97ec38f7345c43df637a92;
        pictureBox1.Location = new Point(322, 37);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(557, 431);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 16;
        pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Resources.LogoClub;
        pictureBox2.Location = new Point(143, 37);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(597, 64);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 17;
        pictureBox2.TabStop = false;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(224, 224, 224);
        ClientSize = new Size(891, 502);
        Controls.Add(pictureBox2);
        Controls.Add(panel1);
        Controls.Add(pictureBox1);
        Name = "Login";
        Text = "Login";
        ((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)PassPictureBox).EndInit();
        ErrorPanel.ResumeLayout(false);
        ErrorPanel.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label UsuarioLabel;
    private Label ContrasenaLabel;
    private TextBox UsuarioTextBox;
    private TextBox ContrasenaTextBox;
    private Button LoginButton;
    private Label AsteriscoLabel1;
    private Label MensajeLabel1;
    private PictureBox UserPictureBox;
    private PictureBox PassPictureBox;
    private Label AsteriscoLabel2;
    private Label MensajeLabel2;
    private LinkLabel OlvidoLinkLabel;
    private LinkLabel RegistroLinkLabel;
    private CheckBox RecordarmeCheckBox;
    private Panel ErrorPanel;
    private Label MensajeLabel3;
    private Panel panel1;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
}
