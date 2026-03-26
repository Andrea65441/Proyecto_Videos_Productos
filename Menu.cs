using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenUnidad1FORM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tiendaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
            
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta Pronto :3");
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRoles roles = new FrmRoles();
            roles.Show();
            this.Visible=false;
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUsuarios eu= new EliminarUsuarios();
            eu.Show();

            this.Close();
        }

        private void buscarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidarUsuario validarUsuario = new ValidarUsuario();
            validarUsuario.Show();
            this.Close();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.Show();

            this.Close();
        }

        private void direccionYTelefonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarDireccionTelefono rdt = new RegistrarDireccionTelefono();
            rdt.Show();
            this.Close();
        }
    }
}
