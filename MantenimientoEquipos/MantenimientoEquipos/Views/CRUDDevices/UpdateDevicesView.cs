using MantenimientoEquipos.ModifierComponents;
using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MantenimientoEquipos.Views.CRUDDevices
{
    public partial class UpdateDevicesView : Form
    {
        string con = DataBaseConnection.ConnectionString;

        string IdComponent;

        public UpdateDevicesView(string id)
        {
            InitializeComponent();

            IdComponent = id;

            // Creacion de Holders
            PlaceholderHelper.SetPlaceholder(txtSerieNum, "Número de serie del dispositivo");
            PlaceholderHelper.SetPlaceholder(txtModel, "Modelo del dispositivo");
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuDevicesView().Show();
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
                    SqlCommand cmd = new SqlCommand($"UPDATE Devices SET serialNumber = '{txtSerieNum.Text}', model = '{txtModel.Text}', idDeviceType = {cmbDeviceType.SelectedValue}, idBrand = {cmbBrand.SelectedValue}, idArea = {cmbArea.SelectedValue}  WHERE idDevice = {IdComponent}", cn);

                    cmd.CommandType = CommandType.Text;

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

        private bool RequieredComponent(EstandarTextBox Entry, string Name, string PlaceHolder)
        {
            if ( String.IsNullOrWhiteSpace(Entry.Text) || Entry.Text == PlaceHolder )
            {
                MessageBox.Show($"Por favor, complete el campo {Name}", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void UpdateDevicesView_Load(object sender, EventArgs e)
        {
            FillComboBox("SELECT idArea, name FROM Areas", cmbArea, "name", "IdArea");
            FillComboBox("SELECT idDeviceType, name FROM DeviceTypes", cmbDeviceType, "name", "idDeviceType");
            FillComboBox("SELECT idBrand, name FROM Brands", cmbBrand, "name", "idBrand");

            FillCmbData($"SELECT A.idArea FROM Areas A, Devices D WHERE D.idArea = A.idArea AND D.idDevice = {IdComponent}", cmbArea);
            FillCmbData($"SELECT DV.idDeviceType FROM DeviceTypes DV, Devices D WHERE D.idDeviceType = DV.idDeviceType AND D.idDevice = {IdComponent}", cmbDeviceType);
            FillCmbData($"SELECT B.idBrand FROM Brands B, Devices D WHERE D.idBrand = B.idBrand AND D.idDevice = {IdComponent}", cmbBrand);

            FillTxtData($"SELECT serialNumber FROM Devices WHERE idDevice = {IdComponent}", txtSerieNum);
            FillTxtData($"SELECT model FROM Devices WHERE idDevice = {IdComponent}", txtModel);
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

        private void FillCmbData(string query, EstadarComboBox comboBox)
        {
            int id = -1;
            using ( SqlConnection cn = new SqlConnection(con) )
            {
                string qy = query;

                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();

                object result = cmd.ExecuteScalar();
                if ( result != null )
                {
                    id = Convert.ToInt32(result);
                }
            }

            if ( id != -1 )
            {
                comboBox.SelectedValue = id;
            }
        }

        private void FillTxtData(string query, EstandarTextBox textBox)
        {
            using ( SqlConnection cn = new SqlConnection(con) )
            {
                string qy = query;

                SqlCommand cmd = new SqlCommand(qy, cn);
                cn.Open();

                object result = cmd.ExecuteScalar();
                if ( result != null )
                {
                    textBox.Text = result.ToString();
                }
            }

            textBox.ForeColor = Color.Black; // Asegurarse de que el texto no sea gris
        }
    }
}
