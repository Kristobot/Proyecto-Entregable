using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Entregable.DataFake
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int CantidadDisponible { get; set; }
        public string ImagenUrl { get; set; }

        public static List<Producto> CargarProductos()
        {
            var ProductosFake = new List<Producto>
            {
                 new Producto { Id = 1, Nombre = "Manzana", Descripcion = "Manzana roja fresca", Precio = 1.99m, CantidadDisponible = 100, ImagenUrl = "https://i.postimg.cc/bNG72fV0/istockphoto-184276818-2048x2048.jpg" },
            new Producto { Id = 2, Nombre = "Plátano", Descripcion = "Plátano maduro y dulce", Precio = 0.99m, CantidadDisponible = 150, ImagenUrl = "https://i.postimg.cc/SxCHD7hJ/istockphoto-1400057530-2048x2048.webp" },
            new Producto { Id = 3, Nombre = "Naranja", Descripcion = "Naranja jugosa", Precio = 1.49m, CantidadDisponible = 80, ImagenUrl = "https://i.postimg.cc/7L4dcGHX/istockphoto-185284489-2048x2048.webp" },
            new Producto { Id = 4, Nombre = "Pera", Descripcion = "Pera jugosa y dulce", Precio = 2.29m, CantidadDisponible = 90, ImagenUrl = "https://i.postimg.cc/VstTYWJ4/istockphoto-1299073137-2048x2048.webp" },
            new Producto { Id = 5, Nombre = "Uva", Descripcion = "Racimo de uvas frescas", Precio = 3.99m, CantidadDisponible = 120, ImagenUrl = "https://i.postimg.cc/WbPytqrV/images.jpg" },
            new Producto { Id = 6, Nombre = "Fresa", Descripcion = "Fresas rojas y dulces", Precio = 2.99m, CantidadDisponible = 75, ImagenUrl = "https://i.postimg.cc/sgj04Fw0/fraise-large.jpg" },
            };
            return ProductosFake;
        }
    }
}
