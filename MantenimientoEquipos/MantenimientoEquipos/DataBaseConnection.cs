using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoEquipos
{
    public static class DataBaseConnection
    {
        public static string ConnectionString { get; set; } = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MetAgile;Integrated Security=True;Encrypt=False";
    }
}
