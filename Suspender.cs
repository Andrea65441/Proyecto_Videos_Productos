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
    public partial class Suspender : Form
    {
        public Suspender()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();

            this.Close();
        }

        //Suspender Usuario
        private void button1_Click(object sender, EventArgs e)
        {
            TiendaSoapClient servicio = new TiendaSoapClient(); 

            string usuario = txtUsuario.Text;

            string respuesta = servicio.SuspenderUsuario(usuario);

            MessageBox.Show(respuesta);
        }


        //Activar Usuario
        private void btnActivar_Click(object sender, EventArgs e)
        {
            TiendaSoapClient servicio = new TiendaSoapClient();

            string usuario = txtUsuario.Text;

            string respuesta = servicio.ActivarUsuario(usuario);

            MessageBox.Show(respuesta);
        }
    }
}
