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
using iTextSharp.text.xml.xmp;

namespace ExamenUnidad1FORM
{
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TiendaSoapClient servicio = new TiendaSoapClient();

            string usuario = txtUsuario.Text.Trim();
            string nuevaPass = txtNuevaContrasenia.Text.Trim();

            bool? suspendido = null;


            string respuesta = servicio.EditarUsuario(usuario, nuevaPass, suspendido);

            MessageBox.Show(respuesta);
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();

            this.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }
    }
}
