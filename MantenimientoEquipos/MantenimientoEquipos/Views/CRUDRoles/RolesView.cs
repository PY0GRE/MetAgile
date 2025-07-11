using MantenimientoEquipos.ModifierComponents;
using MantenimientoEquipos.Views.CRUDDevices;
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

namespace MantenimientoEquipos.Views.CRUDRoles
{
    public partial class RolesView : Form
    {
        string con = DataBaseConnection.ConnectionString;

        string IdComponent;

        public RolesView(string titulo, string id)
        {
            InitializeComponent();

            lblTitle.Text = titulo;

            IdComponent = id;

            PlaceholderHelper.SetPlaceholder(txtName, "Nombre del Rol");
            PlaceholderHelper.SetRichPlaceholder(txtDescription, "Descripción del Rol");

            Console.WriteLine(IdComponent);
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            if ( IdComponent == "0" )
            {
                AddRole();
            }
            else
            {
                UpdateRole(IdComponent);
            }
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            new MenuRolesView().Show();
            this.Hide();
        }

        private bool RequieredtxtComponent(EstandarTextBox Entry, string Name, string PlaceHolder)
        {
            if ( String.IsNullOrWhiteSpace(Entry.Text) || Entry.Text == PlaceHolder )
            {
                MessageBox.Show($"Por favor, complete el campo {Name}", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private bool RequieredRtxtComponent(EstandarRichTextBox Entry, string Name, string PlaceHolder)
        {
            if ( String.IsNullOrWhiteSpace(Entry.Text) || Entry.Text == PlaceHolder )
            {
                MessageBox.Show($"Por favor, complete el campo {Name}", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void AddRole()
        {
            bool isSerieValid = RequieredtxtComponent(txtName, "Nombre", "Nombre del Rol");
            bool isModelValid = RequieredRtxtComponent(txtDescription, "Descripción", "Descripción del Rol");

            if ( !isSerieValid || !isModelValid )
            {
                return; // Si hay campos inválidos, no continúa
            }

            try
            {
                using ( SqlConnection cn = new SqlConnection(con) )
                {
                    SqlCommand cmd = new SqlCommand($"INSERT INTO Roles(name, description) VALUES ('{txtName.Text}', '{txtDescription.Text}')", cn);
                    cmd.CommandType = CommandType.Text; // Codigo Miss - cmd.CommandType cn = CommandType.Text;

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                this.Hide();
                new MenuRolesView().Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Ejecutado de Manera Erronea", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateRole(string id)
        {
            bool isSerieValid = RequieredtxtComponent(txtName, "Nombre", "Nombre del Rol");
            bool isModelValid = RequieredRtxtComponent(txtDescription, "Descripción", "Descripción del Rol");

            if ( !isSerieValid || !isModelValid )
            {
                return; // Si hay campos inválidos, no continúa
            }

            try
            {
                using ( SqlConnection cn = new SqlConnection(con) )
                {
                    SqlCommand cmd = new SqlCommand($"UPDATE Roles SET name = '{txtName.Text}', description = '{txtDescription.Text}' WHERE idRole = {id}", cn);

                    cmd.CommandType = CommandType.Text;

                    cn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Hide();
                new MenuRolesView().Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show($"Ejecutado de Manera Erronea {ex}", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RolesView_Load(object sender, EventArgs e)
        {
            FillTxtData($"SELECT name FROM Roles WHERE idRole = {IdComponent}", txtName);
            FillRTxtData($"SELECT description FROM Roles WHERE idRole = {IdComponent}", txtDescription);
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

        private void FillRTxtData(string query, EstandarRichTextBox textBox)
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
