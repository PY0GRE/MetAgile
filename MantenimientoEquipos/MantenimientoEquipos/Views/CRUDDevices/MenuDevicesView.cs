using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoEquipos.Views.CRUDDevices
{
    public partial class MenuDevicesView : Form
    {
        public MenuDevicesView()
        {
            InitializeComponent();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            new DevicesView().Show();
            this.Hide();
        }

        private void bttReturn_Click(object sender, EventArgs e)
        {
            new MainMenuView().Show();
            this.Hide();
        }
    }
}
