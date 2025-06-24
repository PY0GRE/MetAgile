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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MantenimientoEquipos
{
    public partial class EstandarizacionComponentes : Form
    {
        public EstandarizacionComponentes()
        {
            InitializeComponent();

            // Es contraseña
            PlaceholderHelper.SetPlaceholder(estandarTextBox1, "placeHolder", true);

            // No es contraseña
            PlaceholderHelper.SetPlaceholder(estandarTextBox2, "placeHolder2");
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
