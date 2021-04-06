using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SinergiaTest.Models;

namespace SinergiaTest.Services.Marcas
{
    public interface IMarcasService
    {
        Marca AddMarca(Marca marca);

        List<Marca> GetMarca();

        void UpdateMarca(Marca marca);

        void DeleteMarca(int Id);

        Marca GetMarca(int Id);
    }
}
