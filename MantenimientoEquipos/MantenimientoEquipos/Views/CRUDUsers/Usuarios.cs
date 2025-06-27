using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoEquipos.Views.CRUDUsers
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            this.Load += new EventHandler(Usuarios_Load); // ✅ Aquí sí va
        }

        private void estandarTitleLabel1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.Columns.Add("ID", "ID");
            dgvUsuarios.Columns.Add("Nombre", "Nombre");
            dgvUsuarios.Columns.Add("Correo", "Correo");
            dgvUsuarios.Columns.Add("Area", "Área");
            dgvUsuarios.Columns.Add("Rol", "Rol");

            dgvUsuarios.Rows.Add("U001", "Juan Pérez", "juan.perez@example.com", "Sistemas", "Administrador");
            dgvUsuarios.Rows.Add("U002", "Laura Martínez", "laura.martinez@example.com", "Ventas", "Usuario");
            dgvUsuarios.Rows.Add("U003", "Roberto Torres", "roberto.torres@example.com", "Administración", "Usuario");
        }
    }
}
