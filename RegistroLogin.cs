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
    public partial class RegistroLogin : Form
    {
        public RegistroLogin()
        {
            InitializeComponent();

            TiendaSoapClient servicio = new TiendaSoapClient();

            var roles = servicio.ObtenerRoles();

            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "strValor";
            cmbRoles.ValueMember = "idRoles";

            DGVDatosAsignados.ColumnCount = 3;

            DGVDatosAsignados.Columns[0].Name = "Usuario";
            DGVDatosAsignados.Columns[1].Name = "Password";
            DGVDatosAsignados.Columns[2].Name = "Rol";

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            TiendaSoapClient servicio = new TiendaSoapClient();

            string usuario = txtUsuario.Text;
            string password = txtPasssword.Text;
            int idRol = Convert.ToInt32(cmbRoles.SelectedValue);
            string rolNombre = cmbRoles.Text;

            string respuesta = servicio.RegistrarUsuario(usuario, password, idRol);

            MessageBox.Show(respuesta);

            if (respuesta.Contains("correctamente"))
            {
                DGVDatosAsignados.Rows.Add(usuario, password, rolNombre);
            }

            txtUsuario.Clear();
            txtPasssword.Clear();
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormLogin login = new FormLogin();
            login.Show();

            this.Close();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            TiendaSoapClient servicio = new TiendaSoapClient();

            string usuario = txtUsuario.Text.Trim();
            string password = txtPasssword.Text.Trim();
            int idRol = Convert.ToInt32(cmbRoles.SelectedValue);
            string rolNombre = cmbRoles.Text;

            if (usuario == "" || password == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            string respuesta = servicio.RegistrarUsuario(usuario, password, idRol);

            MessageBox.Show(respuesta);

            if (respuesta.Contains("correctamente"))
            {
                DGVDatosAsignados.Rows.Add(usuario, password, rolNombre);
            }

            txtUsuario.Clear();
            txtPasssword.Clear();
        }
    }
}
