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
    public partial class MaintenanceView : Form
    {
        string con = DataBaseConnection.ConnectionString;

        public MaintenanceView()
        {
            InitializeComponent();
            InitializePlaceholders();
        }

        private void estandarTitleLabel1_Click(object sender, EventArgs e)
        {

        }

        private void InitializePlaceholders()
        {
            //PlaceholderHelper.SetPlaceholder(cmbUser, "Nombre del usuario");
        }

        private bool ValidateFields()
        {
            if (cmbDevice.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un dispositivo", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbUser.Text) || cmbUser.Text == "Nombre del usuario")
            {
                MessageBox.Show("Por favor, ingrese el nombre del usuario", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin", "Error en fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void MaintenanceView_Load(object sender, EventArgs e)
        {
            FillComboBox("SELECT idDevice, serialNumber FROM Devices WHERE idStatus = 1", cmbDevice, "serialNumber", "idDevice");
            FillComboBox("SELECT idMaintenanceType, name FROM MaintenanceTypes", cmbType, "name", "idMaintenanceType");
            FillComboBox("SELECT idMaintenanceNature, name FROM MaintenanceNatures", cmbNature, "name", "idMaintenanceNature");
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

        private void bttAccept_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    // First get user ID based on name
                    int userId = 0;
                    //using (SqlCommand cmdUser = new SqlCommand($"SELECT idUser FROM Users WHERE name = '{txtUser.Text}'", cn))
                    {
                        /*
                        cn.Open();
                        var result = cmdUser.ExecuteScalar();
                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        */
                    }

                    SqlCommand cmd = new SqlCommand(
                        $"INSERT INTO Maintenances(idDevice, idUser, startDate, lastDate, idMaintenanceType, idMaintenanceNature, status) " +
                        $"VALUES ({cmbDevice.SelectedValue}, {userId}, '{dtpStartDate.Value:yyyy-MM-dd}', " +
                        $"'{dtpEndDate.Value:yyyy-MM-dd}', {cmbType.SelectedValue}, {cmbNature.SelectedValue}, 1)", cn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mantenimiento creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Hide();
                new MenuMaintenance().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el mantenimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            new MenuMaintenance().Show();
            this.Hide();
        }

        private void bttCancel_Click_1(object sender, EventArgs e)
        {
            new MenuMaintenance().Show();
            this.Hide();
        }

        private void bttAccept_Click_1(object sender, EventArgs e)
        {
            if ( !ValidateFields() )
                return;

            try
            {
                using ( SqlConnection cn = new SqlConnection(con) )
                {
                    // First get user ID based on name
                    int userId = 0;
                    using ( SqlCommand cmdUser = new SqlCommand($"SELECT idUser FROM Users WHERE name = '{cmbUser.Text}'", cn) )
                    {
                        cn.Open();
                        var result = cmdUser.ExecuteScalar();
                        if ( result != null )
                        {
                            userId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    SqlCommand cmd = new SqlCommand(
                        $"INSERT INTO Manteinances(idDevice, idUser, startDate, lastDate, idManType, idManNat) " +
                        $"VALUES ({cmbDevice.SelectedValue}, {userId}, '{dtpStartDate.Value:yyyy-MM-dd}', " +
                        $"'{dtpEndDate.Value:yyyy-MM-dd}', {cmbType.SelectedValue}, {cmbNature.SelectedValue})", cn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mantenimiento creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Hide();
                new MenuMaintenance().Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Error al crear el mantenimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MaintenanceView_Load_1(object sender, EventArgs e)
        {
            FillComboBox("SELECT idDevice, serialNumber FROM Devices WHERE idStatus = 1", cmbDevice, "serialNumber", "idDevice");
            FillComboBox("SELECT idManteinanceType, name FROM ManteinanceTypes", cmbType, "name", "idManteinanceType");
            FillComboBox("SELECT idManteinanceNature, name FROM ManteinanceNatures", cmbNature, "name", "idManteinanceNature");
            FillComboBox("SELECT idUser, name FROM Users WHERE idStatus = 1", cmbUser, "name", "idUser");
        }
    }




}

