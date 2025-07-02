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
    public partial class MenuMaintenance : Form
    {
        public MenuMaintenance()
        {
            InitializeComponent();
        }

        private void estandarLabel1_Click(object sender, EventArgs e)
        {

        }

        private void estandarButton1_Click(object sender, EventArgs e)
        {

        }

        private void estandarButton3_Click(object sender, EventArgs e)
        {

        }

        private void bttReturn_Click(object sender, EventArgs e)
        {
            new MainMenuView().Show();
            this.Hide();
        }
    }
}
