using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MantenimientoEquipos.Views.CRUDUsers
{
    public partial class UpdateUsuarios : Form
    {
        private int usuarioId;
        string con = DataBaseConnection.ConnectionString;

        public UpdateUsuarios(int idUsuario)
        {
            InitializeComponent();
            usuarioId = idUsuario;
            LoadComboBoxes();
            LoadUserData();
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

                // Cargar Estados
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

        private void LoadUserData()
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE idUser = @id", cn);
                cmd.Parameters.AddWithValue("@id", usuarioId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNombreCompleto.Text = reader["name"].ToString();
                    txtCorreo.Text = reader["email"].ToString();
                    txtContraseña.Text = reader["password"].ToString();

                    // Seleccionar el Rol
                    foreach (ComboboxItem item in cbRol.Items)
                    {
                        if ((int)item.Value == (int)reader["idRole"])
                        {
                            cbRol.SelectedItem = item;
                            break;
                        }
                    }

                    // Seleccionar el Estado
                    foreach (ComboboxItem item in cbStatus.Items)
                    {
                        if ((int)item.Value == (int)reader["idStatus"])
                        {
                            cbStatus.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
        }

        private void bttGuardarCambios_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Users SET name=@name, email=@correo, password=@password, idRole=@rol, idStatus=@status WHERE idUser=@id", cn);
                cmd.Parameters.AddWithValue("@name", txtNombreCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtContraseña.Text.Trim());
                cmd.Parameters.AddWithValue("@rol", ((ComboboxItem)cbRol.SelectedItem).Value);
                cmd.Parameters.AddWithValue("@status", ((ComboboxItem)cbStatus.SelectedItem).Value);
                cmd.Parameters.AddWithValue("@id", usuarioId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new MenuUsuario().Show();
            this.Hide();
        }

        private void bttRegresar_Click(object sender, EventArgs e)
        {
            new MenuUsuario().Show();
            this.Hide();
        }

        // Clase para los ComboBox
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        // Métodos vacíos que ya tenías (puedes eliminarlos si no los usas)
        private void estandarTitleLabel1_Click(object sender, EventArgs e) { }
        private void estandarLabel2_Click(object sender, EventArgs e) { }
        private void txtNombreCompleto_TextChanged(object sender, EventArgs e) { }
        private void txtCorreo_TextChanged(object sender, EventArgs e) { }
        private void txtContraseña_TextChanged(object sender, EventArgs e) { }
        private void cbRol_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
