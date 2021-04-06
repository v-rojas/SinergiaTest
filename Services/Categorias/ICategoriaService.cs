using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SinergiaTest.Models;

namespace SinergiaTest.Services.Categorias
{
    public interface ICategoriaService
    {
        Categoria AddCategoria(Categoria categoria);

        List<Categoria> GetCategoria();

        void UpdateCategoria(Categoria categoria);

        void DeleteCategoria(int Id);

        Categoria GetCategoria(int Id);
    }
}
