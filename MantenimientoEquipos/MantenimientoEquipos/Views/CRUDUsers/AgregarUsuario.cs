using MantenimientoEquipos.ModifierComponents;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MantenimientoEquipos.Views.CRUDUsers
{
    public partial class AgregarUsuario : Form
    {
        string con = DataBaseConnection.ConnectionString;

        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
                cn.Open();

                // Cargar Roles
                SqlCommand cmdRoles = new SqlCommand("SELECT idRole, name FROM Roles", cn);
                SqlDataReader readerRoles = cmdRoles.ExecuteReader();
                while (readerRoles.Read())
                {
                    cbRol.Items.Add(new ComboboxItem
                    {
                        Text = readerRoles["name"].ToString(),
                        Value = readerRoles["idRole"]
                    });
                }
                readerRoles.Close();

                // Cargar Estados (Estatus)
                SqlCommand cmdStatus = new SqlCommand("SELECT idUserStatus, name FROM UserStatus", cn);
                SqlDataReader readerStatus = cmdStatus.ExecuteReader();
                while (readerStatus.Read())
                {
                    cbStatus.Items.Add(new ComboboxItem
                    {
                        Text = readerStatus["name"].ToString(),
                        Value = readerStatus["idUserStatus"]
                    });
                }
            }
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            bool isNombreOk = !string.IsNullOrWhiteSpace(txtNombreCompleto.Text);
            bool isCorreoOk = !string.IsNullOrWhiteSpace(txtCorreo.Text);
            bool isContraseñaOk = !string.IsNullOrWhiteSpace(txtContraseña.Text);
            bool isRolOk = cbRol.SelectedItem != null;
            bool isStatusOk = cbStatus.SelectedItem != null;

            if (!isNombreOk || !isCorreoOk || !isContraseñaOk || !isRolOk || !isStatusOk)
            {
                MessageBox.Show("Completa todos los campos antes de guardar.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Users (name, email, idRole, password, idStatus) " +
                        "VALUES (@name, @email, @rol, @password, @status)", cn);

                    cmd.Parameters.AddWithValue("@name", txtNombreCompleto.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@rol", ((ComboboxItem)cbRol.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@password", txtContraseña.Text.Trim());
                    cmd.Parameters.AddWithValue("@status", ((ComboboxItem)cbStatus.SelectedItem).Value);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreCompleto.Clear();
                txtCorreo.Clear();
                txtContraseña.Clear();
                cbRol.SelectedIndex = -1;
                cbStatus.SelectedIndex = -1;

                // Opcional: recargar la pantalla de usuarios automáticamente si la tienes abierta
                // Por ejemplo, podrías tener un evento para notificar la actualización
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el usuario.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BttMenuUsuario_Click(object sender, EventArgs e)
        {
            var menuUsuarios = new MenuUsuario();
            menuUsuarios.Show();
            this.Hide();
        }

        private void BttRegresar_Click(object sender, EventArgs e)
        {
            new MainMenuView().Show();
            this.Hide();
        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {
            // Evento vacío, lo puedes eliminar del diseñador si no lo usas
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // Evento vacío, lo puedes eliminar del diseñador si no lo usas
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                cbRol.SelectedItem == null ||
                cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Users (name, email, idRole, password, idStatus) " +
                        "VALUES (@name, @correo, @rol, @password, @status)", cn);

                    cmd.Parameters.AddWithValue("@name", txtNombreCompleto.Text.Trim());
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtContraseña.Text.Trim());
                    cmd.Parameters.AddWithValue("@rol", ((ComboboxItem)cbRol.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@status", ((ComboboxItem)cbStatus.SelectedItem).Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                txtNombreCompleto.Clear();
                txtCorreo.Clear();
                txtContraseña.Clear();
                cbRol.SelectedIndex = -1;
                cbStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
