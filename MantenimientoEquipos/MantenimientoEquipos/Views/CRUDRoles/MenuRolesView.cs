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
    public partial class MenuRolesView : Form
    {
        string con = DataBaseConnection.ConnectionString;

        public MenuRolesView()
        {
            InitializeComponent();

            _visualizeData();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            new RolesView("Agregar Rol", "0").Show();
            this.Hide();
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if ( string.IsNullOrEmpty(txtId.Text) )
                {
                    MessageBox.Show("Seleccionar un campo a modificar", "Seleccionar un campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                new RolesView("Modificar Rol",txtId.Text).Show();
                this.Hide();

            }
            catch ( Exception ex )
            {
                MessageBox.Show("Seleccionar un campo a modificar", "Seleccionar un campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            new MainMenuView().Show();
            this.Hide();
        }

        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.RowIndex >= 0 )
            {
                var row = dtView.Rows[ e.RowIndex ];

                // Verificar si las celdas no son null antes de asignar
                txtId.Text = row.Cells[ "idRole" ]?.Value?.ToString() ?? string.Empty;

            }
        }

        private void _visualizeData()
        {
            DataTable dt = new DataTable();

            using ( SqlConnection cn = new SqlConnection(con) )
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT idRole, name as 'Rol', description as 'Descripcion' FROM Roles", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);
                dtView.DataSource = dt;

                dtView.ClearSelection();

                if ( dtView.Columns.Contains("idRole") )
                {
                    dtView.Columns[ "idRole" ].Visible = false;
                }
            }
        }

        private void MenuRolesView_Load(object sender, EventArgs e)
        {
            dtView.ClearSelection();
        }
    }
}
