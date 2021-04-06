using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SinergiaTest.DbContext;
using SinergiaTest.Models;
using SinergiaTest.Services.Productos;

namespace SinergiaTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _productoService;
        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("Productos/GetProductos")]
        public IEnumerable<Producto> GetProductos()
        {
            return _productoService.GetProductos();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("Productos/AddProductos")]
        public IActionResult AddProductos(Producto producto)
        {
            _productoService.AddProductos(producto);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("Productos/UpdateProductos")]
        public IActionResult UpdateProductos(Producto producto)
        {
            _productoService.UpdateProductos(producto);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("Productos/DeleteProductos")]
        public IActionResult DeleteProductos(int id)
        {
            var existingProveedor = _productoService.GetProducto(id);
            if (existingProveedor != null)
            {
                _productoService.DeleteProductos(existingProveedor.Id);
                return Ok();
            }
            return NotFound($"Productos no encontrado con ID : {existingProveedor.Id}");
        }

        [HttpGet]
        public Producto GetProducto(int id)
        {
            return _productoService.GetProducto(id);
        }
    }
}
