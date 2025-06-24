using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoEquipos.ModifierComponents
{
    public class EstandarTitleLabel : Label
    {
        public EstandarTitleLabel()
        {
            this.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ));
            this.ForeColor = SystemColors.MenuHighlight;
            this.AutoSize = true; // Permite que el label ajuste su tamaño al texto
            this.Margin = new Padding(10); // Añadir margen alrededor del texto
        }
    }
}
