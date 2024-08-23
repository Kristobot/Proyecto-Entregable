using System.Collections.ObjectModel;
using Proyecto_Entregable.DataFake;

namespace Proyecto_Entregable.Vistas;

public partial class ProductoDetalle : ContentPage
{
    private Producto productoActual;

    public ProductoDetalle(int id)
    {
        InitializeComponent();
        productoActual = Producto.CargarProductos().FirstOrDefault(p => p.Id == id);
        if (productoActual != null)
        {
            BindingContext = productoActual; // Asignar el producto como BindingContext
        }
        else
        {
            DisplayAlert("Error", "Producto no encontrado", "OK");
        }
    }

    private async void OnBackButtonTapped(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}