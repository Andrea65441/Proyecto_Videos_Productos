namespace ExamenUnidad1FORM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMostrar = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.rbGramos = new System.Windows.Forms.RadioButton();
            this.rbKilos = new System.Windows.Forms.RadioButton();
            this.rbLitros = new System.Windows.Forms.RadioButton();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.cbSiCaducable = new System.Windows.Forms.CheckBox();
            this.cbNoCaducable = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConsumir = new System.Windows.Forms.Button();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lbConsumir = new System.Windows.Forms.ListBox();
            this.dGView1 = new System.Windows.Forms.DataGridView();
            this.mostrarProductosResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnSelecImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buscarPorNombreResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbMostrarImagen = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProductosResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarPorNombreResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarImagen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unidad de \r\nmedida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Producto caducable:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Codigo de barras:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ordenar por:";
            // 
            // lbMostrar
            // 
            this.lbMostrar.FormattingEnabled = true;
            this.lbMostrar.ItemHeight = 16;
            this.lbMostrar.Location = new System.Drawing.Point(704, 76);
            this.lbMostrar.Name = "lbMostrar";
            this.lbMostrar.Size = new System.Drawing.Size(329, 228);
            this.lbMostrar.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(162, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(162, 120);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(211, 22);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(162, 155);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(211, 22);
            this.txtPrecio.TabIndex = 10;
            // 
            // rbGramos
            // 
            this.rbGramos.AutoSize = true;
            this.rbGramos.Location = new System.Drawing.Point(104, 212);
            this.rbGramos.Name = "rbGramos";
            this.rbGramos.Size = new System.Drawing.Size(76, 20);
            this.rbGramos.TabIndex = 11;
            this.rbGramos.TabStop = true;
            this.rbGramos.Text = "Gramos";
            this.rbGramos.UseVisualStyleBackColor = true;
            // 
            // rbKilos
            // 
            this.rbKilos.AutoSize = true;
            this.rbKilos.Location = new System.Drawing.Point(218, 210);
            this.rbKilos.Name = "rbKilos";
            this.rbKilos.Size = new System.Drawing.Size(57, 20);
            this.rbKilos.TabIndex = 12;
            this.rbKilos.TabStop = true;
            this.rbKilos.Text = "Kilos";
            this.rbKilos.UseVisualStyleBackColor = true;
            // 
            // rbLitros
            // 
            this.rbLitros.AutoSize = true;
            this.rbLitros.Location = new System.Drawing.Point(313, 209);
            this.rbLitros.Name = "rbLitros";
            this.rbLitros.Size = new System.Drawing.Size(60, 20);
            this.rbLitros.TabIndex = 13;
            this.rbLitros.TabStop = true;
            this.rbLitros.Text = "Litros";
            this.rbLitros.UseVisualStyleBackColor = true;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(162, 301);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(211, 22);
            this.txtCodigoBarras.TabIndex = 14;
            // 
            // cbSiCaducable
            // 
            this.cbSiCaducable.AutoSize = true;
            this.cbSiCaducable.Location = new System.Drawing.Point(173, 268);
            this.cbSiCaducable.Name = "cbSiCaducable";
            this.cbSiCaducable.Size = new System.Drawing.Size(41, 20);
            this.cbSiCaducable.TabIndex = 15;
            this.cbSiCaducable.Text = "Si";
            this.cbSiCaducable.UseVisualStyleBackColor = true;
            // 
            // cbNoCaducable
            // 
            this.cbNoCaducable.AutoSize = true;
            this.cbNoCaducable.Location = new System.Drawing.Point(243, 268);
            this.cbNoCaducable.Name = "cbNoCaducable";
            this.cbNoCaducable.Size = new System.Drawing.Size(47, 20);
            this.cbNoCaducable.TabIndex = 16;
            this.cbNoCaducable.Text = "No";
            this.cbNoCaducable.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(51, 344);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 30);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConsumir
            // 
            this.btnConsumir.Location = new System.Drawing.Point(233, 344);
            this.btnConsumir.Name = "btnConsumir";
            this.btnConsumir.Size = new System.Drawing.Size(155, 30);
            this.btnConsumir.TabIndex = 18;
            this.btnConsumir.Text = "Consumir";
            this.btnConsumir.UseVisualStyleBackColor = true;
            this.btnConsumir.Click += new System.EventHandler(this.btnConsumir_Click);
            // 
            // btnPrecio
            // 
            this.btnPrecio.Location = new System.Drawing.Point(115, 387);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(117, 30);
            this.btnPrecio.TabIndex = 19;
            this.btnPrecio.Text = "Precio";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(243, 387);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(117, 30);
            this.btnUltimo.TabIndex = 20;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(376, 387);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(117, 30);
            this.btnPrimero.TabIndex = 21;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(18, 439);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(475, 148);
            this.listBox1.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(955, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 31);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(704, 37);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(245, 22);
            this.txtBuscar.TabIndex = 24;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(162, 37);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(211, 24);
            this.cbCategoria.TabIndex = 25;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Categoria:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(704, 344);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(155, 73);
            this.btnImprimir.TabIndex = 27;
            this.btnImprimir.Text = "Imprimir (PDF)";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lbConsumir
            // 
            this.lbConsumir.FormattingEnabled = true;
            this.lbConsumir.ItemHeight = 16;
            this.lbConsumir.Location = new System.Drawing.Point(18, 599);
            this.lbConsumir.Name = "lbConsumir";
            this.lbConsumir.Size = new System.Drawing.Size(475, 132);
            this.lbConsumir.TabIndex = 28;
            // 
            // dGView1
            // 
            this.dGView1.AutoGenerateColumns = false;
            this.dGView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView1.DataSource = this.mostrarProductosResponseBindingSource;
            this.dGView1.Location = new System.Drawing.Point(519, 439);
            this.dGView1.Name = "dGView1";
            this.dGView1.RowHeadersWidth = 51;
            this.dGView1.RowTemplate.Height = 24;
            this.dGView1.Size = new System.Drawing.Size(514, 148);
            this.dGView1.TabIndex = 29;
            this.dGView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView1_CellContentClick);
            // 
            // mostrarProductosResponseBindingSource
            // 
            this.mostrarProductosResponseBindingSource.DataSource = typeof(ExamenUnidad1FORM.ServiceReference2.MostrarProductosResponse);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(422, 46);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(223, 203);
            this.pbImagen.TabIndex = 30;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbImagen_Click);
            // 
            // btnSelecImagen
            // 
            this.btnSelecImagen.Location = new System.Drawing.Point(422, 255);
            this.btnSelecImagen.Name = "btnSelecImagen";
            this.btnSelecImagen.Size = new System.Drawing.Size(223, 42);
            this.btnSelecImagen.TabIndex = 31;
            this.btnSelecImagen.Text = "Seleccionar Imagen";
            this.btnSelecImagen.UseVisualStyleBackColor = true;
            this.btnSelecImagen.Click += new System.EventHandler(this.btnSelecImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofdImagen";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // buscarPorNombreResponseBindingSource
            // 
            this.buscarPorNombreResponseBindingSource.DataSource = typeof(ExamenUnidad1FORM.ServiceReference2.BuscarPorNombreResponse);
            // 
            // pbMostrarImagen
            // 
            this.pbMostrarImagen.Location = new System.Drawing.Point(519, 599);
            this.pbMostrarImagen.Name = "pbMostrarImagen";
            this.pbMostrarImagen.Size = new System.Drawing.Size(160, 132);
            this.pbMostrarImagen.TabIndex = 32;
            this.pbMostrarImagen.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 28);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1,
            this.loginToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.menuToolStripMenuItem1.Text = "Menu";
            this.menuToolStripMenuItem1.Click += new System.EventHandler(this.menuToolStripMenuItem1_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loginToolStripMenuItem.Text = "Cerrar Sesion";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1054, 751);
            this.Controls.Add(this.pbMostrarImagen);
            this.Controls.Add(this.btnSelecImagen);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.dGView1);
            this.Controls.Add(this.lbConsumir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrecio);
            this.Controls.Add(this.btnConsumir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbNoCaducable);
            this.Controls.Add(this.cbSiCaducable);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.rbLitros);
            this.Controls.Add(this.rbKilos);
            this.Controls.Add(this.rbGramos);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbMostrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProductosResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarPorNombreResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarImagen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbMostrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton rbGramos;
        private System.Windows.Forms.RadioButton rbKilos;
        private System.Windows.Forms.RadioButton rbLitros;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.CheckBox cbSiCaducable;
        private System.Windows.Forms.CheckBox cbNoCaducable;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConsumir;
        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ListBox lbConsumir;
        private System.Windows.Forms.DataGridView dGView1;
        private System.Windows.Forms.BindingSource mostrarProductosResponseBindingSource;
        private System.Windows.Forms.BindingSource buscarPorNombreResponseBindingSource;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnSelecImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbMostrarImagen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}

