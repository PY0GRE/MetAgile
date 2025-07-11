using MantenimientoEquipos.Views.CRUDDevices;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MantenimientoEquipos.Views.CRUDMaintenance
{
    public partial class MenuMaintenance : Form
    {
        string con = DataBaseConnection.ConnectionString;

        public MenuMaintenance()
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
            new MaintenanceView().Show();
            this.Hide();
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Seleccionar un campo a modificar", "Seleccionar un campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                new MaintenanceUpdate(txtId.Text).Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccionar un campo a modificar", "Seleccionar un campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand($"UPDATE Maintenances SET status = 0 WHERE idMaintenance = {txtId.Text}", cn);
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mantenimiento dado de baja correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _visualizeData();
                txtId.Text = string.Empty;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccionar un campo válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void _visualizeData()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(con))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT M.idMaintenance, D.serialNumber as 'Dispositivo', U.name as 'Usuario', 
                    M.startDate as 'Fecha Inicio', M.lastDate as 'Fecha Fin', 
                    MT.ManType as 'Tipo', MN.ManNat as 'Naturaleza', 
                    FROM Maintenances M
                    JOIN Devices D ON M.idDevice = D.idDevice
                    JOIN Users U ON M.idUser = U.idUser
                    JOIN MaintenanceTypes MT ON M.idMaintenanceType = MT.idMaintenanceType
                    JOIN MaintenanceNatures MN ON M.idMaintenanceNature = MN.idMaintenanceNature", cn);

                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);
                dtView.DataSource = dt;
                dtView.ClearSelection();

                if (dtView.Columns.Contains("idMaintenance"))
                {
                    dtView.Columns["idMaintenance"].Visible = false;
                }
            }
        }

        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtView.Rows[e.RowIndex];
                txtId.Text = row.Cells["idMaintenance"]?.Value?.ToString() ?? string.Empty;
            }
        }

        private void MenuMaintenanceView_Load(object sender, EventArgs e)
        {
            dtView.ClearSelection();
        }
    }



}

