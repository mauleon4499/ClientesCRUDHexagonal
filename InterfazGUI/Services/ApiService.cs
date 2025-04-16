using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AppLogic.DTOs;
using MySqlConnector;
using Newtonsoft.Json;

namespace InterfazGUI.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:4499/"); //LA URL SE DEFINE EN EL PROYECTO WebAPI/Program.cs (builder.WebHost.UseUrls("https://localhost:4499");)
        }

        public async Task<List<ObtenerClienteDTO>> GetClientesAsync()
        {

            var lista = new List<ObtenerClienteDTO>();
            var connectionString = AppLogic.CONSTANTES.CONEXION;

            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT C.ID, C.NOMBRE, C.EMAIL, C.ID_DIRECCION, CONCAT(D.CALLE, ' - ',  D.CP, ' - ', D.CIUDAD, ' - ', D.NUMERO, ' - ', D.PROVINCIA) as DIRECCION" +
                                " FROM CLIENTES C" +
                                " INNER JOIN DIRECCION D ON D.ID = C.ID_DIRECCION";

                using (var command = new MySqlCommand(query, connection))
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var cliente = new ObtenerClienteDTO
                        {
                            Id = reader.GetInt32("Id"),
                            Nombre = reader.GetString("Nombre"),
                            Email = reader.GetString("Email"),
                            Direccion = reader.GetString("DIRECCION")
                        };

                        lista.Add(cliente);
                    }
                }
            }

            return lista;

            /*
            var response = await _httpClient.GetAsync("api/clientes");

            if(response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ClienteDTO>>(json);
            }

            throw new Exception("No se pudo obtener la lista de clientes: " + response.ReasonPhrase);
            */
        }

        public async Task<List<DireccionDTO>> GetDireccionesAsync()
        {
            var response = await _httpClient.GetAsync("api/direcciones");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<DireccionDTO>>(json);
            }

            throw new Exception("No se pudo obtener la lista de clientes: " + response.ReasonPhrase);
        }


    }
}
