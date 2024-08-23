namespace Proyecto_Entregable.Vistas;

public partial class PaginaDeIncio : ContentPage
{
	public PaginaDeIncio()
	{
        InitializeComponent();
	}

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        if (IsValidUser(username, password))
        {
            // Redirigir a la p�gina principal de la tienda si el inicio de sesi�n es correcto
            await Navigation.PushAsync(new Compras());
        }
        else
        {
            // Mostrar mensaje de error si las credenciales son incorrectas
            await DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
        }
    }

    private bool IsValidUser(string username, string password)
    {
        // Validar usuario y contrase�a (esto es solo un ejemplo; en la pr�ctica, deber�as verificar con una base de datos)
        return username == "admin" && password == "1234";
    }

    private async void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        // Redirigir a la p�gina de registro
        await DisplayAlert("Registro", "Aqu� va la funcionalidad de registro", "OK");
    }


}