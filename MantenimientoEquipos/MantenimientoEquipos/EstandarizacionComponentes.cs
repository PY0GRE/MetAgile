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

        string Con = "Data Source=LAPTOP-P6SV6G8N;Initial Catalog=Proba;Integrated Security=True;Encrypt=False";
        private void Aceptar_Click(object sender, EventArgs e)
        {

        }

        private void EstandarizacionComponentes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'probaDataSet.Todo' Puede moverla o quitarla según sea necesario.
            this.todoTableAdapter.Fill(this.probaDataSet.Todo);

        }
    }
}
