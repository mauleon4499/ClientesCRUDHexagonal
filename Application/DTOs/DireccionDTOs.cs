using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.DTOs
{
    public class DireccionDTOs
    {
    }

    public class DireccionDTO
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string CP { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }

        public string DireccionCompleta => $"{Calle}, {Numero}, {CP}, {Ciudad}, {Provincia}";
    }

    public class CrearDireccionDTO
    {
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string CP { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
    }

    public class UpdateDireccionDTO
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string CP { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
    }

}
