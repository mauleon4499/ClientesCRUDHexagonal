using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                /*
                var gridViewClientes = gridClientes.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

                if (gridViewClientes.Columns["Dirección"] == null)
                {
                    var colDireccionCompleta = new DevExpress.XtraGrid.Columns.GridColumn
                    {
                        Caption = "Dirección",
                        FieldName = "DireccionCompleta", // Este es el nombre "virtual" interno
                        UnboundType = DevExpress.Data.UnboundColumnType.String,
                        Visible = true,
                        VisibleIndex = gridViewClientes.Columns.Count
                    };

                    // Expresión que combina los campos de la dirección
                    colDireccionCompleta.UnboundExpression =
                        "[Direccion.Calle] + ', ' + [Direccion.Numero] + ', ' + [Direccion.CP] + ', ' + [Direccion.Ciudad] + ', ' + [Direccion.Provincia]";

                    colDireccionCompleta.OptionsColumn.AllowEdit = false;

                    // Agregar la columna al GridView
                    gridViewClientes.Columns.Add(colDireccionCompleta);
                }
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes " + ex.Message);
            }
        }
        /*
        private async void CargarDireccionesAsync()
        {
            try
            {
                var direcciones = await _apiService.GetDireccionesAsync();
                gridClientes.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes " + ex.Message);
            }
        }*/
    }
}