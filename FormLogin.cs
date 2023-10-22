namespace ClubDeportivo;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }



    private void LoginButton_Click_1(object sender, EventArgs e)
    {
        string user;
        string pass;

        user = UsuarioTextBox.Text;
        pass = ContrasenaTextBox.Text;

        if (user == "adm" && pass == "1234")
        {
            MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

            FormMenuPpal formMenuPpal = new FormMenuPpal();
            formMenuPpal.ShowDialog();
        }
        else
        {
            MessageBox.Show("Usuario y/o clave incorrecta. Vuelve a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            UsuarioTextBox.Clear();
            ContrasenaTextBox.Clear();
        }

    }

}
