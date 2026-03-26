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
    public partial class RegistrarDireccionTelefono : Form
    {
        public RegistrarDireccionTelefono()
        {
            InitializeComponent();

            DGVDatos.ColumnCount = 3;

            DGVDatos.Columns[0].Name = "Usuario";
            DGVDatos.Columns[1].Name = "Telefono";
            DGVDatos.Columns[2].Name = "Direccion";

            
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu ();
            menu.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ServiceReference2.TiendaSoapClient servicio = new ServiceReference2.TiendaSoapClient();

            string usuario = txtUsuario.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            if (usuario == "")
            {
                MessageBox.Show("Ingrese el nombre de usuario");
                return;
            }

            if (telefono == "" && direccion == "")
            {
                MessageBox.Show("Ingrese al menos teléfono o dirección");
                return;
            }

            string respuesta = servicio.AgregarDireccionTelefono(usuario, telefono, direccion);

            MessageBox.Show(respuesta);

            txtTelefono.Clear();
            txtDireccion.Clear();

            if (respuesta.Contains("correctamente"))
            {
                DGVDatos.Rows.Add(usuario, telefono, direccion);
            }
        }

        
    }
}
