using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ubicacion
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public string Descripcion { get; set; }
        public int IdAlmacen {  get; set; }
        public Almacen Almacen {  get; set; }
        public ICollection<Inventario> Inventarios { get; set; }
    }
}
