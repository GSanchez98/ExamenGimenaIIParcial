using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Agregar los namespaces necesarios
using System.Data.SqlClient;

namespace GimenaSanchezIIParcial
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            /*SqlConnection conn = new SqlConnection(@"server = (local)\SQLEXPRESS01;
                                 integrated security = true; database = BulletProofRecords;");

            // Creamos el query de selección de la tabla Products
            string sql1 = "Select * FROM Music.Cancion";

            // Creamos el comando
            SqlCommand cmd = new SqlCommand(sql1, conn);

            // establecemos la conexión y llenado el dataGridView
            try
            {
                // abrimos la conexión.
                conn.Open();

                // Ejecutamos el query via un DataReader y llenamo el Grid.
                SqlDataReader rdr = cmd.ExecuteReader();

                // llenamos el DataGeid
                while (rdr.Read())
                {
                    dataGridView1.RowsAdded;

                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la exepción");

            }
            finally
            {
                // Cerramos la conexión.
                conn.Close();
            }*/
        }
    }
}
