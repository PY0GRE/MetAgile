using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoEquipos.ModifierComponents
{
    public class EstandarDataView : DataGridView
    {
        public EstandarDataView()
        {
            // Estilo general
            this.BorderStyle = BorderStyle.None;
            this.BackgroundColor = Color.White;
            this.EnableHeadersVisualStyles = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToResizeRows = false;
            this.RowHeadersVisible = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilo del encabezado
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185); // Azul
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Bold);
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.ColumnHeadersHeight = 35;

            // Estilo de celdas
            this.DefaultCellStyle.BackColor = Color.White;
            this.DefaultCellStyle.ForeColor = Color.Black;
            this.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
            this.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            this.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Bordes
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridColor = Color.LightGray;

            // Alternancia de filas (opcional)
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.MultiSelect = false;
            this.ReadOnly = true;
        }
    }
}
