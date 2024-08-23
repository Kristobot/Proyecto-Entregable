using Proyecto_Entregable.Vistas;

namespace Proyecto_Entregable
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PaginaDeIncio());
        }
    }
}
