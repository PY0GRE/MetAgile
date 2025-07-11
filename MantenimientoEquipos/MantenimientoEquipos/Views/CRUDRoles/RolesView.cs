using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoEquipos.Views.CRUDRoles
{
    public partial class RolesView : Form
    {
        string con = DataBaseConnection.ConnectionString;

        public RolesView(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
        }

        
    }
}
