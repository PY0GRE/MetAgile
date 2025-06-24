using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoEquipos.ModifierComponents
{
    public class EstadarComboBox : ComboBox
    {
        public EstadarComboBox()
        {
            Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ));
            DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
