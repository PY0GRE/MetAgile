using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MantenimientoEquipos.Views.CRUDAreas;
using System.Xml.Linq;

namespace MantenimientoEquipos.Views.CRUDAreas
{
    public partial class MenuAreas : Form
    {
        public MenuAreas()
        {
            InitializeComponent();
        }

        private void bttUsuariosRegresar_Click(object sender, EventArgs e)
        {
            new AgregarArea().Show();
            this.Hide();
        }
        private void AreasView_Load(object sender, EventArgs e)
        {
            _visualizeData();
        }
        string con = DataBaseConnection.ConnectionString;
        private void _visualizeData()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(con))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT idArea, name AS 'Nombre del Área', description AS 'Descripción' FROM Areas", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);
                DataMenuAreas.DataSource = dt;

                DataMenuAreas.ClearSelection();

                if (DataMenuAreas.Columns.Contains("idArea"))
                {
                    DataMenuAreas.Columns["idArea"].Visible = false;
                }
            }
        }

        private void DataMenuAreas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = DataMenuAreas.Rows[e.RowIndex];
                txtId.Text = row.Cells["idArea"]?.Value?.ToString() ?? string.Empty;
            }
        }

        private void TxtAreaId_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttAreasModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Selecciona un área para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                new UpdateAreasView(txtId.Text).Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar modificar el área.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
