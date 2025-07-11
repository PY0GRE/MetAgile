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

namespace MantenimientoEquipos.Views.CRUDUsers
{
    public partial class MenuUsuario : Form
    {
        public MenuUsuario()
        {
            InitializeComponent();
            this.Load += new EventHandler(Usuarios_Load); // ✅ Aquí sí va
        }

        private void CargarUsuarios()
        {
            string con = DataBaseConnection.ConnectionString;

            using (SqlConnection cn = new SqlConnection(con))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT U.idUser AS ID, U.name AS Nombre, U.email AS Correo, R.name AS Rol, US.name AS Estado " +
                    "FROM Users U " +
                    "JOIN Roles R ON U.idRole = R.idRole " +
                    "JOIN UserStatus US ON U.idStatus = US.idUserStatus", cn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsuarios.DataSource = dt;
            }
        }

        private void estandarTitleLabel1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void bttUsuariosModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID"].Value);
                var updateUsuario = new UpdateUsuarios(idUsuario);
                updateUsuario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario de la tabla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            CargarUsuarios();  // Aquí recargamos los usuarios automáticamente
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            var agregarUsuario = new AgregarUsuario();
            agregarUsuario.Show();
            this.Hide();
        }

        private void bttUsuariosRegresar_Click(object sender, EventArgs e)
        {
            new MainMenuView().Show();
            this.Hide();
        }
    }
}
