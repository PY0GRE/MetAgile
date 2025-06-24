using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoEquipos.ModifierComponents
{
    public class EstandarLabel : Label
    {
        public EstandarLabel()
        {
            this.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ));
            this.ForeColor = System.Drawing.Color.Black;
            this.AutoSize = true; // Permite que el label ajuste su tamaño al texto
            this.Margin = new Padding(10); // Añadir margen alrededor del texto
        }
    }
}
