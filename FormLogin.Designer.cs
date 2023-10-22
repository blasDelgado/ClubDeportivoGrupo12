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
        SuspendLayout();
        // 
        // UsuarioLabel
        // 
        UsuarioLabel.AutoSize = true;
        UsuarioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        UsuarioLabel.Location = new Point(98, 49);
        UsuarioLabel.Name = "UsuarioLabel";
        UsuarioLabel.Size = new Size(64, 21);
        UsuarioLabel.TabIndex = 0;
        UsuarioLabel.Text = "Usuario";
        UsuarioLabel.TextAlign = ContentAlignment.BottomRight;
        // 
        // ContrasenaLabel
        // 
        ContrasenaLabel.AutoSize = true;
        ContrasenaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        ContrasenaLabel.Location = new Point(98, 98);
        ContrasenaLabel.Name = "ContrasenaLabel";
        ContrasenaLabel.Size = new Size(96, 21);
        ContrasenaLabel.TabIndex = 1;
        ContrasenaLabel.Text = "Constraseña";
        // 
        // UsuarioTextBox
        // 
        UsuarioTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        UsuarioTextBox.Location = new Point(229, 49);
        UsuarioTextBox.Name = "UsuarioTextBox";
        UsuarioTextBox.Size = new Size(134, 29);
        UsuarioTextBox.TabIndex = 2;
        // 
        // ContrasenaTextBox
        // 
        ContrasenaTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        ContrasenaTextBox.Location = new Point(229, 98);
        ContrasenaTextBox.Name = "ContrasenaTextBox";
        ContrasenaTextBox.Size = new Size(134, 29);
        ContrasenaTextBox.TabIndex = 3;
        ContrasenaTextBox.UseSystemPasswordChar = true;
        // 
        // LoginButton
        // 
        LoginButton.BackColor = SystemColors.ButtonShadow;
        LoginButton.FlatAppearance.BorderColor = Color.Gray;
        LoginButton.FlatStyle = FlatStyle.Flat;
        LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        LoginButton.Location = new Point(389, 141);
        LoginButton.Name = "LoginButton";
        LoginButton.Size = new Size(88, 39);
        LoginButton.TabIndex = 4;
        LoginButton.Text = "Ingresar";
        LoginButton.UseVisualStyleBackColor = false;
        LoginButton.Click += LoginButton_Click_1;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(534, 206);
        Controls.Add(LoginButton);
        Controls.Add(ContrasenaTextBox);
        Controls.Add(UsuarioTextBox);
        Controls.Add(ContrasenaLabel);
        Controls.Add(UsuarioLabel);
        Name = "Login";
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label UsuarioLabel;
    private Label ContrasenaLabel;
    private TextBox UsuarioTextBox;
    private TextBox ContrasenaTextBox;
    private Button LoginButton;
}
