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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MantenimientoEquipos.Views
{
    public partial class LogInView : Form
    {

        SqlConnection conx = new SqlConnection(DataBaseConnection.ConnectionString);

        public LogInView()
        {
            InitializeComponent();

            PlaceholderHelper.SetPlaceholder(txtUser, "Usuario");
            PlaceholderHelper.SetPlaceholder(txtPassword, "Contraseña", true);
        }

        private void bttAccept_Click(object sender, EventArgs e)
        {
            ValidarUsuario(txtUser.Text, txtPassword.Text);
        }

        private void ValidarUsuario(string usuario, string passw)
        {
            try
            {
                conx.Open();

                SqlCommand consult = new SqlCommand("Select idUser FROM Users Where idUser = @usua and password = @pass and idStatus = 1", conx);

                consult.Parameters.AddWithValue("usua", usuario);
                consult.Parameters.AddWithValue("pass", passw);

                SqlDataAdapter sd = new SqlDataAdapter(consult);

                DataTable dt = new DataTable();

                sd.Fill(dt);

                // Mesages para verificar
                //MessageBox.Show(sd.Fill(dt).ToString() + usuario + passw);

                //Console.WriteLine(sd.Fill(dt).ToString());

                if ( dt.Rows.Count == 1 )
                {
                    //this.Hide();
                    String cad = dt.Rows[ 0 ][ 0 ].ToString();
                    if ( cad == "1" )
                    {
                        Console.WriteLine(dt.Rows[ 0 ][ 0 ].ToString());
                        MainMenuView admin = new MainMenuView();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos Incorrectos");
                    }
                }
            }
            catch ( Exception e )
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conx.Close();
            }
        }
    }
}
