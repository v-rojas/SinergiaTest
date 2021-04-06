using System.ComponentModel.DataAnnotations;

namespace SinergiaTest.Models
{
    public class Producto
    {
        public int Id { get; set; }        
        public string Nombre { get; set; }        
        public string Descripcion { get; set; }        
        public string Categoria { get; set; }        
        public string Proveedor { get; set; }        
        public string Marca { get; set; }        
        public string Medidas { get; set; }        
        public string Cantidad { get; set; }        
        public string Precio_Unitario { get; set; }
    }
}
