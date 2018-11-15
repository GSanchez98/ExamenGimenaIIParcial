using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimenaSanchezIIParcial
{
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Instanciamos la Clase Cliente
            GimenaSanchezIIParcial.Models.Cancion eliminar = new GimenaSanchezIIParcial.Models.Cancion();

            eliminar.id = txtCodigo.Text;

            if ( GimenaSanchezIIParcial.Models.Cancion.EliminarCancion(eliminar))
            {
                MessageBox.Show("Registro eliminado con exito");
            }
            else
            {
                MessageBox.Show("Error al eliminar Registro");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal llamado = new frmPrincipal();
            llamado.Show();
        }
    }
}
