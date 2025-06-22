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

namespace MantenimientoEquipos
{
    public partial class RegistroEquipos : Form
    {
        public RegistroEquipos()
        {
            InitializeComponent();
            this.Load += RegistroEquipos_Load;
        }

        private void RegistroEquipos_Load(object sender, EventArgs e)
        {
            CargarEquipos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string tipo = txtTipo.Text.Trim();
            DateTime fecha = dtpFecha.Value;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(tipo))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            string conexion = "Data Source=.;Initial Catalog=InventarioEquipos;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Equipos (Nombre, Tipo, FechaAdquisicion) VALUES (@nombre, @tipo, @fecha)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Equipo registrado correctamente.");

                    txtNombre.Clear();
                    txtTipo.Clear();
                    dtpFecha.Value = DateTime.Today;
                    txtNombre.Focus();

                    CargarEquipos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }

        private void CargarEquipos()
        {
            string conexion = "Data Source=.;InitialCatalog=InventarioEquipos;IntegratedSecurity=True";
            string query = "SELECT * FROM Equipos";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvEquipos.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }
    }
}
