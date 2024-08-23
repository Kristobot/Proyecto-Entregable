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
            // Redirigir a la página principal de la tienda si el inicio de sesión es correcto
            await Navigation.PushAsync(new Compras());
        }
        else
        {
            // Mostrar mensaje de error si las credenciales son incorrectas
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }

    private bool IsValidUser(string username, string password)
    {
        // Validar usuario y contraseña (esto es solo un ejemplo; en la práctica, deberías verificar con una base de datos)
        return username == "admin" && password == "1234";
    }

    private async void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        // Redirigir a la página de registro
        await DisplayAlert("Registro", "Aquí va la funcionalidad de registro", "OK");
    }


}