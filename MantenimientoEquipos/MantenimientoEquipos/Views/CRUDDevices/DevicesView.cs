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
    public partial class DevicesView : Form
    {
        public DevicesView()
        {
            InitializeComponent();

            // Creacion de Holders

            PlaceholderHelper.SetPlaceholder(txtSerieNum, "Número de serie del dispositivo");
            PlaceholderHelper.SetPlaceholder(txtModel, "Modelo del dispositivo");
           
        }

        private void bttAccept_Click(object sender, EventArgs e)
        {
            new MenuDevicesView().Show();
            this.Hide();
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            new MenuDevicesView().Show();
            this.Hide();
        }
    }
}
