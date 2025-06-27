using MantenimientoEquipos.Views.CRUDDevices;
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
    }
}
