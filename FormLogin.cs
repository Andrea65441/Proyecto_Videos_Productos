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
    public partial class FormLogin : Form
    {


        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            TiendaSoapClient servicio = new TiendaSoapClient();

            string usuario = txtUsuario.Text.Trim();
            string pass = txtContrasena.Text.Trim();

            if (usuario == "" || pass == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            string respuesta = servicio.Login(usuario, pass);

            if (respuesta == "OK")
            {
                MessageBox.Show("Bienvenido");

                Menu menu = new Menu();
                menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

            /*
            TiendaSoapClient servicio = new TiendaSoapClient();

            string respuesta = servicio.Login(txtUsuario.Text, txtContrasena.Text);

            if (respuesta == "OK")
            {
                MessageBox.Show("Bienvenido");

                Form1 principal = new Form1();
                principal.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            */
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            TiendaSoapClient servicio = new TiendaSoapClient();

            string usuario = txtUsuario.Text.Trim();
            string pass = txtContrasena.Text.Trim();

            if (usuario == "" || pass == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            string respuesta = servicio.Login(usuario, pass);

            if (respuesta == "OK")
            {
                MessageBox.Show("Bienvenido");

                Menu menu = new Menu();
                menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

            

        }

        private void volverAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            editar.Show();

            this.SetVisibleCore(false);
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RegistroLogin rg = new RegistroLogin();
            rg.Show();
            this.Hide();
        }

        private void suspenderUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suspender suspender = new Suspender();
            suspender.Show();

            this.Hide();
        }
    }
}
