using System.Data;

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

        DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
        Datos.UsuariosLogin dato = new Datos.UsuariosLogin(); // variable que contiene todas las caracteristicas de la clase
        tablaLogin = dato.Log_Usu(user, pass);
        if (tablaLogin.Rows.Count > 0)
        {
            // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
            MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

            FormMenuPpal formMenuPpal = new FormMenuPpal();
            formMenuPpal.ShowDialog();

            this.Close(); // para que no quede la ventana escondida. Sin esto el sistema sigue en ejecucion hasta que se lo termine desde consola.
        }
        else
        {
            MessageBox.Show("Usuario y/o clave incorrecta. Vuelve a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            UsuarioTextBox.Clear();
            ContrasenaTextBox.Clear();
        }

    }

    private void Login_Load(object sender, EventArgs e)
    {

    }
}
