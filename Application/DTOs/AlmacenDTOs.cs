using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class AlmacenDTOs
    {
    }

    public class AlmacenDTO
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public int IdDireccion { get; set; }
    }

    public class CrearAlmacenDTO
    {
        public string Referencia { get; set; }
        public int IdDireccion { get; set; }
    }

    public class UpdateAlmacenDTO
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public int IdDireccion { get; set; }
    }

}
