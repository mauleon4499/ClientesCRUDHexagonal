using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public string Descripcion { get; set; }
        public string SKU { get; set; }
        public string UnidadMedida { get; set; }
        public decimal Precio { get; set; }
    }
}
