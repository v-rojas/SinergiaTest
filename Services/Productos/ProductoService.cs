using SinergiaTest.DbContext;
using SinergiaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinergiaTest.Services.Productos
{
    public class ProductoService : IProductoService
    {
        private readonly ApplicationDbContext _context;

        public ProductoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Producto AddProductos(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
            return producto;
        }
        public List<Producto> GetProductos()
        {
            return _context.Productos.ToList();
        }

        public void UpdateProductos(Producto producto)
        {
            _context.Productos.Update(producto);
            _context.SaveChanges();
        }

        public void DeleteProductos(int Id)
        {
            var productos = _context.Productos.FirstOrDefault(x => x.Id == Id);
            if (productos != null)
            {
                _context.Remove(productos);
                _context.SaveChanges();
            }
        }

        public Producto GetProducto(int Id)
        {
            return _context.Productos.FirstOrDefault(x => x.Id == Id);
        }
    }
}
