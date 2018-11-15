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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresarCanciones_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.Show();
        }

        private void btnEliminarcanciones_Click(object sender, EventArgs e)
        {
            frmEliminar elimina = new frmEliminar();
            elimina.Show();
        }

        private void btnReporteCanciones_Click(object sender, EventArgs e)
        {
            frmReporte reporte = new frmReporte();
            reporte.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
