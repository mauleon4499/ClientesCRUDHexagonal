using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Direccion
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string CP { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
    }
}
