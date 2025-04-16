using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.DTOs
{
    public class ClienteDTOs
    {
    }

    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int IdDireccion { get; set; }
    }

    public class ObtenerClienteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
    }

    public class CrearClienteDTO
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int IdDireccion { get; set; }
    }

    public class UpdateClienteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int IdDireccion { get; set; }
    }

}
