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
    public partial class ValidarUsuario : Form
    {
        public ValidarUsuario()
        {
            InitializeComponent();

            DGBDatos.ColumnCount = 5;

            DGBDatos.Columns[0].Name = "Usuario";
            DGBDatos.Columns[1].Name = "Password";
            DGBDatos.Columns[2].Name = "Rol";
            DGBDatos.Columns[3].Name = "Telefono";
            DGBDatos.Columns[4].Name = "Direccion";

            // Botón Editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            DGBDatos.Columns.Add(btnEditar);

            // Botón Eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            DGBDatos.Columns.Add(btnEliminar);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            
            this.Close();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            ServiceReference2.TiendaSoapClient servicio = new ServiceReference2.TiendaSoapClient();

            string usuario = txtUsuarioValidar.Text.Trim();

            if (usuario == "")
            {
                MessageBox.Show("Ingrese un usuario");
                return;
            }

            var datos = servicio.ObtenerUsuarioCompleto(usuario);

            DGBDatos.Rows.Clear();

            if (datos.Length == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }

            foreach (var d in datos)
            {
                DGBDatos.Rows.Add(d.Usuario, d.Password, d.Rol, d.Telefono, d.Direccion);
            }
        }

        private void DGBDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string usuario = DGBDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
            string telefono = DGBDatos.Rows[e.RowIndex].Cells[3].Value.ToString();
            string direccion = DGBDatos.Rows[e.RowIndex].Cells[4].Value.ToString();

            // ELIMINAR
            if (DGBDatos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                MessageBox.Show("Eliminar registro de: " + usuario);
            }

            // EDITAR
            if (DGBDatos.Columns[e.ColumnIndex].Name == "Editar")
            {
                MessageBox.Show("Editar registro de: " + usuario);
            }
        }
    }
}
