using MantenimientoEquipos.Views.CRUDAreas;
using MantenimientoEquipos.Views.CRUDDevices;
using MantenimientoEquipos.Views.CRUDRoles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoEquipos.Views
{
    public partial class MainMenuView : Form
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        private void bttDevices_Click(object sender, EventArgs e)
        {
            new MenuDevicesView().Show();
            this.Hide();
        }

        private void bttMenteinnance_Click(object sender, EventArgs e)
        {
            new MenuMaintenance().Show();
            this.Hide();
        }

        private void bttRole_Click(object sender, EventArgs e)
        {
            new MenuRolesView().Show();
            this.Hide();
        }

        private void bttAreas_Click(object sender, EventArgs e)
        {
            new AgregarArea().Show();
            this.Hide();
        }

        private void MainMenuView_Load(object sender, EventArgs e)
        {

        }
    }
}
