using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenUnidad1FORM.ServiceReference2;
using iTextSharp.text;
using iTextSharp.text.pdf;

using System.Drawing.Imaging;




namespace ExamenUnidad1FORM
{
    public partial class Form1 : Form
    {

        private ServiceReference2.TiendaSoapClient producto = new TiendaSoapClient();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            InsertarDatos();
        }

        byte[] imagenBytes;



        //Boton de agregar producto
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string UnidadMedia = "";
            if (rbGramos.Checked)
                UnidadMedia = "Gramos";
            else if (rbKilos.Checked)
                UnidadMedia = "Kilos";
            else if (rbLitros.Checked)
                UnidadMedia = "Litros";


            string Caducable = "";
            if (cbNoCaducable.Checked)
                Caducable = "No Caducable";
            else if (cbSiCaducable.Checked)
                Caducable = "Si Caducable";



           





            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoBarras.Text) ||
                (!rbGramos.Checked && !rbKilos.Checked && !rbLitros.Checked) ||
                (!cbNoCaducable.Checked && !cbSiCaducable.Checked) ||
                (pbImagen.Image == null))
            {
                MessageBox.Show("llena todos los campos");
                return;
            }



            if (!double.TryParse(txtPrecio.Text, out double precioNumero))
            {
                MessageBox.Show("El precio debe ser numérico");
                return;
            }



            //Guarda la imagen
            if (pbImagen.Image != null)
            {
                string rutaImagen = openFileDialog1.FileName;
                string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string carpetaDestino = Path.Combine(escritorio, "imagenes");

                Directory.CreateDirectory(carpetaDestino);

                string imagenDestino = Path.Combine(carpetaDestino, Guid.NewGuid().ToString() + Path.GetExtension(rutaImagen));
                File.Copy(rutaImagen, imagenDestino);
                try
                {
                    MessageBox.Show("Exito al guardar la imagen :)");
                }catch(Exception ex)
                {
                    MessageBox.Show("Error al guardar la imagen");
                }
            }

            

          

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string precio = txtPrecio.Text;
            string codigobarras = txtCodigoBarras.Text;
            string categoria = cbCategoria.Text;



            string respuesta = producto.InsertarProducto(
                nombre,
                descripcion,
                precio,
                UnidadMedia,
                Caducable,
                codigobarras,
                categoria,
                imagenBytes
            );




            MessageBox.Show(respuesta);

            Producto[] resultado = producto.BuscarPorNombre(txtNombre.Text);

            listBox1.Items.Clear();

            if (resultado != null)
            {
                for (int i = 0; i < resultado.Length; i++)
                {
                    if (resultado[i] != null)
                    {
                        listBox1.Items.Add(
                            "Nombre: " + resultado[i].Nombre +
                            " | Precio: $" + resultado[i].Precio +
                            " | Categoria: " + resultado[i].Categoria
                        );

                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontraron productos.");
            }

            listBox1.Items.Add("-------------------------");


            Producto[] lista = producto.MostrarProductos();

            if (lista != null)
            {
                dGView1.DataSource = lista;
            }


            ActualizarDataGridView();



            if (resultado != null && resultado.Length > 0)
            {
                for (int i = 0; i < resultado.Length; i++)
                {
                    if (resultado[i] != null && resultado[i].CodigoBarras == codigobarras)
                    {
                        if (resultado[i].Imagen != null)
                        {
                            using (MemoryStream ms = new MemoryStream(resultado[i].Imagen))
                            {
                                pbMostrarImagen.Image = System.Drawing.Image.FromStream(ms);
                            }
                        }
                        break;
                    }
                }
            }


        }


        //--------------------------------------------------------------------------------------------------------


        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        //Lista de la categoria
        public void Form1_Load(object sender, EventArgs e)
        {
            var categorias = producto.ObtenerCategorias();

            cbCategoria.Items.Clear();

            if (categorias != null)
            {
                for (int i = 0; i < categorias.Count; i++)
                {
                    cbCategoria.Items.Add(categorias[i]);
                }

                cbCategoria.SelectedIndex = 0;
            }




            Producto[] lista = producto.MostrarProductos();

            dGView1.DataSource = lista;
        }

        



        //Boton que bueca por nombre
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Producto[] resultado = producto.BuscarPorNombre(txtBuscar.Text);

            lbMostrar.Items.Clear();

            if (resultado != null)
            {
                for (int i = 0; i < resultado.Length; i++)
                {
                    if (resultado[i] != null)
                    {
                        lbMostrar.Items.Add(
                            "Nombre: " + resultado[i].Nombre +
                            " | Precio: $" + resultado[i].Precio +
                            " | Categoria: " + resultado[i].Categoria
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontraron productos.");
            }
        }



        //Boton que muestra el primero de la lista
        private void btnPrimero_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            Producto primero = producto.Primero();

            if (primero != null)
            {
                listBox1.Items.Add(
                    "El primer Producto es: "+
                    "\n Nombre: " + primero.Nombre +
                    " | Precio: $" + primero.Precio +
                    " | Categoria: " + primero.Categoria
                );
            }
            else
            {
                MessageBox.Show("No hay productos registrados.");
            }

        }



        //Boton que muestra el ultimo de la lista
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Producto ultimo = producto.Ultimo();

            if (ultimo != null)
            {
                listBox1.Items.Add(
                    "El ultimo Producto es: " +
                    "\n Nombre: " + ultimo.Nombre +
                    " | Precio: $" + ultimo.Precio +
                    " | Categoria: " + ultimo.Categoria
                );
            }
            else
            {
                MessageBox.Show("No hay productos registrados.");
            }
        }



        //Muestra todos los datos guardados en el servicio web
        private void btnConsumir_Click(object sender, EventArgs e)
        {

            lbConsumir.Items.Clear();

            Producto[] lista = producto.MostrarProductos();


            lbConsumir.Items.Add("REPORTE DE PRODUCTOS\r\n");


            for (int i = 0; i < lista.Length; i++)
            {
                lbConsumir.Items.Add(
                    "Nombre: " + lista[i].Nombre +
                    " | Precio: $" + lista[i].Precio +
                    " | Categoria: " + lista[i].Categoria
                );
            }

            ActualizarDataGridView();

        }



        //Boton que imprime el pdf e ingresa los datos del pdf
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            


            byte[] archivoPdf = producto.GenerarPdfProductos();

            if (archivoPdf == null || archivoPdf.Length == 0)
            {
                MessageBox.Show("No se pudo generar el PDF");
                return;
            }

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "PDF (*.pdf)|*.pdf";
            guardar.FileName = "ListaProductos.pdf";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(guardar.FileName, archivoPdf);
                MessageBox.Show("PDF generado correctamente desde el servicio web");
            }
        }
        



        //Boton de Precio
        private void btnPrecio_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            Producto[] lista = producto.MostrarProductos();

            
            for (int i = 0; i < lista.Length - 1; i++)
            {
                for (int j = 0; j < lista.Length - 1 - i; j++)
                {
                    double precioActual = Convert.ToDouble(lista[j].Precio);
                    double precioSiguiente = Convert.ToDouble(lista[j + 1].Precio);

                    if (precioActual > precioSiguiente)
                    {
                        Producto temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }

            
            for (int i = 0; i < lista.Length; i++)
            {
                listBox1.Items.Add(
                    "Nombre: " + lista[i].Nombre +
                    " | Precio: $" + lista[i].Precio +
                    " | Categoria: " + lista[i].Categoria
                );
            }

        }

        private void dGView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void InsertarDatos()
        {

            dGView1.AllowUserToAddRows = false;
            dGView1.AllowUserToDeleteRows = false;
            dGView1.ReadOnly = true;

            dGView1.Columns.Add("Nombre Producto", "Nombre");

        }

        private void ActualizarDataGridView()
        {
            try
            {
                Producto[] lista = producto.MostrarProductos();

                dGView1.DataSource = null;
                dGView1.DataSource = lista;

                dGView1.AutoGenerateColumns = true;
                dGView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el DataGridView: " + ex.Message);
            }



        }




        private void btnSelecImagen_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Archivos de Imagen | *.jpg; *.png; *.jpeg";

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string ruta = openFileDialog1.FileName;

                    
                    pbImagen.Image = System.Drawing.Image.FromFile(ruta);

                    
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbImagen.Image.Save(ms, ImageFormat.Jpeg);
                        imagenBytes = ms.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            /*
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = System.Drawing.Image.FromFile(ofd.FileName);
            }
            
            */
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();

            this.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();

            this.Close();
        }
    }
}
