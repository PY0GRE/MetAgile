using MantenimientoEquipos.ModifierComponents;
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
    public partial class DevicesView : Form
    {

        string con = DataBaseConnection.ConnectionString;

        public DevicesView()
        {
            InitializeComponent();

            // Creacion de Holders
            PlaceholderHelper.SetPlaceholder(txtSerieNum, "Número de serie del dispositivo");
            PlaceholderHelper.SetPlaceholder(txtModel, "Modelo del dispositivo");

        }

        private bool RequieredComponent(EstandarTextBox Entry, string Name, string PlaceHolder)
        {
            if (String.IsNullOrWhiteSpace(Entry.Text) || Entry.Text == PlaceHolder)
            {
                MessageBox.Show($"Por favor, complete el campo {Name}", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void DevicesView_Load(object sender, EventArgs e)
        {
            FillComboBox("SELECT IdArea, name FROM Areas", cmbArea, "name", "IdArea");
            FillComboBox("SELECT idDeviceType, name FROM DeviceTypes", cmbDeviceType, "name", "idDeviceType");
            FillComboBox("SELECT idBrand, name FROM Brands", cmbBrand, "name", "idBrand");
        }

        private void FillComboBox(string query, EstadarComboBox comboBox, string displayMember, string valueMember)
        {
            using ( SqlConnection connection = new SqlConnection(con) )
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
            bool isSerieValid = RequieredComponent(txtSerieNum, "Número Serial", "Número de serie del dispositivo");
            bool isModelValid = RequieredComponent(txtModel, "Modelo", "Modelo del dispositivo");

            if ( !isSerieValid || !isModelValid )
            {
                return; // Si hay campos inválidos, no continúa
            }

            try
            {
                using ( SqlConnection cn = new SqlConnection(con) )
                {
                    SqlCommand cmd = new SqlCommand($"INSERT INTO Devices(serialNumber, model, idDeviceType, idBrand, idArea, idStatus) VALUES ('{txtSerieNum.Text}', '{txtModel.Text}', '{cmbDeviceType.SelectedValue}', {cmbBrand.SelectedValue}, {cmbArea.SelectedValue}, 1)", cn);
                    cmd.CommandType = CommandType.Text; // Codigo Miss - cmd.CommandType cn = CommandType.Text;

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                this.Hide();
                new MenuDevicesView().Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Ejecutado de Manera Erronea", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            new MenuDevicesView().Show();
            this.Hide();
        }
    }
}
