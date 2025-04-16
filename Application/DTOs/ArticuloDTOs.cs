using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.DTOs
{
    public class ArticuloDTOs
    {
    }

    public class ArticuloDTO
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public string Descricion { get; set; }
    }

    public class CrearArticuloDTO
    {
        public string Referencia { get; set; }
        public string Descripcíon { get; set; }
    }

    public class UpdateArticuloDTO
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public string Descripcíon { get; set; }
    }

}
