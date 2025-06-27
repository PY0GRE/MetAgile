using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MantenimientoEquipos.ModifierComponents
{
    public class EstandarButton : Button
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

        public EstandarButton()
        {
            this.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.BackColor = SystemColors.MenuHighlight;
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            Height = 35;
        }
    }
}
