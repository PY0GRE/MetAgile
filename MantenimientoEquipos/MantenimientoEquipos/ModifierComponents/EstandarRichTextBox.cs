using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoEquipos.ModifierComponents
{
    public class EstandarRichTextBox : RichTextBox
    {
        public int BorderRadius { get; set; } = 20;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Crear borde redondeado
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
            path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
            path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            // Opcional: dibujar borde
            using ( Pen pen = new Pen(this.ForeColor, 1.75f) )
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pevent.Graphics.DrawPath(pen, path);
            }
        }

        public EstandarRichTextBox()
        {
            this.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(10, 10, 10, 10); // Añadir margen para el texto
        }
    }
}
