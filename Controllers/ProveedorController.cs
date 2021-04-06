using Microsoft.AspNetCore.Mvc;
using SinergiaTest.Models;
using SinergiaTest.Services.Proveedores;
using System.Collections.Generic;

namespace SinergiaTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProveedorController : ControllerBase
    {
        private readonly IProveedorService _proveedorService;
        public ProveedorController(IProveedorService proveedorService)
        {
            _proveedorService = proveedorService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("Proveedor/GetProveedor")]
        public IEnumerable<Proveedor> GetProveedor()
        {
            return _proveedorService.GetProveedor();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("Proveedor/AddProveedor")]
        public IActionResult AddProveedor(Proveedor proveedor)
        {
            _proveedorService.AddProveedor(proveedor);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("Proveedor/UpdateProveedor")]
        public IActionResult UpdateProveedor(Proveedor proveedor)
        {
            _proveedorService.UpdateProveedor(proveedor);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("Proveedor/DeleteProveedor")]
        public IActionResult DeleteProveedor(int id)
        {
            var existingProveedor = _proveedorService.GetProveedor(id);
            if (existingProveedor != null)
            {
                _proveedorService.DeleteProveedor(existingProveedor.Id);
                return Ok();
            }
            return NotFound($"Proveedor no encontrado con ID : {existingProveedor.Id}");
        }

        [HttpGet]
        public Proveedor GetProveedor(int id)
        {
            return _proveedorService.GetProveedor(id);
        }
    }
}
