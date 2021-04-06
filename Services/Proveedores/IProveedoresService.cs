using SinergiaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinergiaTest.Services.Proveedores
{
    public interface IProveedorService
    {
        Proveedor AddProveedor(Proveedor proveedores);

        List<Proveedor> GetProveedor();

        void UpdateProveedor(Proveedor proveedores);

        void DeleteProveedor(int Id);

        Proveedor GetProveedor(int Id);
    }
}
