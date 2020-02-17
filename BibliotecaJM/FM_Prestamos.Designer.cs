namespace BibliotecaJM
{
    partial class FM_Prestamos
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
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.dS_Historico_prestamos = new BibliotecaJM.DS_Historico_prestamos();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Prestamos = new BibliotecaJM.DS_Prestamos();
            this.prestamosTableAdapter = new BibliotecaJM.DS_PrestamosTableAdapters.prestamosTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.prestamosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRealizarPrestamo = new System.Windows.Forms.Button();
            this.BuscarPorAutorLib = new System.Windows.Forms.Button();
            this.bBuscarPorTituloLib = new System.Windows.Forms.Button();
            this.bBuscarPorIDLib = new System.Windows.Forms.Button();
            this.tbAutorLib = new System.Windows.Forms.TextBox();
            this.tbTituloLib = new System.Windows.Forms.TextBox();
            this.tbIDLib = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bBuscarPorID = new System.Windows.Forms.Button();
            this.id_lecLabel1 = new System.Windows.Forms.Label();
            this.fecha_penalizacion_lecLabel1 = new System.Windows.Forms.Label();
            this.nombre_lecLabel1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.domicilio_lecLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Historico_prestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Prestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // dS_Historico_prestamos
            // 
            this.dS_Historico_prestamos.DataSetName = "DS_Historico_prestamos";
            this.dS_Historico_prestamos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "prestamos";
            this.prestamosBindingSource.DataSource = this.dS_Prestamos;
            // 
            // dS_Prestamos
            // 
            this.dS_Prestamos.DataSetName = "DS_Prestamos";
            this.dS_Prestamos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "LIBROS PRESTADOS ACTUALES";
            // 
            // prestamosDataGridView
            // 
            this.prestamosDataGridView.AllowUserToAddRows = false;
            this.prestamosDataGridView.AllowUserToDeleteRows = false;
            this.prestamosDataGridView.AllowUserToResizeRows = false;
            this.prestamosDataGridView.AutoGenerateColumns = false;
            this.prestamosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prestamosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.prestamosDataGridView.DataSource = this.prestamosBindingSource;
            this.prestamosDataGridView.Location = new System.Drawing.Point(13, 259);
            this.prestamosDataGridView.Name = "prestamosDataGridView";
            this.prestamosDataGridView.ReadOnly = true;
            this.prestamosDataGridView.RowHeadersVisible = false;
            this.prestamosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prestamosDataGridView.Size = new System.Drawing.Size(394, 416);
            this.prestamosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_lib_pre";
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn10.HeaderText = "Título";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha préstamo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha devolución";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.librosDataGridView);
            this.groupBox2.Controls.Add(this.bRealizarPrestamo);
            this.groupBox2.Controls.Add(this.BuscarPorAutorLib);
            this.groupBox2.Controls.Add(this.bBuscarPorTituloLib);
            this.groupBox2.Controls.Add(this.bBuscarPorIDLib);
            this.groupBox2.Controls.Add(this.tbAutorLib);
            this.groupBox2.Controls.Add(this.tbTituloLib);
            this.groupBox2.Controls.Add(this.tbIDLib);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(414, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 668);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de Libro";
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToAddRows = false;
            this.librosDataGridView.AllowUserToDeleteRows = false;
            this.librosDataGridView.AllowUserToOrderColumns = true;
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(12, 127);
            this.librosDataGridView.MultiSelect = false;
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.RowHeadersVisible = false;
            this.librosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosDataGridView.Size = new System.Drawing.Size(577, 444);
            this.librosDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn6.HeaderText = "Título";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "autor_lib";
            this.dataGridViewTextBoxColumn7.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "seccion_lib";
            this.dataGridViewTextBoxColumn8.HeaderText = "Sección";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn9.HeaderText = "Prestado";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // bRealizarPrestamo
            // 
            this.bRealizarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRealizarPrestamo.Location = new System.Drawing.Point(27, 591);
            this.bRealizarPrestamo.Name = "bRealizarPrestamo";
            this.bRealizarPrestamo.Size = new System.Drawing.Size(549, 23);
            this.bRealizarPrestamo.TabIndex = 2;
            this.bRealizarPrestamo.Text = "REALIZAR PRÉSTAMO";
            this.bRealizarPrestamo.UseVisualStyleBackColor = true;
            this.bRealizarPrestamo.Click += new System.EventHandler(this.bRealizarPrestamo_Click);
            // 
            // BuscarPorAutorLib
            // 
            this.BuscarPorAutorLib.Location = new System.Drawing.Point(376, 94);
            this.BuscarPorAutorLib.Name = "BuscarPorAutorLib";
            this.BuscarPorAutorLib.Size = new System.Drawing.Size(75, 23);
            this.BuscarPorAutorLib.TabIndex = 2;
            this.BuscarPorAutorLib.Text = "Buscar";
            this.BuscarPorAutorLib.UseVisualStyleBackColor = true;
            this.BuscarPorAutorLib.Click += new System.EventHandler(this.BuscarPorAutorLib_Click);
            // 
            // bBuscarPorTituloLib
            // 
            this.bBuscarPorTituloLib.Location = new System.Drawing.Point(376, 58);
            this.bBuscarPorTituloLib.Name = "bBuscarPorTituloLib";
            this.bBuscarPorTituloLib.Size = new System.Drawing.Size(75, 23);
            this.bBuscarPorTituloLib.TabIndex = 2;
            this.bBuscarPorTituloLib.Text = "Buscar";
            this.bBuscarPorTituloLib.UseVisualStyleBackColor = true;
            this.bBuscarPorTituloLib.Click += new System.EventHandler(this.bBuscarPorTituloLib_Click);
            // 
            // bBuscarPorIDLib
            // 
            this.bBuscarPorIDLib.Location = new System.Drawing.Point(376, 24);
            this.bBuscarPorIDLib.Name = "bBuscarPorIDLib";
            this.bBuscarPorIDLib.Size = new System.Drawing.Size(75, 23);
            this.bBuscarPorIDLib.TabIndex = 2;
            this.bBuscarPorIDLib.Text = "Buscar";
            this.bBuscarPorIDLib.UseVisualStyleBackColor = true;
            this.bBuscarPorIDLib.Click += new System.EventHandler(this.bBuscarPorIDLib_Click);
            // 
            // tbAutorLib
            // 
            this.tbAutorLib.Location = new System.Drawing.Point(85, 96);
            this.tbAutorLib.Name = "tbAutorLib";
            this.tbAutorLib.Size = new System.Drawing.Size(285, 20);
            this.tbAutorLib.TabIndex = 1;
            // 
            // tbTituloLib
            // 
            this.tbTituloLib.Location = new System.Drawing.Point(85, 60);
            this.tbTituloLib.Name = "tbTituloLib";
            this.tbTituloLib.Size = new System.Drawing.Size(285, 20);
            this.tbTituloLib.TabIndex = 1;
            // 
            // tbIDLib
            // 
            this.tbIDLib.Location = new System.Drawing.Point(85, 26);
            this.tbIDLib.Name = "tbIDLib";
            this.tbIDLib.Size = new System.Drawing.Size(285, 20);
            this.tbIDLib.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-325, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Autor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-328, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Título";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Título";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-328, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Libro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_lecLabel);
            this.groupBox1.Controls.Add(this.bBuscarPorID);
            this.groupBox1.Controls.Add(this.id_lecLabel1);
            this.groupBox1.Controls.Add(nombre_lecLabel);
            this.groupBox1.Controls.Add(fecha_penalizacion_lecLabel);
            this.groupBox1.Controls.Add(this.fecha_penalizacion_lecLabel1);
            this.groupBox1.Controls.Add(this.nombre_lecLabel1);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(domicilio_lecLabel);
            this.groupBox1.Controls.Add(this.domicilio_lecLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Lector";
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_lecLabel.Location = new System.Drawing.Point(24, 81);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(64, 13);
            id_lecLabel.TabIndex = 2;
            id_lecLabel.Text = "ID Lector:";
            // 
            // bBuscarPorID
            // 
            this.bBuscarPorID.Location = new System.Drawing.Point(257, 27);
            this.bBuscarPorID.Name = "bBuscarPorID";
            this.bBuscarPorID.Size = new System.Drawing.Size(114, 23);
            this.bBuscarPorID.TabIndex = 2;
            this.bBuscarPorID.Text = "Buscar por ID";
            this.bBuscarPorID.UseVisualStyleBackColor = true;
            this.bBuscarPorID.Click += new System.EventHandler(this.bBuscarPorID_Click);
            // 
            // id_lecLabel1
            // 
            this.id_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecLabel1.Location = new System.Drawing.Point(152, 81);
            this.id_lecLabel1.Name = "id_lecLabel1";
            this.id_lecLabel1.Size = new System.Drawing.Size(219, 23);
            this.id_lecLabel1.TabIndex = 3;
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_lecLabel.Location = new System.Drawing.Point(24, 104);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(54, 13);
            nombre_lecLabel.TabIndex = 4;
            nombre_lecLabel.Text = "Nombre:";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(24, 151);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(121, 13);
            fecha_penalizacion_lecLabel.TabIndex = 14;
            fecha_penalizacion_lecLabel.Text = "Fecha penalización:";
            // 
            // fecha_penalizacion_lecLabel1
            // 
            this.fecha_penalizacion_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecLabel1.Location = new System.Drawing.Point(152, 151);
            this.fecha_penalizacion_lecLabel1.Name = "fecha_penalizacion_lecLabel1";
            this.fecha_penalizacion_lecLabel1.Size = new System.Drawing.Size(219, 23);
            this.fecha_penalizacion_lecLabel1.TabIndex = 15;
            // 
            // nombre_lecLabel1
            // 
            this.nombre_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecLabel1.Location = new System.Drawing.Point(152, 104);
            this.nombre_lecLabel1.Name = "nombre_lecLabel1";
            this.nombre_lecLabel1.Size = new System.Drawing.Size(219, 23);
            this.nombre_lecLabel1.TabIndex = 5;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(81, 30);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(170, 20);
            this.tbID.TabIndex = 1;
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            domicilio_lecLabel.Location = new System.Drawing.Point(24, 127);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(62, 13);
            domicilio_lecLabel.TabIndex = 6;
            domicilio_lecLabel.Text = "Domicilio:";
            // 
            // domicilio_lecLabel1
            // 
            this.domicilio_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecLabel1.Location = new System.Drawing.Point(152, 127);
            this.domicilio_lecLabel1.Name = "domicilio_lecLabel1";
            this.domicilio_lecLabel1.Size = new System.Drawing.Size(219, 23);
            this.domicilio_lecLabel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID lector";
            // 
            // FM_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1032, 687);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prestamosDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FM_Prestamos";
            this.Load += new System.EventHandler(this.FM_Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Historico_prestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Prestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bBuscarPorID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private DS_Historico_prestamos dS_Historico_prestamos;
        private System.Windows.Forms.Label id_lecLabel1;
        private System.Windows.Forms.Label fecha_penalizacion_lecLabel1;
        private System.Windows.Forms.Label nombre_lecLabel1;
        private System.Windows.Forms.Label domicilio_lecLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAutorLib;
        private System.Windows.Forms.TextBox tbTituloLib;
        private System.Windows.Forms.TextBox tbIDLib;
        private System.Windows.Forms.Button BuscarPorAutorLib;
        private System.Windows.Forms.Button bBuscarPorTituloLib;
        private System.Windows.Forms.Button bBuscarPorIDLib;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.Button bRealizarPrestamo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DS_Prestamos dS_Prestamos;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private DS_PrestamosTableAdapters.prestamosTableAdapter prestamosTableAdapter;
        private System.Windows.Forms.DataGridView prestamosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label2;
    }
}
