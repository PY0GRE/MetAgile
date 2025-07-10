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

namespace MantenimientoEquipos.Views.CRUDAreas
{
    public partial class AgregarArea : Form
    {
        string con = DataBaseConnection.ConnectionString;
        public AgregarArea()
        {
            InitializeComponent();


            // Placeholders
            PlaceholderHelper.SetPlaceholder(txtNombreArea, "Nombre del área");
            PlaceholderHelper.SetPlaceholder(txtDescripcion, "Descripción del área");

        }

        private bool RequieredComponent(EstandarTextBox entry, string fieldName, string placeHolder)
            {
            if (string.IsNullOrWhiteSpace(entry.Text) || entry.Text == placeHolder)
            {
                MessageBox.Show($"Por favor, complete el campo {fieldName}", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnNuevoRol_Click(object sender, EventArgs e)
        {
            bool isNombreOk = RequieredComponent(txtNombreArea, "Nombre del área", "Nombre del área");
            bool isDescripcionOk = RequieredComponent(txtDescripcion, "Descripción", "Descripción del área");

            if (!isNombreOk || !isDescripcionOk) return;

            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Areas (name, description) VALUES (@name, @description)", cn);

                    cmd.Parameters.AddWithValue("@name", txtNombreArea.Text.Trim());
                    cmd.Parameters.AddWithValue("@description", txtDescripcion.Text.Trim());

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Área registrada exitosamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtNombreArea.Text = "";
                txtDescripcion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el área.\n{ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Areas_Load(object sender, EventArgs e)
        {
            
        }

        private void estandarButton1_Click(object sender, EventArgs e)
        {
            new MainMenuView().Show();
            this.Hide();
        }

        private void BttMenuAreas_Click(object sender, EventArgs e)
        {
            new MenuAreas().Show();
            this.Hide();
        }
    }
}

