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
using System.Xml.Linq;

namespace MantenimientoEquipos.Views.CRUDDevices
{
    public partial class MenuDevicesView : Form
    {
        string con = DataBaseConnection.ConnectionString;

        public MenuDevicesView()
        {
            InitializeComponent();

            _visualizeData();
        }

        private void bttReturn_Click(object sender, EventArgs e)
        {
            new MainMenuView().Show();
            this.Hide();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            new DevicesView().Show();
            this.Hide();
        }


        private void bttUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if ( string.IsNullOrEmpty(txtId.Text) )
                {
                    MessageBox.Show("Seleccionar un campo a modificar", "Seleccionar un campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                new UpdateDevicesView(txtId.Text).Show();
                this.Hide();

            } catch (Exception ex)
            {
                MessageBox.Show("Seleccionar un campo a modificar", "Seleccionar un campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using ( SqlConnection cn = new SqlConnection(con) )
                {
                    SqlCommand cmd = new SqlCommand($"Update Devices set idStatus = 3 WHERE idDevice = {txtId.Text}", cn);

                    cmd.CommandType = CommandType.Text;

                    cn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _visualizeData();

                txtId.Text = string.Empty;
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Seleccionar un campo valido", "Seleccionar un campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttActive_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand($"Update Devices set idStatus = 1 WHERE idDevice = {txtId.Text}", cn);

                    cmd.CommandType = CommandType.Text;

                    cn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                }

                _visualizeData();

                txtId.Text = string.Empty;

            } catch (Exception ex)
            {
                MessageBox.Show("Seleccionar un campo valido", "Seleccionar un campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void _visualizeData()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(con))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT D.idDevice, D.serialNumber as 'Número de Serie', DT.name as 'Tipo de Dispositivo', B.name as 'Marca', D.model as 'Modelo', A.name as 'Área', DS.name as 'Estado' FROM Devices D, DeviceTypes DT, Brands B, DeviceStatus DS, Areas A WHERE D.idDeviceType = DT.idDeviceType AND D.idBrand = B.idBrand AND D.idStatus = DS.idDeviceStatus AND D.idArea = A.idArea", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);
                dtView.DataSource = dt;

                dtView.ClearSelection();

                if ( dtView.Columns.Contains("idDevice") )
                {
                    dtView.Columns[ "idDevice" ].Visible = false;
                }
            }
        }

        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.RowIndex >= 0 )
            {
                var row = dtView.Rows[ e.RowIndex ];

                // Verificar si las celdas no son null antes de asignar
                txtId.Text = row.Cells[ "idDevice" ]?.Value?.ToString() ?? string.Empty;

            }
        }

        private void MenuDevicesView_Load(object sender, EventArgs e)
        {
            dtView.ClearSelection();
        }
    }
}
