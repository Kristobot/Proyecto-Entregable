using System.Collections.ObjectModel;
using Proyecto_Entregable.DataFake;

namespace Proyecto_Entregable.Vistas;

public partial class Compras : ContentPage
{
    public ObservableCollection<Producto> Productos { get; set; }

    public Compras()
    {
        InitializeComponent();
        Productos = new ObservableCollection<Producto>(Producto.CargarProductos());
        BindingContext = this; // Establece el contexto de enlace para la página
    }

    private async void OnProductTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is Producto producto)
        {
            await Navigation.PushAsync(new ProductoDetalle(producto.Id));
        }
    }

    private async void OnBackButtonTapped(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}