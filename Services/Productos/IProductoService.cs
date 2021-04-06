using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SinergiaTest.Models;

namespace SinergiaTest.Services.Productos
{
    public interface IProductoService
    {
        Producto AddProductos(Producto productos);

        List<Producto> GetProductos();

        void UpdateProductos(Producto productos);

        void DeleteProductos(int Id);

        Producto GetProducto(int Id);
    }
}
