using SinergiaTest.DbContext;
using SinergiaTest.Models;
using SinergiaTest.Services.Proveedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinergiaTest.Services.Categorias
{
    public class ProveedoresService : IProveedorService
    {
        private readonly ApplicationDbContext _context;

        public ProveedoresService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Proveedor AddProveedor(Proveedor proveedor)
        {
            _context.Proveedor.Add(proveedor);
            _context.SaveChanges();
            return proveedor;
        }
        public List<Proveedor> GetProveedor()
        {
            return _context.Proveedor.ToList();
        }

        public void UpdateProveedor(Proveedor proveedor)
        {
            _context.Proveedor.Update(proveedor);
            _context.SaveChanges();
        }

        public void DeleteProveedor(int Id)
        {
            var proveedor = _context.Proveedor.FirstOrDefault(x => x.Id == Id);
            if (proveedor != null)
            {
                _context.Remove(proveedor);
                _context.SaveChanges();
            }
        }

        public Proveedor GetProveedor(int Id)
        {
            return _context.Proveedor.FirstOrDefault(x => x.Id == Id);
        }
    }
}
