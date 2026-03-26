using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenUnidad1FORM.ServiceReference2;

namespace ExamenUnidad1FORM
{
    public partial class FrmRoles : Form
    {
        public FrmRoles()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();

            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TiendaSoapClient servicio = new TiendaSoapClient();

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            string respuesta = servicio.InsertarRol(nombre, descripcion);

            MessageBox.Show(respuesta);

            txtNombre.Clear();
            txtDescripcion.Clear();
        
        }
    }
}
