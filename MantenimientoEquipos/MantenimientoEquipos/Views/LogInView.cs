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
    public partial class LogInView : Form
    {
        public LogInView()
        {
            InitializeComponent();

            PlaceholderHelper.SetPlaceholder(txtUser, "Usuario");
            PlaceholderHelper.SetPlaceholder(txtPassword, "Contraseña", true);
        }

        private void bttAccept_Click(object sender, EventArgs e)
        {
            new MainMenuView().Show();
        }
    }
}
