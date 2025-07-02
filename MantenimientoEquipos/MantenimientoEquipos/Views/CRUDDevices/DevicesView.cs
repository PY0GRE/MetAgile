using MantenimientoEquipos.ModifierComponents;
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

        string con = DataBaseConnection.ConnectionString;

        public DevicesView(string title)
        {
            InitializeComponent();

            // Creacion de Holders

            lblTitle.Text = title;

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
