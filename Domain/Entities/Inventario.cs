using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Inventario
    {
        public int Id { get; set; }
        public int IdArticulo { get; set; }
        public Articulo Articulo { get; set; }
        public int IdUbicacion { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
