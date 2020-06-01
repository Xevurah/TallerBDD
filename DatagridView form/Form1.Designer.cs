namespace DatagridView_form
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.conex = new System.Windows.Forms.Button();
            this.selec = new System.Windows.Forms.Button();
            this.Inser = new System.Windows.Forms.Button();
            this.updat = new System.Windows.Forms.Button();
            this.delet = new System.Windows.Forms.Button();
            this.labelnombre_autor = new System.Windows.Forms.Label();
            this.labelnacionalidad_autor = new System.Windows.Forms.Label();
            this.labelapellido_autor = new System.Windows.Forms.Label();
            this.textBoxnombre_autor = new System.Windows.Forms.TextBox();
            this.textBoxnacionalidad_autor = new System.Windows.Forms.TextBox();
            this.textBoxapellido_autor = new System.Windows.Forms.TextBox();
            this.labelautor_autor = new System.Windows.Forms.Label();
            this.labelestudiante_estudiante = new System.Windows.Forms.Label();
            this.textBoxcarrera_estudiante = new System.Windows.Forms.TextBox();
            this.textBoxdireccion_estudiante = new System.Windows.Forms.TextBox();
            this.textBoxnombre_estudiante = new System.Windows.Forms.TextBox();
            this.labelcarrera_estudiante = new System.Windows.Forms.Label();
            this.labeldireccion_estudiante = new System.Windows.Forms.Label();
            this.labelnombre_estudiante = new System.Windows.Forms.Label();
            this.textBoxedad_estudiante = new System.Windows.Forms.TextBox();
            this.labeledad_estudiante = new System.Windows.Forms.Label();
            this.textBoxid_autor = new System.Windows.Forms.TextBox();
            this.labelid_autor = new System.Windows.Forms.Label();
            this.textBoxid_estudiante = new System.Windows.Forms.TextBox();
            this.labelid_estudiante = new System.Windows.Forms.Label();
            this.textBoxid_libaut = new System.Windows.Forms.TextBox();
            this.labelid_libaut = new System.Windows.Forms.Label();
            this.labellibaut_libaut = new System.Windows.Forms.Label();
            this.textBoxidlibro_libaut = new System.Windows.Forms.TextBox();
            this.textBoxidautor_libaut = new System.Windows.Forms.TextBox();
            this.labelidlibro_libaut = new System.Windows.Forms.Label();
            this.labelidautor_libaut = new System.Windows.Forms.Label();
            this.textBoxid_libro = new System.Windows.Forms.TextBox();
            this.labelid_libro = new System.Windows.Forms.Label();
            this.labellibro_libro = new System.Windows.Forms.Label();
            this.textBoxeditorial_libro = new System.Windows.Forms.TextBox();
            this.textBoxtitulo_libro = new System.Windows.Forms.TextBox();
            this.labeleditorial_libro = new System.Windows.Forms.Label();
            this.labeltitulo_libro = new System.Windows.Forms.Label();
            this.textBoxcategoria_libro = new System.Windows.Forms.TextBox();
            this.labelcategoria_libro = new System.Windows.Forms.Label();
            this.textBoxid_prestamo = new System.Windows.Forms.TextBox();
            this.labelid_prestamo = new System.Windows.Forms.Label();
            this.labelprestamo_prestamo = new System.Windows.Forms.Label();
            this.textBoxidlibro_prestamo = new System.Windows.Forms.TextBox();
            this.textBoxidlector_prestamo = new System.Windows.Forms.TextBox();
            this.labelidlibro_prestamo = new System.Windows.Forms.Label();
            this.labelidlector_prestamo = new System.Windows.Forms.Label();
            this.labelfechaprestamo_prestamo = new System.Windows.Forms.Label();
            this.labelfechadevolucion_prestamo = new System.Windows.Forms.Label();
            this.dateTimePickerfechaprestamo_prestamo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerfechadevolucion_prestamo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(13, 17);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(370, 16);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Elaboración de los formularios para alimentar la BD.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 359);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Estudiante";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Autor",
            "Estudiante",
            "LibAut",
            "Libro",
            "Prestamo"});
            this.comboBox1.Location = new System.Drawing.Point(394, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // conex
            // 
            this.conex.BackColor = System.Drawing.Color.Lime;
            this.conex.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.conex.Location = new System.Drawing.Point(16, 409);
            this.conex.Name = "conex";
            this.conex.Size = new System.Drawing.Size(95, 29);
            this.conex.TabIndex = 10;
            this.conex.Text = "CONNECT";
            this.conex.UseVisualStyleBackColor = false;
            this.conex.Click += new System.EventHandler(this.conex_Click);
            // 
            // selec
            // 
            this.selec.BackColor = System.Drawing.Color.Aqua;
            this.selec.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selec.Location = new System.Drawing.Point(117, 409);
            this.selec.Name = "selec";
            this.selec.Size = new System.Drawing.Size(95, 29);
            this.selec.TabIndex = 11;
            this.selec.Text = "SELECT";
            this.selec.UseVisualStyleBackColor = false;
            this.selec.Click += new System.EventHandler(this.selec_Click);
            // 
            // Inser
            // 
            this.Inser.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Inser.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Inser.Location = new System.Drawing.Point(218, 409);
            this.Inser.Name = "Inser";
            this.Inser.Size = new System.Drawing.Size(95, 29);
            this.Inser.TabIndex = 12;
            this.Inser.Text = "INSERT";
            this.Inser.UseVisualStyleBackColor = false;
            this.Inser.Click += new System.EventHandler(this.Inser_Click);
            // 
            // updat
            // 
            this.updat.BackColor = System.Drawing.Color.Orange;
            this.updat.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updat.Location = new System.Drawing.Point(319, 409);
            this.updat.Name = "updat";
            this.updat.Size = new System.Drawing.Size(95, 29);
            this.updat.TabIndex = 13;
            this.updat.Text = "UPDATE";
            this.updat.UseVisualStyleBackColor = false;
            this.updat.Click += new System.EventHandler(this.updat_Click);
            // 
            // delet
            // 
            this.delet.BackColor = System.Drawing.Color.Red;
            this.delet.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delet.Location = new System.Drawing.Point(420, 409);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(95, 29);
            this.delet.TabIndex = 14;
            this.delet.Text = "DELETE";
            this.delet.UseVisualStyleBackColor = false;
            this.delet.Click += new System.EventHandler(this.delet_Click);
            // 
            // labelnombre_autor
            // 
            this.labelnombre_autor.AutoSize = true;
            this.labelnombre_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre_autor.Location = new System.Drawing.Point(559, 194);
            this.labelnombre_autor.Name = "labelnombre_autor";
            this.labelnombre_autor.Size = new System.Drawing.Size(58, 15);
            this.labelnombre_autor.TabIndex = 15;
            this.labelnombre_autor.Text = "Nombre";
            this.labelnombre_autor.Visible = false;
            // 
            // labelnacionalidad_autor
            // 
            this.labelnacionalidad_autor.AutoSize = true;
            this.labelnacionalidad_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnacionalidad_autor.Location = new System.Drawing.Point(558, 277);
            this.labelnacionalidad_autor.Name = "labelnacionalidad_autor";
            this.labelnacionalidad_autor.Size = new System.Drawing.Size(92, 15);
            this.labelnacionalidad_autor.TabIndex = 16;
            this.labelnacionalidad_autor.Text = "Nacionalidad";
            this.labelnacionalidad_autor.Visible = false;
            // 
            // labelapellido_autor
            // 
            this.labelapellido_autor.AutoSize = true;
            this.labelapellido_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapellido_autor.Location = new System.Drawing.Point(559, 360);
            this.labelapellido_autor.Name = "labelapellido_autor";
            this.labelapellido_autor.Size = new System.Drawing.Size(59, 15);
            this.labelapellido_autor.TabIndex = 17;
            this.labelapellido_autor.Text = "Apellido";
            this.labelapellido_autor.Visible = false;
            // 
            // textBoxnombre_autor
            // 
            this.textBoxnombre_autor.Location = new System.Drawing.Point(562, 212);
            this.textBoxnombre_autor.Name = "textBoxnombre_autor";
            this.textBoxnombre_autor.Size = new System.Drawing.Size(100, 20);
            this.textBoxnombre_autor.TabIndex = 18;
            this.textBoxnombre_autor.Visible = false;
            // 
            // textBoxnacionalidad_autor
            // 
            this.textBoxnacionalidad_autor.Location = new System.Drawing.Point(561, 295);
            this.textBoxnacionalidad_autor.Name = "textBoxnacionalidad_autor";
            this.textBoxnacionalidad_autor.Size = new System.Drawing.Size(100, 20);
            this.textBoxnacionalidad_autor.TabIndex = 19;
            this.textBoxnacionalidad_autor.Visible = false;
            // 
            // textBoxapellido_autor
            // 
            this.textBoxapellido_autor.Location = new System.Drawing.Point(562, 378);
            this.textBoxapellido_autor.Name = "textBoxapellido_autor";
            this.textBoxapellido_autor.Size = new System.Drawing.Size(100, 20);
            this.textBoxapellido_autor.TabIndex = 20;
            this.textBoxapellido_autor.Visible = false;
            // 
            // labelautor_autor
            // 
            this.labelautor_autor.AutoSize = true;
            this.labelautor_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelautor_autor.Location = new System.Drawing.Point(587, 69);
            this.labelautor_autor.Name = "labelautor_autor";
            this.labelautor_autor.Size = new System.Drawing.Size(48, 18);
            this.labelautor_autor.TabIndex = 21;
            this.labelautor_autor.Text = "Autor";
            this.labelautor_autor.Visible = false;
            // 
            // labelestudiante_estudiante
            // 
            this.labelestudiante_estudiante.AutoSize = true;
            this.labelestudiante_estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestudiante_estudiante.Location = new System.Drawing.Point(574, 69);
            this.labelestudiante_estudiante.Name = "labelestudiante_estudiante";
            this.labelestudiante_estudiante.Size = new System.Drawing.Size(87, 18);
            this.labelestudiante_estudiante.TabIndex = 28;
            this.labelestudiante_estudiante.Text = "Estudiante";
            this.labelestudiante_estudiante.Visible = false;
            // 
            // textBoxcarrera_estudiante
            // 
            this.textBoxcarrera_estudiante.Location = new System.Drawing.Point(561, 342);
            this.textBoxcarrera_estudiante.Name = "textBoxcarrera_estudiante";
            this.textBoxcarrera_estudiante.Size = new System.Drawing.Size(100, 20);
            this.textBoxcarrera_estudiante.TabIndex = 27;
            this.textBoxcarrera_estudiante.Visible = false;
            // 
            // textBoxdireccion_estudiante
            // 
            this.textBoxdireccion_estudiante.Location = new System.Drawing.Point(561, 276);
            this.textBoxdireccion_estudiante.Name = "textBoxdireccion_estudiante";
            this.textBoxdireccion_estudiante.Size = new System.Drawing.Size(100, 20);
            this.textBoxdireccion_estudiante.TabIndex = 26;
            this.textBoxdireccion_estudiante.Visible = false;
            // 
            // textBoxnombre_estudiante
            // 
            this.textBoxnombre_estudiante.Location = new System.Drawing.Point(562, 206);
            this.textBoxnombre_estudiante.Name = "textBoxnombre_estudiante";
            this.textBoxnombre_estudiante.Size = new System.Drawing.Size(100, 20);
            this.textBoxnombre_estudiante.TabIndex = 25;
            this.textBoxnombre_estudiante.Visible = false;
            // 
            // labelcarrera_estudiante
            // 
            this.labelcarrera_estudiante.AutoSize = true;
            this.labelcarrera_estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcarrera_estudiante.Location = new System.Drawing.Point(558, 324);
            this.labelcarrera_estudiante.Name = "labelcarrera_estudiante";
            this.labelcarrera_estudiante.Size = new System.Drawing.Size(55, 15);
            this.labelcarrera_estudiante.TabIndex = 24;
            this.labelcarrera_estudiante.Text = "Carrera";
            this.labelcarrera_estudiante.Visible = false;
            // 
            // labeldireccion_estudiante
            // 
            this.labeldireccion_estudiante.AutoSize = true;
            this.labeldireccion_estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccion_estudiante.Location = new System.Drawing.Point(558, 258);
            this.labeldireccion_estudiante.Name = "labeldireccion_estudiante";
            this.labeldireccion_estudiante.Size = new System.Drawing.Size(68, 15);
            this.labeldireccion_estudiante.TabIndex = 23;
            this.labeldireccion_estudiante.Text = "Direccion";
            this.labeldireccion_estudiante.Visible = false;
            // 
            // labelnombre_estudiante
            // 
            this.labelnombre_estudiante.AutoSize = true;
            this.labelnombre_estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre_estudiante.Location = new System.Drawing.Point(559, 188);
            this.labelnombre_estudiante.Name = "labelnombre_estudiante";
            this.labelnombre_estudiante.Size = new System.Drawing.Size(58, 15);
            this.labelnombre_estudiante.TabIndex = 22;
            this.labelnombre_estudiante.Text = "Nombre";
            this.labelnombre_estudiante.Visible = false;
            // 
            // textBoxedad_estudiante
            // 
            this.textBoxedad_estudiante.Location = new System.Drawing.Point(561, 406);
            this.textBoxedad_estudiante.Name = "textBoxedad_estudiante";
            this.textBoxedad_estudiante.Size = new System.Drawing.Size(100, 20);
            this.textBoxedad_estudiante.TabIndex = 30;
            this.textBoxedad_estudiante.Visible = false;
            // 
            // labeledad_estudiante
            // 
            this.labeledad_estudiante.AutoSize = true;
            this.labeledad_estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeledad_estudiante.Location = new System.Drawing.Point(558, 388);
            this.labeledad_estudiante.Name = "labeledad_estudiante";
            this.labeledad_estudiante.Size = new System.Drawing.Size(40, 15);
            this.labeledad_estudiante.TabIndex = 29;
            this.labeledad_estudiante.Text = "Edad";
            this.labeledad_estudiante.Visible = false;
            // 
            // textBoxid_autor
            // 
            this.textBoxid_autor.Location = new System.Drawing.Point(561, 142);
            this.textBoxid_autor.Name = "textBoxid_autor";
            this.textBoxid_autor.Size = new System.Drawing.Size(100, 20);
            this.textBoxid_autor.TabIndex = 32;
            this.textBoxid_autor.Visible = false;
            // 
            // labelid_autor
            // 
            this.labelid_autor.AutoSize = true;
            this.labelid_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid_autor.Location = new System.Drawing.Point(558, 124);
            this.labelid_autor.Name = "labelid_autor";
            this.labelid_autor.Size = new System.Drawing.Size(21, 15);
            this.labelid_autor.TabIndex = 31;
            this.labelid_autor.Text = "ID";
            this.labelid_autor.Visible = false;
            // 
            // textBoxid_estudiante
            // 
            this.textBoxid_estudiante.Location = new System.Drawing.Point(562, 152);
            this.textBoxid_estudiante.Name = "textBoxid_estudiante";
            this.textBoxid_estudiante.Size = new System.Drawing.Size(100, 20);
            this.textBoxid_estudiante.TabIndex = 34;
            this.textBoxid_estudiante.Visible = false;
            // 
            // labelid_estudiante
            // 
            this.labelid_estudiante.AutoSize = true;
            this.labelid_estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid_estudiante.Location = new System.Drawing.Point(559, 134);
            this.labelid_estudiante.Name = "labelid_estudiante";
            this.labelid_estudiante.Size = new System.Drawing.Size(21, 15);
            this.labelid_estudiante.TabIndex = 33;
            this.labelid_estudiante.Text = "ID";
            this.labelid_estudiante.Visible = false;
            // 
            // textBoxid_libaut
            // 
            this.textBoxid_libaut.Location = new System.Drawing.Point(561, 152);
            this.textBoxid_libaut.Name = "textBoxid_libaut";
            this.textBoxid_libaut.Size = new System.Drawing.Size(100, 20);
            this.textBoxid_libaut.TabIndex = 45;
            this.textBoxid_libaut.Visible = false;
            // 
            // labelid_libaut
            // 
            this.labelid_libaut.AutoSize = true;
            this.labelid_libaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid_libaut.Location = new System.Drawing.Point(558, 134);
            this.labelid_libaut.Name = "labelid_libaut";
            this.labelid_libaut.Size = new System.Drawing.Size(21, 15);
            this.labelid_libaut.TabIndex = 44;
            this.labelid_libaut.Text = "ID";
            this.labelid_libaut.Visible = false;
            // 
            // labellibaut_libaut
            // 
            this.labellibaut_libaut.AutoSize = true;
            this.labellibaut_libaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellibaut_libaut.Location = new System.Drawing.Point(573, 69);
            this.labellibaut_libaut.Name = "labellibaut_libaut";
            this.labellibaut_libaut.Size = new System.Drawing.Size(86, 18);
            this.labellibaut_libaut.TabIndex = 41;
            this.labellibaut_libaut.Text = "LibroAutor";
            this.labellibaut_libaut.Visible = false;
            // 
            // textBoxidlibro_libaut
            // 
            this.textBoxidlibro_libaut.Location = new System.Drawing.Point(561, 294);
            this.textBoxidlibro_libaut.Name = "textBoxidlibro_libaut";
            this.textBoxidlibro_libaut.Size = new System.Drawing.Size(100, 20);
            this.textBoxidlibro_libaut.TabIndex = 39;
            this.textBoxidlibro_libaut.Visible = false;
            // 
            // textBoxidautor_libaut
            // 
            this.textBoxidautor_libaut.Location = new System.Drawing.Point(561, 228);
            this.textBoxidautor_libaut.Name = "textBoxidautor_libaut";
            this.textBoxidautor_libaut.Size = new System.Drawing.Size(100, 20);
            this.textBoxidautor_libaut.TabIndex = 38;
            this.textBoxidautor_libaut.Visible = false;
            // 
            // labelidlibro_libaut
            // 
            this.labelidlibro_libaut.AutoSize = true;
            this.labelidlibro_libaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidlibro_libaut.Location = new System.Drawing.Point(558, 276);
            this.labelidlibro_libaut.Name = "labelidlibro_libaut";
            this.labelidlibro_libaut.Size = new System.Drawing.Size(52, 15);
            this.labelidlibro_libaut.TabIndex = 36;
            this.labelidlibro_libaut.Text = "IdLibro";
            this.labelidlibro_libaut.Visible = false;
            // 
            // labelidautor_libaut
            // 
            this.labelidautor_libaut.AutoSize = true;
            this.labelidautor_libaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidautor_libaut.Location = new System.Drawing.Point(558, 210);
            this.labelidautor_libaut.Name = "labelidautor_libaut";
            this.labelidautor_libaut.Size = new System.Drawing.Size(52, 15);
            this.labelidautor_libaut.TabIndex = 35;
            this.labelidautor_libaut.Text = "IdAutor";
            this.labelidautor_libaut.Visible = false;
            // 
            // textBoxid_libro
            // 
            this.textBoxid_libro.Location = new System.Drawing.Point(561, 146);
            this.textBoxid_libro.Name = "textBoxid_libro";
            this.textBoxid_libro.Size = new System.Drawing.Size(100, 20);
            this.textBoxid_libro.TabIndex = 54;
            this.textBoxid_libro.Visible = false;
            // 
            // labelid_libro
            // 
            this.labelid_libro.AutoSize = true;
            this.labelid_libro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid_libro.Location = new System.Drawing.Point(558, 128);
            this.labelid_libro.Name = "labelid_libro";
            this.labelid_libro.Size = new System.Drawing.Size(21, 15);
            this.labelid_libro.TabIndex = 53;
            this.labelid_libro.Text = "ID";
            this.labelid_libro.Visible = false;
            // 
            // labellibro_libro
            // 
            this.labellibro_libro.AutoSize = true;
            this.labellibro_libro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellibro_libro.Location = new System.Drawing.Point(586, 69);
            this.labellibro_libro.Name = "labellibro_libro";
            this.labellibro_libro.Size = new System.Drawing.Size(46, 18);
            this.labellibro_libro.TabIndex = 52;
            this.labellibro_libro.Text = "Libro";
            this.labellibro_libro.Visible = false;
            // 
            // textBoxeditorial_libro
            // 
            this.textBoxeditorial_libro.Location = new System.Drawing.Point(561, 276);
            this.textBoxeditorial_libro.Name = "textBoxeditorial_libro";
            this.textBoxeditorial_libro.Size = new System.Drawing.Size(100, 20);
            this.textBoxeditorial_libro.TabIndex = 51;
            this.textBoxeditorial_libro.Visible = false;
            // 
            // textBoxtitulo_libro
            // 
            this.textBoxtitulo_libro.Location = new System.Drawing.Point(561, 212);
            this.textBoxtitulo_libro.Name = "textBoxtitulo_libro";
            this.textBoxtitulo_libro.Size = new System.Drawing.Size(100, 20);
            this.textBoxtitulo_libro.TabIndex = 50;
            this.textBoxtitulo_libro.Visible = false;
            // 
            // labeleditorial_libro
            // 
            this.labeleditorial_libro.AutoSize = true;
            this.labeleditorial_libro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeleditorial_libro.Location = new System.Drawing.Point(558, 258);
            this.labeleditorial_libro.Name = "labeleditorial_libro";
            this.labeleditorial_libro.Size = new System.Drawing.Size(61, 15);
            this.labeleditorial_libro.TabIndex = 49;
            this.labeleditorial_libro.Text = "Editorial";
            this.labeleditorial_libro.Visible = false;
            // 
            // labeltitulo_libro
            // 
            this.labeltitulo_libro.AutoSize = true;
            this.labeltitulo_libro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo_libro.Location = new System.Drawing.Point(558, 194);
            this.labeltitulo_libro.Name = "labeltitulo_libro";
            this.labeltitulo_libro.Size = new System.Drawing.Size(43, 15);
            this.labeltitulo_libro.TabIndex = 48;
            this.labeltitulo_libro.Text = "Titulo";
            this.labeltitulo_libro.Visible = false;
            // 
            // textBoxcategoria_libro
            // 
            this.textBoxcategoria_libro.Location = new System.Drawing.Point(561, 336);
            this.textBoxcategoria_libro.Name = "textBoxcategoria_libro";
            this.textBoxcategoria_libro.Size = new System.Drawing.Size(100, 20);
            this.textBoxcategoria_libro.TabIndex = 47;
            this.textBoxcategoria_libro.Visible = false;
            // 
            // labelcategoria_libro
            // 
            this.labelcategoria_libro.AutoSize = true;
            this.labelcategoria_libro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcategoria_libro.Location = new System.Drawing.Point(558, 318);
            this.labelcategoria_libro.Name = "labelcategoria_libro";
            this.labelcategoria_libro.Size = new System.Drawing.Size(69, 15);
            this.labelcategoria_libro.TabIndex = 46;
            this.labelcategoria_libro.Text = "Categoria";
            this.labelcategoria_libro.Visible = false;
            // 
            // textBoxid_prestamo
            // 
            this.textBoxid_prestamo.Location = new System.Drawing.Point(559, 146);
            this.textBoxid_prestamo.Name = "textBoxid_prestamo";
            this.textBoxid_prestamo.Size = new System.Drawing.Size(100, 20);
            this.textBoxid_prestamo.TabIndex = 65;
            this.textBoxid_prestamo.Visible = false;
            // 
            // labelid_prestamo
            // 
            this.labelid_prestamo.AutoSize = true;
            this.labelid_prestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid_prestamo.Location = new System.Drawing.Point(556, 128);
            this.labelid_prestamo.Name = "labelid_prestamo";
            this.labelid_prestamo.Size = new System.Drawing.Size(21, 15);
            this.labelid_prestamo.TabIndex = 64;
            this.labelid_prestamo.Text = "ID";
            this.labelid_prestamo.Visible = false;
            // 
            // labelprestamo_prestamo
            // 
            this.labelprestamo_prestamo.AutoSize = true;
            this.labelprestamo_prestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprestamo_prestamo.Location = new System.Drawing.Point(573, 69);
            this.labelprestamo_prestamo.Name = "labelprestamo_prestamo";
            this.labelprestamo_prestamo.Size = new System.Drawing.Size(81, 18);
            this.labelprestamo_prestamo.TabIndex = 63;
            this.labelprestamo_prestamo.Text = "Prestamo";
            this.labelprestamo_prestamo.Visible = false;
            // 
            // textBoxidlibro_prestamo
            // 
            this.textBoxidlibro_prestamo.Location = new System.Drawing.Point(559, 259);
            this.textBoxidlibro_prestamo.Name = "textBoxidlibro_prestamo";
            this.textBoxidlibro_prestamo.Size = new System.Drawing.Size(100, 20);
            this.textBoxidlibro_prestamo.TabIndex = 62;
            this.textBoxidlibro_prestamo.Visible = false;
            // 
            // textBoxidlector_prestamo
            // 
            this.textBoxidlector_prestamo.Location = new System.Drawing.Point(559, 203);
            this.textBoxidlector_prestamo.Name = "textBoxidlector_prestamo";
            this.textBoxidlector_prestamo.Size = new System.Drawing.Size(100, 20);
            this.textBoxidlector_prestamo.TabIndex = 61;
            this.textBoxidlector_prestamo.Visible = false;
            // 
            // labelidlibro_prestamo
            // 
            this.labelidlibro_prestamo.AutoSize = true;
            this.labelidlibro_prestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidlibro_prestamo.Location = new System.Drawing.Point(556, 241);
            this.labelidlibro_prestamo.Name = "labelidlibro_prestamo";
            this.labelidlibro_prestamo.Size = new System.Drawing.Size(40, 15);
            this.labelidlibro_prestamo.TabIndex = 60;
            this.labelidlibro_prestamo.Text = "Libro";
            this.labelidlibro_prestamo.Visible = false;
            // 
            // labelidlector_prestamo
            // 
            this.labelidlector_prestamo.AutoSize = true;
            this.labelidlector_prestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidlector_prestamo.Location = new System.Drawing.Point(556, 185);
            this.labelidlector_prestamo.Name = "labelidlector_prestamo";
            this.labelidlector_prestamo.Size = new System.Drawing.Size(47, 15);
            this.labelidlector_prestamo.TabIndex = 59;
            this.labelidlector_prestamo.Text = "Lector";
            this.labelidlector_prestamo.Visible = false;
            // 
            // labelfechaprestamo_prestamo
            // 
            this.labelfechaprestamo_prestamo.AutoSize = true;
            this.labelfechaprestamo_prestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfechaprestamo_prestamo.Location = new System.Drawing.Point(556, 301);
            this.labelfechaprestamo_prestamo.Name = "labelfechaprestamo_prestamo";
            this.labelfechaprestamo_prestamo.Size = new System.Drawing.Size(131, 15);
            this.labelfechaprestamo_prestamo.TabIndex = 57;
            this.labelfechaprestamo_prestamo.Text = "Fecha de Prestamo";
            this.labelfechaprestamo_prestamo.Visible = false;
            // 
            // labelfechadevolucion_prestamo
            // 
            this.labelfechadevolucion_prestamo.AutoSize = true;
            this.labelfechadevolucion_prestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfechadevolucion_prestamo.Location = new System.Drawing.Point(557, 360);
            this.labelfechadevolucion_prestamo.Name = "labelfechadevolucion_prestamo";
            this.labelfechadevolucion_prestamo.Size = new System.Drawing.Size(139, 15);
            this.labelfechadevolucion_prestamo.TabIndex = 55;
            this.labelfechadevolucion_prestamo.Text = "Fecha de devolucion";
            this.labelfechadevolucion_prestamo.Visible = false;
            // 
            // dateTimePickerfechaprestamo_prestamo
            // 
            this.dateTimePickerfechaprestamo_prestamo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerfechaprestamo_prestamo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerfechaprestamo_prestamo.Location = new System.Drawing.Point(559, 319);
            this.dateTimePickerfechaprestamo_prestamo.Name = "dateTimePickerfechaprestamo_prestamo";
            this.dateTimePickerfechaprestamo_prestamo.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerfechaprestamo_prestamo.TabIndex = 66;
            this.dateTimePickerfechaprestamo_prestamo.Visible = false;
            // 
            // dateTimePickerfechadevolucion_prestamo
            // 
            this.dateTimePickerfechadevolucion_prestamo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerfechadevolucion_prestamo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerfechadevolucion_prestamo.Location = new System.Drawing.Point(559, 378);
            this.dateTimePickerfechadevolucion_prestamo.Name = "dateTimePickerfechadevolucion_prestamo";
            this.dateTimePickerfechadevolucion_prestamo.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerfechadevolucion_prestamo.TabIndex = 67;
            this.dateTimePickerfechadevolucion_prestamo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.dateTimePickerfechadevolucion_prestamo);
            this.Controls.Add(this.dateTimePickerfechaprestamo_prestamo);
            this.Controls.Add(this.textBoxid_prestamo);
            this.Controls.Add(this.labelid_prestamo);
            this.Controls.Add(this.labelprestamo_prestamo);
            this.Controls.Add(this.textBoxidlibro_prestamo);
            this.Controls.Add(this.textBoxidlector_prestamo);
            this.Controls.Add(this.labelidlibro_prestamo);
            this.Controls.Add(this.labelidlector_prestamo);
            this.Controls.Add(this.labelfechaprestamo_prestamo);
            this.Controls.Add(this.labelfechadevolucion_prestamo);
            this.Controls.Add(this.textBoxid_libro);
            this.Controls.Add(this.labelid_libro);
            this.Controls.Add(this.labellibro_libro);
            this.Controls.Add(this.textBoxeditorial_libro);
            this.Controls.Add(this.textBoxtitulo_libro);
            this.Controls.Add(this.labeleditorial_libro);
            this.Controls.Add(this.labeltitulo_libro);
            this.Controls.Add(this.textBoxcategoria_libro);
            this.Controls.Add(this.labelcategoria_libro);
            this.Controls.Add(this.textBoxid_libaut);
            this.Controls.Add(this.labelid_libaut);
            this.Controls.Add(this.labellibaut_libaut);
            this.Controls.Add(this.textBoxidlibro_libaut);
            this.Controls.Add(this.textBoxidautor_libaut);
            this.Controls.Add(this.labelidlibro_libaut);
            this.Controls.Add(this.labelidautor_libaut);
            this.Controls.Add(this.textBoxid_estudiante);
            this.Controls.Add(this.labelid_estudiante);
            this.Controls.Add(this.textBoxid_autor);
            this.Controls.Add(this.labelid_autor);
            this.Controls.Add(this.textBoxedad_estudiante);
            this.Controls.Add(this.labeledad_estudiante);
            this.Controls.Add(this.labelestudiante_estudiante);
            this.Controls.Add(this.textBoxcarrera_estudiante);
            this.Controls.Add(this.textBoxdireccion_estudiante);
            this.Controls.Add(this.textBoxnombre_estudiante);
            this.Controls.Add(this.labelcarrera_estudiante);
            this.Controls.Add(this.labeldireccion_estudiante);
            this.Controls.Add(this.labelnombre_estudiante);
            this.Controls.Add(this.labelautor_autor);
            this.Controls.Add(this.textBoxapellido_autor);
            this.Controls.Add(this.textBoxnacionalidad_autor);
            this.Controls.Add(this.textBoxnombre_autor);
            this.Controls.Add(this.labelapellido_autor);
            this.Controls.Add(this.labelnacionalidad_autor);
            this.Controls.Add(this.labelnombre_autor);
            this.Controls.Add(this.delet);
            this.Controls.Add(this.updat);
            this.Controls.Add(this.Inser);
            this.Controls.Add(this.selec);
            this.Controls.Add(this.conex);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Actividad 3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button conex;
        private System.Windows.Forms.Button selec;
        private System.Windows.Forms.Button Inser;
        private System.Windows.Forms.Button updat;
        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.Label labelnombre_autor;
        private System.Windows.Forms.Label labelnacionalidad_autor;
        private System.Windows.Forms.Label labelapellido_autor;
        private System.Windows.Forms.TextBox textBoxnombre_autor;
        private System.Windows.Forms.TextBox textBoxnacionalidad_autor;
        private System.Windows.Forms.TextBox textBoxapellido_autor;
        private System.Windows.Forms.Label labelautor_autor;
        private System.Windows.Forms.Label labelestudiante_estudiante;
        private System.Windows.Forms.TextBox textBoxcarrera_estudiante;
        private System.Windows.Forms.TextBox textBoxdireccion_estudiante;
        private System.Windows.Forms.TextBox textBoxnombre_estudiante;
        private System.Windows.Forms.Label labelcarrera_estudiante;
        private System.Windows.Forms.Label labeldireccion_estudiante;
        private System.Windows.Forms.Label labelnombre_estudiante;
        private System.Windows.Forms.TextBox textBoxedad_estudiante;
        private System.Windows.Forms.Label labeledad_estudiante;
        private System.Windows.Forms.TextBox textBoxid_autor;
        private System.Windows.Forms.Label labelid_autor;
        private System.Windows.Forms.TextBox textBoxid_estudiante;
        private System.Windows.Forms.Label labelid_estudiante;
        private System.Windows.Forms.TextBox textBoxid_libaut;
        private System.Windows.Forms.Label labelid_libaut;
        private System.Windows.Forms.Label labellibaut_libaut;
        private System.Windows.Forms.TextBox textBoxidlibro_libaut;
        private System.Windows.Forms.TextBox textBoxidautor_libaut;
        private System.Windows.Forms.Label labelidlibro_libaut;
        private System.Windows.Forms.Label labelidautor_libaut;
        private System.Windows.Forms.TextBox textBoxid_libro;
        private System.Windows.Forms.Label labelid_libro;
        private System.Windows.Forms.Label labellibro_libro;
        private System.Windows.Forms.TextBox textBoxeditorial_libro;
        private System.Windows.Forms.TextBox textBoxtitulo_libro;
        private System.Windows.Forms.Label labeleditorial_libro;
        private System.Windows.Forms.Label labeltitulo_libro;
        private System.Windows.Forms.TextBox textBoxcategoria_libro;
        private System.Windows.Forms.Label labelcategoria_libro;
        private System.Windows.Forms.TextBox textBoxid_prestamo;
        private System.Windows.Forms.Label labelid_prestamo;
        private System.Windows.Forms.Label labelprestamo_prestamo;
        private System.Windows.Forms.TextBox textBoxidlibro_prestamo;
        private System.Windows.Forms.TextBox textBoxidlector_prestamo;
        private System.Windows.Forms.Label labelidlibro_prestamo;
        private System.Windows.Forms.Label labelidlector_prestamo;
        private System.Windows.Forms.Label labelfechaprestamo_prestamo;
        private System.Windows.Forms.Label labelfechadevolucion_prestamo;
        private System.Windows.Forms.DateTimePicker dateTimePickerfechaprestamo_prestamo;
        private System.Windows.Forms.DateTimePicker dateTimePickerfechadevolucion_prestamo;
    }
}

