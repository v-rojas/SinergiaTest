using Microsoft.AspNetCore.Mvc;
using SinergiaTest.Models;
using SinergiaTest.Services.Categorias;
using System.Collections.Generic;

namespace SinergiaTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("Categoria/GetCategoria")]
        public IEnumerable<Categoria> GetCategoria()
        {
            return _categoriaService.GetCategoria();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("Categoria/AddCategoria")]
        public IActionResult AddCategoria(Categoria categoria)
        {
            _categoriaService.AddCategoria(categoria);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("Categoria/UpdateCategoria")]
        public IActionResult UpdateCategoria(Categoria categoria)
        {
            _categoriaService.UpdateCategoria(categoria);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("Categoria/DeleteCategoria")]
        public IActionResult DeleteCategoria(int id)
        {
            var existingCategoria = _categoriaService.GetCategoria(id);
            if (existingCategoria != null)
            {
                _categoriaService.DeleteCategoria(existingCategoria.Id);
                return Ok();
            }
            return NotFound($"Categoria no encontrada con ID : {existingCategoria.Id}");
        }

        [HttpGet]
        public Categoria GetCategoria(int id)
        {
            return _categoriaService.GetCategoria(id);
        }
    }
}
