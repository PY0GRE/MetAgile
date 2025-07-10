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

namespace MantenimientoEquipos.Views.CRUDAreas
{
    public partial class UpdateAreasView : Form
    {
        string con = DataBaseConnection.ConnectionString;
        string areaId;
        public UpdateAreasView()
        {
            InitializeComponent();

        }
        public UpdateAreasView(string id)
        {
            InitializeComponent();
            areaId = id;
            TxtId.Text = areaId;
            LoadAreaData();
        }
        private void LoadAreaData()
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("SELECT name, description FROM Areas WHERE idArea = @id", cn);
                cmd.Parameters.AddWithValue("@id", areaId);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TxtNombreArea.Text = reader["name"].ToString();
                    TxtDescripcion.Text = reader["description"].ToString();
                }
            }
        }
        private void BttRegresar_Click(object sender, EventArgs e)
        {
            new MenuAreas().Show();
            this.Hide();
        }

        private void BttAceptarCambio_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Areas SET name = @name, description = @description WHERE idArea = @id", cn);
                    cmd.Parameters.AddWithValue("@name", TxtNombreArea.Text);
                    cmd.Parameters.AddWithValue("@description", TxtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@id", areaId);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Área actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new MenuAreas().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el área: " + ex.Message);
            }
        }

        private void UpdateAreasView_Load(object sender, EventArgs e)
        {

        }
    }
}
