using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class InventarioDTOs
    {
    }

    public class InventarioDTO
    {
        public int Id { get; set; }
        public int IdArticulo { get; set; }
        public int IdUbicacion { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }

    public class CrearInventarioDTO
    {
        public int IdArticulo { get; set; }
        public int IdUbicacion { get; set; }
        public int Cantidad { get; set; }
    }

    public class UpdateInventarioDTO
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
    }

}
