using SinergiaTest.DbContext;
using SinergiaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinergiaTest.Services.Categorias
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ApplicationDbContext _context;

        public CategoriaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Categoria AddCategoria(Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
            return categoria;
        }
        public List<Categoria> GetCategoria()
        {
            return _context.Categoria.ToList();
        }

        public void UpdateCategoria(Categoria categoria)
        {
            _context.Categoria.Update(categoria);
            _context.SaveChanges();
        }

        public void DeleteCategoria(int Id)
        {
            var categoria = _context.Categoria.FirstOrDefault(x => x.Id == Id);
            if (categoria != null)
            {
                _context.Remove(categoria);
                _context.SaveChanges();
            }
        }

        public Categoria GetCategoria(int Id)
        {
            return _context.Categoria.FirstOrDefault(x => x.Id == Id);
        }
    }
}
