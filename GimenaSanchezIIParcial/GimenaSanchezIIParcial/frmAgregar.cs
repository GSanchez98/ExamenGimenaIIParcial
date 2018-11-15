using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GimenaSanchezIIParcial.Models;

namespace GimenaSanchezIIParcial
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Instancia de la Clase Cancion
            Cancion nuevaCancion = new Cancion();
            nuevaCancion.Nombre = txtNombre.Text;
            nuevaCancion.Artista = txtArtista.Text;
            nuevaCancion.Album = txtAlbum.Text;
            nuevaCancion.Genero = txtGenero.Text;
            nuevaCancion.AñoCreacion = txtAño.Text;

            if (Cancion.AgregarCancion(nuevaCancion))
            {
                MessageBox.Show("Se han agregado los datos con éxito");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un problema en la inserción de los datos");
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
