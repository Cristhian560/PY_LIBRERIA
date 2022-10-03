using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES.ENTIDADES
{
    public class Producto
    {
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public string Marca { get; set; }
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public string Borrado { get; set; }
    }
}
