
using Microsoft.EntityFrameworkCore;
using SinergiaTest.Models;

namespace SinergiaTest.DbContext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Marca> Marca { get; set; }
    }
}
