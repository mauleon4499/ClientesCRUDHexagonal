using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.DTOs
{
    public class UbicacionDTOs
    {
    }

    public class UbicacionDTO
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public int IdAlmacen { get; set; }
    }

    public class CrearUbicacionDTO
    {
        public string Referencia { get; set; }
        public int IdAlmacen { get; set; }
    }

    public class UpdateUbicacionDTO
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public int IdAlmacen { get; set; }
    }

}
