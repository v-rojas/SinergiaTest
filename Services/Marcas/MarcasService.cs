using SinergiaTest.DbContext;
using SinergiaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinergiaTest.Services.Marcas
{
    public class MarcasService : IMarcasService
    {
        private readonly ApplicationDbContext _context;

        public MarcasService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Marca AddMarca(Marca marca)
        {
            _context.Marca.Add(marca);
            _context.SaveChanges();
            return marca;
        }
        public List<Marca> GetMarca()
        {
            return _context.Marca.ToList();
        }

        public void UpdateMarca(Marca marca)
        {
            _context.Marca.Update(marca);
            _context.SaveChanges();
        }

        public void DeleteMarca(int Id)
        {
            var marca = _context.Marca.FirstOrDefault(x => x.Id == Id);
            if (marca != null)
            {
                _context.Remove(marca);
                _context.SaveChanges();
            }
        }

        public Marca GetMarca(int Id)
        {
            return _context.Marca.FirstOrDefault(x => x.Id == Id);
        }
    }
}
