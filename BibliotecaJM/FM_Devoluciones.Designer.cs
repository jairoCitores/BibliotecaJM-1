namespace BibliotecaJM
{
    partial class FM_Devoluciones
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
            System.Windows.Forms.Label id_libLabel;
            System.Windows.Forms.Label titulo_libLabel;
            System.Windows.Forms.Label autor_libLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_lecLabel2 = new System.Windows.Forms.Label();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.bBuscarPorID_lec = new System.Windows.Forms.Button();
            this.nombre_lecLabel2 = new System.Windows.Forms.Label();
            this.domicilio_lecLabel2 = new System.Windows.Forms.Label();
            this.tbIDLec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_penalizacion_lecLabel2 = new System.Windows.Forms.Label();
            this.prestamosDataGridView = new System.Windows.Forms.DataGridView();
            this.id_lec_pre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_lib_pre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnbDevo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Prestamos = new BibliotecaJM.DS_Prestamos();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bVisualizarTodos = new System.Windows.Forms.Button();
            this.id_libLabel1 = new System.Windows.Forms.Label();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.titulo_libLabel1 = new System.Windows.Forms.Label();
            this.autor_libLabel1 = new System.Windows.Forms.Label();
            this.bBuscarPorID_lib = new System.Windows.Forms.Button();
            this.tbIdLib = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.prestamosTableAdapter = new BibliotecaJM.DS_PrestamosTableAdapters.prestamosTableAdapter();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            id_libLabel = new System.Windows.Forms.Label();
            titulo_libLabel = new System.Windows.Forms.Label();
            autor_libLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Prestamos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            this.SuspendLayout();
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
            // id_libLabel
            // 
            id_libLabel.AutoSize = true;
            id_libLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_libLabel.Location = new System.Drawing.Point(30, 91);
            id_libLabel.Name = "id_libLabel";
            id_libLabel.Size = new System.Drawing.Size(24, 13);
            id_libLabel.TabIndex = 3;
            id_libLabel.Text = "ID:";
            // 
            // titulo_libLabel
            // 
            titulo_libLabel.AutoSize = true;
            titulo_libLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo_libLabel.Location = new System.Drawing.Point(30, 114);
            titulo_libLabel.Name = "titulo_libLabel";
            titulo_libLabel.Size = new System.Drawing.Size(45, 13);
            titulo_libLabel.TabIndex = 5;
            titulo_libLabel.Text = "Título:";
            // 
            // autor_libLabel
            // 
            autor_libLabel.AutoSize = true;
            autor_libLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autor_libLabel.Location = new System.Drawing.Point(30, 137);
            autor_libLabel.Name = "autor_libLabel";
            autor_libLabel.Size = new System.Drawing.Size(41, 13);
            autor_libLabel.TabIndex = 7;
            autor_libLabel.Text = "Autor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_lecLabel);
            this.groupBox1.Controls.Add(this.id_lecLabel2);
            this.groupBox1.Controls.Add(this.bBuscarPorID_lec);
            this.groupBox1.Controls.Add(this.nombre_lecLabel2);
            this.groupBox1.Controls.Add(nombre_lecLabel);
            this.groupBox1.Controls.Add(fecha_penalizacion_lecLabel);
            this.groupBox1.Controls.Add(this.domicilio_lecLabel2);
            this.groupBox1.Controls.Add(this.tbIDLec);
            this.groupBox1.Controls.Add(domicilio_lecLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fecha_penalizacion_lecLabel2);
            this.groupBox1.Location = new System.Drawing.Point(495, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Lector";
            // 
            // id_lecLabel2
            // 
            this.id_lecLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecLabel2.Location = new System.Drawing.Point(158, 81);
            this.id_lecLabel2.Name = "id_lecLabel2";
            this.id_lecLabel2.Size = new System.Drawing.Size(200, 23);
            this.id_lecLabel2.TabIndex = 3;
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
            // bBuscarPorID_lec
            // 
            this.bBuscarPorID_lec.Location = new System.Drawing.Point(257, 27);
            this.bBuscarPorID_lec.Name = "bBuscarPorID_lec";
            this.bBuscarPorID_lec.Size = new System.Drawing.Size(114, 23);
            this.bBuscarPorID_lec.TabIndex = 2;
            this.bBuscarPorID_lec.Text = "Buscar por ID";
            this.bBuscarPorID_lec.UseVisualStyleBackColor = true;
            this.bBuscarPorID_lec.Click += new System.EventHandler(this.bBuscarPorID_lec_Click);
            // 
            // nombre_lecLabel2
            // 
            this.nombre_lecLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecLabel2.Location = new System.Drawing.Point(158, 104);
            this.nombre_lecLabel2.Name = "nombre_lecLabel2";
            this.nombre_lecLabel2.Size = new System.Drawing.Size(200, 23);
            this.nombre_lecLabel2.TabIndex = 5;
            // 
            // domicilio_lecLabel2
            // 
            this.domicilio_lecLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecLabel2.Location = new System.Drawing.Point(158, 127);
            this.domicilio_lecLabel2.Name = "domicilio_lecLabel2";
            this.domicilio_lecLabel2.Size = new System.Drawing.Size(200, 23);
            this.domicilio_lecLabel2.TabIndex = 7;
            // 
            // tbIDLec
            // 
            this.tbIDLec.Location = new System.Drawing.Point(81, 30);
            this.tbIDLec.Name = "tbIDLec";
            this.tbIDLec.Size = new System.Drawing.Size(170, 20);
            this.tbIDLec.TabIndex = 1;
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
            // fecha_penalizacion_lecLabel2
            // 
            this.fecha_penalizacion_lecLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecLabel2.Location = new System.Drawing.Point(158, 152);
            this.fecha_penalizacion_lecLabel2.Name = "fecha_penalizacion_lecLabel2";
            this.fecha_penalizacion_lecLabel2.Size = new System.Drawing.Size(200, 23);
            this.fecha_penalizacion_lecLabel2.TabIndex = 15;
            // 
            // prestamosDataGridView
            // 
            this.prestamosDataGridView.AllowUserToAddRows = false;
            this.prestamosDataGridView.AllowUserToDeleteRows = false;
            this.prestamosDataGridView.AllowUserToOrderColumns = true;
            this.prestamosDataGridView.AutoGenerateColumns = false;
            this.prestamosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prestamosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_lec_pre,
            this.dataGridViewTextBoxColumn2,
            this.titulo_lib_pre,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ColumnbDevo});
            this.prestamosDataGridView.DataSource = this.prestamosBindingSource;
            this.prestamosDataGridView.Location = new System.Drawing.Point(12, 221);
            this.prestamosDataGridView.MultiSelect = false;
            this.prestamosDataGridView.Name = "prestamosDataGridView";
            this.prestamosDataGridView.ReadOnly = true;
            this.prestamosDataGridView.RowHeadersVisible = false;
            this.prestamosDataGridView.Size = new System.Drawing.Size(965, 442);
            this.prestamosDataGridView.TabIndex = 2;
            this.prestamosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prestamosDataGridView_CellContentClick);
            // 
            // id_lec_pre
            // 
            this.id_lec_pre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_lec_pre.DataPropertyName = "id_lec_pre";
            this.id_lec_pre.Frozen = true;
            this.id_lec_pre.HeaderText = "ID Lector";
            this.id_lec_pre.Name = "id_lec_pre";
            this.id_lec_pre.ReadOnly = true;
            this.id_lec_pre.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_lib_pre";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 43;
            // 
            // titulo_lib_pre
            // 
            this.titulo_lib_pre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titulo_lib_pre.DataPropertyName = "titulo_lib";
            this.titulo_lib_pre.Frozen = true;
            this.titulo_lib_pre.HeaderText = "Título";
            this.titulo_lib_pre.Name = "titulo_lib_pre";
            this.titulo_lib_pre.ReadOnly = true;
            this.titulo_lib_pre.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha préstamo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 99;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha devolución";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 107;
            // 
            // ColumnbDevo
            // 
            this.ColumnbDevo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnbDevo.HeaderText = "";
            this.ColumnbDevo.Name = "ColumnbDevo";
            this.ColumnbDevo.ReadOnly = true;
            this.ColumnbDevo.Text = "Realizar devolución";
            this.ColumnbDevo.UseColumnTextForButtonValue = true;
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
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bVisualizarTodos);
            this.groupBox2.Controls.Add(id_libLabel);
            this.groupBox2.Controls.Add(this.id_libLabel1);
            this.groupBox2.Controls.Add(titulo_libLabel);
            this.groupBox2.Controls.Add(this.titulo_libLabel1);
            this.groupBox2.Controls.Add(autor_libLabel);
            this.groupBox2.Controls.Add(this.autor_libLabel1);
            this.groupBox2.Controls.Add(this.bBuscarPorID_lib);
            this.groupBox2.Controls.Add(this.tbIdLib);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de Libro";
            // 
            // bVisualizarTodos
            // 
            this.bVisualizarTodos.Location = new System.Drawing.Point(381, 168);
            this.bVisualizarTodos.Name = "bVisualizarTodos";
            this.bVisualizarTodos.Size = new System.Drawing.Size(90, 29);
            this.bVisualizarTodos.TabIndex = 9;
            this.bVisualizarTodos.Text = "Ver todos";
            this.bVisualizarTodos.UseVisualStyleBackColor = true;
            this.bVisualizarTodos.Click += new System.EventHandler(this.bVisualizarTodos_Click);
            // 
            // id_libLabel1
            // 
            this.id_libLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "id_lib", true));
            this.id_libLabel1.Location = new System.Drawing.Point(81, 91);
            this.id_libLabel1.Name = "id_libLabel1";
            this.id_libLabel1.Size = new System.Drawing.Size(225, 23);
            this.id_libLabel1.TabIndex = 4;
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
            // titulo_libLabel1
            // 
            this.titulo_libLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "titulo_lib", true));
            this.titulo_libLabel1.Location = new System.Drawing.Point(81, 114);
            this.titulo_libLabel1.Name = "titulo_libLabel1";
            this.titulo_libLabel1.Size = new System.Drawing.Size(225, 23);
            this.titulo_libLabel1.TabIndex = 6;
            // 
            // autor_libLabel1
            // 
            this.autor_libLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "autor_lib", true));
            this.autor_libLabel1.Location = new System.Drawing.Point(81, 137);
            this.autor_libLabel1.Name = "autor_libLabel1";
            this.autor_libLabel1.Size = new System.Drawing.Size(225, 23);
            this.autor_libLabel1.TabIndex = 8;
            // 
            // bBuscarPorID_lib
            // 
            this.bBuscarPorID_lib.Location = new System.Drawing.Point(257, 27);
            this.bBuscarPorID_lib.Name = "bBuscarPorID_lib";
            this.bBuscarPorID_lib.Size = new System.Drawing.Size(114, 23);
            this.bBuscarPorID_lib.TabIndex = 2;
            this.bBuscarPorID_lib.Text = "Buscar por ID";
            this.bBuscarPorID_lib.UseVisualStyleBackColor = true;
            this.bBuscarPorID_lib.Click += new System.EventHandler(this.bBuscarPorID_lib_Click);
            // 
            // tbIdLib
            // 
            this.tbIdLib.Location = new System.Drawing.Point(81, 30);
            this.tbIdLib.Name = "tbIdLib";
            this.tbIdLib.Size = new System.Drawing.Size(170, 20);
            this.tbIdLib.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID libro";
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // FM_Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1003, 700);
            this.Controls.Add(this.prestamosDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FM_Devoluciones";
            this.Load += new System.EventHandler(this.FM_Devoluciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Prestamos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bBuscarPorID_lec;
        private System.Windows.Forms.TextBox tbIDLec;
        private System.Windows.Forms.Label label1;
        private DS_Prestamos dS_Prestamos;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private DS_PrestamosTableAdapters.prestamosTableAdapter prestamosTableAdapter;
        private System.Windows.Forms.DataGridView prestamosDataGridView;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private System.Windows.Forms.Label id_lecLabel2;
        private System.Windows.Forms.Label nombre_lecLabel2;
        private System.Windows.Forms.Label domicilio_lecLabel2;
        private System.Windows.Forms.Label fecha_penalizacion_lecLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bBuscarPorID_lib;
        private System.Windows.Forms.TextBox tbIdLib;
        private System.Windows.Forms.Label label9;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private System.Windows.Forms.Label id_libLabel1;
        private System.Windows.Forms.Label titulo_libLabel1;
        private System.Windows.Forms.Label autor_libLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button bVisualizarTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lec_pre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_lib_pre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnbDevo;
    }
}
