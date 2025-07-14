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
                    SqlCommand cmd = new SqlCommand($"UPDATE Manteinances SET status = 0 WHERE idManteinance = {txtId.Text}", cn);
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
                    @"SELECT M.idManteinance, D.serialNumber as 'Dispositivo', U.name as 'Usuario', 
                    M.startDate as 'Fecha Inicio', M.lastDate as 'Fecha Fin', 
                    MT.name as 'Tipo', MN.name as 'Naturaleza'
                    FROM Manteinances M
                    JOIN Devices D ON M.idDevice = D.idDevice
                    JOIN Users U ON M.idUser = U.idUser
                    JOIN ManteinanceTypes MT ON M.idManType = MT.idManteinanceType
                    JOIN ManteinanceNatures MN ON M.idManNat = MN.idManteinanceNature", cn);

                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);
                dtView.DataSource = dt;
                dtView.ClearSelection();

                if (dtView.Columns.Contains("idManteinance") )
                {
                    dtView.Columns[ "idManteinance" ].Visible = false;
                }
            }
        }

        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtView.Rows[e.RowIndex];
                txtId.Text = row.Cells[ "idManteinance" ]?.Value?.ToString() ?? string.Empty;
            }
        }

        private void MenuMaintenanceView_Load(object sender, EventArgs e)
        {
            dtView.ClearSelection();
        }

        private void bttAdd_Click_1(object sender, EventArgs e)
        {
            new MaintenanceView().Show();
            this.Hide();
        }

        private void bttModify_Click(object sender, EventArgs e)
        {
            try
            {
                if ( string.IsNullOrEmpty(txtId.Text) )
                {
                    MessageBox.Show("Seleccionar un campo a modificar", "Seleccionar un campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                new MaintenanceUpdate(txtId.Text).Show();
                this.Hide();
            }
            catch ( Exception )
            {
                MessageBox.Show("Seleccionar un campo a modificar", "Seleccionar un campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.RowIndex >= 0 )
            {
                var row = dtView.Rows[ e.RowIndex ];
                txtId.Text = row.Cells[ "idManteinance" ]?.Value?.ToString() ?? string.Empty;
            }
        }

        private void bttReturn_Click_1(object sender, EventArgs e)
        {
            new MainMenuView().Show();
            this.Hide();
        }
    }



}

