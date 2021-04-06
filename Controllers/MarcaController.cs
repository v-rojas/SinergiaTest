using Microsoft.AspNetCore.Mvc;
using SinergiaTest.Models;
using SinergiaTest.Services.Marcas;
using System.Collections.Generic;

namespace SinergiaTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcasService _marcaService;
        public MarcaController(IMarcasService marcaService)
        {
            _marcaService = marcaService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("Marca/GetMarca")]
        public IEnumerable<Marca> GetMarca()
        {
            return _marcaService.GetMarca();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("Marca/AddMarca")]
        public IActionResult AddMarca(Marca marca)
        {
            _marcaService.AddMarca(marca);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("Marca/UpdateMarca")]
        public IActionResult UpdateMarca(Marca marca)
        {
            _marcaService.UpdateMarca(marca);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("Marca/DeleteMarca")]
        public IActionResult DeleteMarca(int id)
        {
            var existingMarca = _marcaService.GetMarca(id);
            if (existingMarca != null)
            {
                _marcaService.DeleteMarca(existingMarca.Id);
                return Ok();
            }
            return NotFound($"Marca no encontrada con ID : {existingMarca.Id}");
        }

        [HttpGet]
        public Marca GetMarca(int id)
        {
            return _marcaService.GetMarca(id);
        }
    }
}
