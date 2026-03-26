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
    public partial class Registrar : Form
    {
        public Registrar()
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

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();

            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            TiendaSoapClient servicio = new TiendaSoapClient();

            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();
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
            txtPassword.Clear();
        }
    }
    
}
