using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLogic.DTOs;
using DevExpress.XtraEditors;
using InterfazGUI.Services;

namespace InterfazGUI.Views
{
    public partial class ClientesForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ApiService _apiService = new ApiService();

        public ClientesForm()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarClientesAsync();
        }

        private async void CargarClientesAsync()
        {
            try
            {
                var clientes = await _apiService.GetClientesAsync();
                gridClientes.DataSource = clientes;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes " + ex.Message);
            }
        }

        public async Task CrearClienteAsync(ClienteDTO nuevoCliente)
        {
            try
            {
                var response = await _apiService.PostClienteAsync(nuevoCliente);
                if (response)
                {
                    MessageBox.Show("Cliente creado correctamente.");
                    CargarClientesAsync(); // Para refrescar la lista
                }
                else
                {
                    MessageBox.Show("Error al crear cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}