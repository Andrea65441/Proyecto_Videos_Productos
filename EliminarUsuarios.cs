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
    public partial class EliminarUsuarios : Form
    {
        public EliminarUsuarios()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                TiendaSoapClient servicio = new TiendaSoapClient();

                string usuario = txtEliminar.Text.Trim();

                if (usuario == "")
                {
                    MessageBox.Show("Ingrese el usuario a eliminar");
                    return;
                }

                string respuesta = servicio.EliminarUsuario(usuario);

                MessageBox.Show(respuesta);

                txtEliminar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();

            menu.Show();
        }
    }
}
