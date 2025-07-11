using MantenimientoEquipos.ModifierComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoEquipos.Views.CRUDMaintenance
{
    public partial class MaintenanceUpdate : Form
    {
        string con = DataBaseConnection.ConnectionString;
        string maintenanceId;
        public MaintenanceUpdate(string id)
        {
            InitializeComponent();
            maintenanceId = id;
            InitializePlaceholders();
        }

        private void InitializePlaceholders()
        {
            //PlaceholderHelper.SetPlaceholder(txtUser, "Nombre del usuario");
        }

        private void UpdateMaintenanceView_Load(object sender, EventArgs e)
        {
            // Llenar comboboxes
            FillComboBox("SELECT idDevice, serialNumber FROM Devices WHERE idStatus = 1", cmbDevice, "serialNumber", "idDevice");
            FillComboBox("SELECT idMaintenanceType, name FROM MaintenanceTypes", cmbType, "name", "idMaintenanceType");
            FillComboBox("SELECT idMaintenanceNature, name FROM MaintenanceNatures", cmbNature, "name", "idMaintenanceNature");

            // Cargar datos existentes del mantenimiento
            LoadMaintenanceData();
        }

        private void LoadMaintenanceData()
        {
            string query = $@"SELECT M.idDevice, M.idUser, U.name as userName, 
                             M.startDate, M.endDate, M.idMaintenanceType, M.idMaintenanceNature
                             FROM Maintenances M
                             JOIN Users U ON M.idUser = U.idUser
                             WHERE M.idMaintenance = {maintenanceId}";

            using (SqlConnection cn = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Dispositivo
                    cmbDevice.SelectedValue = reader["idDevice"];

                    // Usuario
                    cmbUser.Text = reader["userName"].ToString();

                    // Fechas
                    dtpStartDate.Value = Convert.ToDateTime(reader["startDate"]);
                    dtpEndDate.Value = Convert.ToDateTime(reader["endDate"]);

                    // Tipo y Naturaleza
                    cmbType.SelectedValue = reader["idMaintenanceType"];
                    cmbNature.SelectedValue = reader["idMaintenanceNature"];
                }
                reader.Close();
            }
        }

        private void FillComboBox(string query, EstadarComboBox comboBox, string displayMember, string valueMember)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                comboBox.DataSource = dt;
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = valueMember;
            }
        }

        private bool ValidateFields()
        {
            if (cmbDevice.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un dispositivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbUser.Text) || cmbUser.Text == "Nombre del usuario")
            {
                MessageBox.Show("Ingrese el nombre del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void bttAccept_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                // Obtener ID del usuario
                

                using (SqlConnection cn = new SqlConnection(con))
                {
                    string query = $@"UPDATE Maintenances SET 
                                    idDevice = {cmbDevice.SelectedValue},
                                    idUser = {cmbUser.SelectedValue},
                                    startDate = '{dtpStartDate.Value:yyyy-MM-dd}',
                                    endDate = '{dtpEndDate.Value:yyyy-MM-dd}',
                                    idMaintenanceType = {cmbType.SelectedValue},
                                    idMaintenanceNature = {cmbNature.SelectedValue}
                                    WHERE idMaintenance = {maintenanceId}";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Mantenimiento actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Hide();
                new MenuMaintenance().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetUserId(string userName)
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand($"SELECT idUser FROM Users WHERE name = '{userName}'", cn);
                cn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuMaintenance().Show();
        }

        private void bttAccept_Click_1(object sender, EventArgs e)
        {
            if ( !ValidateFields() )
                return;

            try
            {
                // Obtener ID del usuario
                //int userId = GetUserId(txtUser.Text);
                //if ( userId == -1 )
                {
                  //  MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }

                using ( SqlConnection cn = new SqlConnection(con) )
                {
                    string query = $@"UPDATE Manteinances SET 
                                    idDevice = {cmbDevice.SelectedValue},
                                    idUser = {cmbUser.SelectedValue},
                                    startDate = '{dtpStartDate.Value:yyyy-MM-dd}',
                                    lastDate = '{dtpEndDate.Value:yyyy-MM-dd}',
                                    idManType = {cmbType.SelectedValue},
                                    idManNat = {cmbNature.SelectedValue}
                                    WHERE idManteinance = {maintenanceId}";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Mantenimiento actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Hide();
                new MenuMaintenance().Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttCancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new MenuMaintenance().Show();
        }

        private void MaintenanceUpdate_Load(object sender, EventArgs e)
        {
            FillComboBox("SELECT idDevice, serialNumber FROM Devices WHERE idStatus = 1", cmbDevice, "serialNumber", "idDevice");
            FillComboBox("SELECT idManteinanceType, name FROM ManteinanceTypes", cmbType, "name", "idManteinanceType");
            FillComboBox("SELECT idManteinanceNature, name FROM ManteinanceNatures", cmbNature, "name", "idManteinanceNature");
            FillComboBox("SELECT idUser, name FROM Users WHERE idStatus = 1", cmbUser, "name", "idUser");
        }
    }
}

