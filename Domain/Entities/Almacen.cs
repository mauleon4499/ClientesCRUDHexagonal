using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Almacen
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public int IdDireccion {  get; set; }
        public Direccion Direccion { get; set; }
        public string Telefono { get; set; }
        public string Responsable {  get; set; }
        public ICollection<Ubicacion> Ubicaciones { get; set; }
    }
}
