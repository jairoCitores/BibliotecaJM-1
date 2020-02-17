namespace BibliotecaJM
{
    partial class FM_Libros
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
            System.Windows.Forms.Label id_libLabel;
            System.Windows.Forms.Label titulo_libLabel;
            System.Windows.Forms.Label autor_libLabel;
            System.Windows.Forms.Label seccion_libLabel;
            System.Windows.Forms.Label prestado_sn_libLabel;
            this.gbBuscarLib = new System.Windows.Forms.GroupBox();
            this.bEliminarLib = new System.Windows.Forms.Button();
            this.bModificarLib = new System.Windows.Forms.Button();
            this.bNuevoLib = new System.Windows.Forms.Button();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bBuscarTitulo_Lib = new System.Windows.Forms.Button();
            this.bBuscarID_Lib = new System.Windows.Forms.Button();
            this.tbNombre_Lib = new System.Windows.Forms.TextBox();
            this.tbID_Lib = new System.Windows.Forms.TextBox();
            this.gbDatosLib = new System.Windows.Forms.GroupBox();
            this.tbNomSeccion = new System.Windows.Forms.TextBox();
            this.bLookUpSeccion = new System.Windows.Forms.Button();
            this.bCancelar_lib = new System.Windows.Forms.Button();
            this.bAceptar_lib = new System.Windows.Forms.Button();
            this.id_libTextBox = new System.Windows.Forms.TextBox();
            this.titulo_libTextBox = new System.Windows.Forms.TextBox();
            this.autor_libTextBox = new System.Windows.Forms.TextBox();
            this.seccion_libTextBox = new System.Windows.Forms.TextBox();
            this.prestado_sn_libTextBox = new System.Windows.Forms.TextBox();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            id_libLabel = new System.Windows.Forms.Label();
            titulo_libLabel = new System.Windows.Forms.Label();
            autor_libLabel = new System.Windows.Forms.Label();
            seccion_libLabel = new System.Windows.Forms.Label();
            prestado_sn_libLabel = new System.Windows.Forms.Label();
            this.gbBuscarLib.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            this.gbDatosLib.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_libLabel
            // 
            id_libLabel.AutoSize = true;
            id_libLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_libLabel.Location = new System.Drawing.Point(70, 247);
            id_libLabel.Name = "id_libLabel";
            id_libLabel.Size = new System.Drawing.Size(24, 13);
            id_libLabel.TabIndex = 0;
            id_libLabel.Text = "ID:";
            // 
            // titulo_libLabel
            // 
            titulo_libLabel.AutoSize = true;
            titulo_libLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo_libLabel.Location = new System.Drawing.Point(70, 273);
            titulo_libLabel.Name = "titulo_libLabel";
            titulo_libLabel.Size = new System.Drawing.Size(45, 13);
            titulo_libLabel.TabIndex = 2;
            titulo_libLabel.Text = "Título:";
            // 
            // autor_libLabel
            // 
            autor_libLabel.AutoSize = true;
            autor_libLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autor_libLabel.Location = new System.Drawing.Point(70, 299);
            autor_libLabel.Name = "autor_libLabel";
            autor_libLabel.Size = new System.Drawing.Size(41, 13);
            autor_libLabel.TabIndex = 4;
            autor_libLabel.Text = "Autor:";
            // 
            // seccion_libLabel
            // 
            seccion_libLabel.AutoSize = true;
            seccion_libLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            seccion_libLabel.Location = new System.Drawing.Point(70, 325);
            seccion_libLabel.Name = "seccion_libLabel";
            seccion_libLabel.Size = new System.Drawing.Size(57, 13);
            seccion_libLabel.TabIndex = 6;
            seccion_libLabel.Text = "Sección:";
            // 
            // prestado_sn_libLabel
            // 
            prestado_sn_libLabel.AutoSize = true;
            prestado_sn_libLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prestado_sn_libLabel.Location = new System.Drawing.Point(70, 351);
            prestado_sn_libLabel.Name = "prestado_sn_libLabel";
            prestado_sn_libLabel.Size = new System.Drawing.Size(61, 13);
            prestado_sn_libLabel.TabIndex = 8;
            prestado_sn_libLabel.Text = "Prestado:";
            // 
            // gbBuscarLib
            // 
            this.gbBuscarLib.Controls.Add(this.bEliminarLib);
            this.gbBuscarLib.Controls.Add(this.bModificarLib);
            this.gbBuscarLib.Controls.Add(this.bNuevoLib);
            this.gbBuscarLib.Controls.Add(this.librosDataGridView);
            this.gbBuscarLib.Controls.Add(this.label3);
            this.gbBuscarLib.Controls.Add(this.label2);
            this.gbBuscarLib.Controls.Add(this.label1);
            this.gbBuscarLib.Controls.Add(this.bBuscarTitulo_Lib);
            this.gbBuscarLib.Controls.Add(this.bBuscarID_Lib);
            this.gbBuscarLib.Controls.Add(this.tbNombre_Lib);
            this.gbBuscarLib.Controls.Add(this.tbID_Lib);
            this.gbBuscarLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscarLib.Location = new System.Drawing.Point(9, 3);
            this.gbBuscarLib.Name = "gbBuscarLib";
            this.gbBuscarLib.Size = new System.Drawing.Size(490, 676);
            this.gbBuscarLib.TabIndex = 0;
            this.gbBuscarLib.TabStop = false;
            this.gbBuscarLib.Text = "Buscar Libro";
            // 
            // bEliminarLib
            // 
            this.bEliminarLib.Location = new System.Drawing.Point(350, 632);
            this.bEliminarLib.Name = "bEliminarLib";
            this.bEliminarLib.Size = new System.Drawing.Size(111, 23);
            this.bEliminarLib.TabIndex = 15;
            this.bEliminarLib.Text = "Eliminar";
            this.bEliminarLib.UseVisualStyleBackColor = true;
            this.bEliminarLib.Click += new System.EventHandler(this.bEliminarLib_Click);
            // 
            // bModificarLib
            // 
            this.bModificarLib.Location = new System.Drawing.Point(191, 632);
            this.bModificarLib.Name = "bModificarLib";
            this.bModificarLib.Size = new System.Drawing.Size(111, 23);
            this.bModificarLib.TabIndex = 16;
            this.bModificarLib.Text = "Modificar";
            this.bModificarLib.UseVisualStyleBackColor = true;
            this.bModificarLib.Click += new System.EventHandler(this.bModificarLib_Click);
            // 
            // bNuevoLib
            // 
            this.bNuevoLib.Location = new System.Drawing.Point(32, 632);
            this.bNuevoLib.Name = "bNuevoLib";
            this.bNuevoLib.Size = new System.Drawing.Size(111, 23);
            this.bNuevoLib.TabIndex = 17;
            this.bNuevoLib.Text = "Nuevo";
            this.bNuevoLib.UseVisualStyleBackColor = true;
            this.bNuevoLib.Click += new System.EventHandler(this.bNuevoLib_Click);
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(6, 75);
            this.librosDataGridView.MultiSelect = false;
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosDataGridView.Size = new System.Drawing.Size(478, 541);
            this.librosDataGridView.TabIndex = 14;
            this.librosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.librosDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.HeaderText = "Título";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prestado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "(campo vacio = ver todos)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // bBuscarTitulo_Lib
            // 
            this.bBuscarTitulo_Lib.Location = new System.Drawing.Point(198, 44);
            this.bBuscarTitulo_Lib.Name = "bBuscarTitulo_Lib";
            this.bBuscarTitulo_Lib.Size = new System.Drawing.Size(111, 23);
            this.bBuscarTitulo_Lib.TabIndex = 10;
            this.bBuscarTitulo_Lib.Text = "Buscar por título";
            this.bBuscarTitulo_Lib.UseVisualStyleBackColor = true;
            this.bBuscarTitulo_Lib.Click += new System.EventHandler(this.bBuscarTitulo_Lib_Click);
            // 
            // bBuscarID_Lib
            // 
            this.bBuscarID_Lib.Location = new System.Drawing.Point(198, 18);
            this.bBuscarID_Lib.Name = "bBuscarID_Lib";
            this.bBuscarID_Lib.Size = new System.Drawing.Size(111, 23);
            this.bBuscarID_Lib.TabIndex = 11;
            this.bBuscarID_Lib.Text = "Buscar por ID";
            this.bBuscarID_Lib.UseVisualStyleBackColor = true;
            this.bBuscarID_Lib.Click += new System.EventHandler(this.bBuscarID_Lib_Click);
            // 
            // tbNombre_Lib
            // 
            this.tbNombre_Lib.Location = new System.Drawing.Point(69, 46);
            this.tbNombre_Lib.Name = "tbNombre_Lib";
            this.tbNombre_Lib.Size = new System.Drawing.Size(123, 20);
            this.tbNombre_Lib.TabIndex = 8;
            // 
            // tbID_Lib
            // 
            this.tbID_Lib.Location = new System.Drawing.Point(69, 20);
            this.tbID_Lib.Name = "tbID_Lib";
            this.tbID_Lib.Size = new System.Drawing.Size(123, 20);
            this.tbID_Lib.TabIndex = 9;
            // 
            // gbDatosLib
            // 
            this.gbDatosLib.Controls.Add(this.tbNomSeccion);
            this.gbDatosLib.Controls.Add(this.bLookUpSeccion);
            this.gbDatosLib.Controls.Add(this.bCancelar_lib);
            this.gbDatosLib.Controls.Add(id_libLabel);
            this.gbDatosLib.Controls.Add(this.bAceptar_lib);
            this.gbDatosLib.Controls.Add(this.id_libTextBox);
            this.gbDatosLib.Controls.Add(titulo_libLabel);
            this.gbDatosLib.Controls.Add(this.titulo_libTextBox);
            this.gbDatosLib.Controls.Add(autor_libLabel);
            this.gbDatosLib.Controls.Add(this.autor_libTextBox);
            this.gbDatosLib.Controls.Add(seccion_libLabel);
            this.gbDatosLib.Controls.Add(this.seccion_libTextBox);
            this.gbDatosLib.Controls.Add(prestado_sn_libLabel);
            this.gbDatosLib.Controls.Add(this.prestado_sn_libTextBox);
            this.gbDatosLib.Location = new System.Drawing.Point(505, 3);
            this.gbDatosLib.Name = "gbDatosLib";
            this.gbDatosLib.Size = new System.Drawing.Size(490, 676);
            this.gbDatosLib.TabIndex = 1;
            this.gbDatosLib.TabStop = false;
            this.gbDatosLib.Text = "Datos del Libro";
            // 
            // tbNomSeccion
            // 
            this.tbNomSeccion.Location = new System.Drawing.Point(208, 322);
            this.tbNomSeccion.Name = "tbNomSeccion";
            this.tbNomSeccion.ReadOnly = true;
            this.tbNomSeccion.Size = new System.Drawing.Size(223, 20);
            this.tbNomSeccion.TabIndex = 11;
            // 
            // bLookUpSeccion
            // 
            this.bLookUpSeccion.Location = new System.Drawing.Point(433, 322);
            this.bLookUpSeccion.Name = "bLookUpSeccion";
            this.bLookUpSeccion.Size = new System.Drawing.Size(26, 20);
            this.bLookUpSeccion.TabIndex = 10;
            this.bLookUpSeccion.Text = "...";
            this.bLookUpSeccion.UseVisualStyleBackColor = true;
            this.bLookUpSeccion.Click += new System.EventHandler(this.bLookUpSeccion_Click);
            // 
            // bCancelar_lib
            // 
            this.bCancelar_lib.Location = new System.Drawing.Point(280, 404);
            this.bCancelar_lib.Name = "bCancelar_lib";
            this.bCancelar_lib.Size = new System.Drawing.Size(111, 23);
            this.bCancelar_lib.TabIndex = 2;
            this.bCancelar_lib.Text = "Cancelar";
            this.bCancelar_lib.UseVisualStyleBackColor = true;
            this.bCancelar_lib.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar_lib
            // 
            this.bAceptar_lib.Location = new System.Drawing.Point(139, 404);
            this.bAceptar_lib.Name = "bAceptar_lib";
            this.bAceptar_lib.Size = new System.Drawing.Size(111, 23);
            this.bAceptar_lib.TabIndex = 3;
            this.bAceptar_lib.Text = "Aceptar";
            this.bAceptar_lib.UseVisualStyleBackColor = true;
            this.bAceptar_lib.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // id_libTextBox
            // 
            this.id_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "id_lib", true));
            this.id_libTextBox.Location = new System.Drawing.Point(139, 244);
            this.id_libTextBox.Name = "id_libTextBox";
            this.id_libTextBox.ReadOnly = true;
            this.id_libTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_libTextBox.TabIndex = 1;
            // 
            // titulo_libTextBox
            // 
            this.titulo_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "titulo_lib", true));
            this.titulo_libTextBox.Location = new System.Drawing.Point(139, 270);
            this.titulo_libTextBox.Name = "titulo_libTextBox";
            this.titulo_libTextBox.Size = new System.Drawing.Size(292, 20);
            this.titulo_libTextBox.TabIndex = 3;
            // 
            // autor_libTextBox
            // 
            this.autor_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "autor_lib", true));
            this.autor_libTextBox.Location = new System.Drawing.Point(139, 296);
            this.autor_libTextBox.Name = "autor_libTextBox";
            this.autor_libTextBox.Size = new System.Drawing.Size(292, 20);
            this.autor_libTextBox.TabIndex = 5;
            // 
            // seccion_libTextBox
            // 
            this.seccion_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "seccion_lib", true));
            this.seccion_libTextBox.Location = new System.Drawing.Point(139, 322);
            this.seccion_libTextBox.Name = "seccion_libTextBox";
            this.seccion_libTextBox.ReadOnly = true;
            this.seccion_libTextBox.Size = new System.Drawing.Size(63, 20);
            this.seccion_libTextBox.TabIndex = 7;
            // 
            // prestado_sn_libTextBox
            // 
            this.prestado_sn_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "prestado_sn_lib", true));
            this.prestado_sn_libTextBox.Location = new System.Drawing.Point(139, 348);
            this.prestado_sn_libTextBox.Name = "prestado_sn_libTextBox";
            this.prestado_sn_libTextBox.Size = new System.Drawing.Size(30, 20);
            this.prestado_sn_libTextBox.TabIndex = 9;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // FM_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 687);
            this.Controls.Add(this.gbDatosLib);
            this.Controls.Add(this.gbBuscarLib);
            this.Name = "FM_Libros";
            this.Load += new System.EventHandler(this.FM_Libros_Load);
            this.gbBuscarLib.ResumeLayout(false);
            this.gbBuscarLib.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            this.gbDatosLib.ResumeLayout(false);
            this.gbDatosLib.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscarLib;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBuscarTitulo_Lib;
        private System.Windows.Forms.Button bBuscarID_Lib;
        private System.Windows.Forms.TextBox tbNombre_Lib;
        private System.Windows.Forms.TextBox tbID_Lib;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.Button bEliminarLib;
        private System.Windows.Forms.Button bModificarLib;
        private System.Windows.Forms.Button bNuevoLib;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox gbDatosLib;
        private System.Windows.Forms.TextBox id_libTextBox;
        private System.Windows.Forms.TextBox titulo_libTextBox;
        private System.Windows.Forms.TextBox autor_libTextBox;
        private System.Windows.Forms.TextBox seccion_libTextBox;
        private System.Windows.Forms.TextBox prestado_sn_libTextBox;
        private System.Windows.Forms.Button bCancelar_lib;
        private System.Windows.Forms.Button bAceptar_lib;
        private System.Windows.Forms.Button bLookUpSeccion;
        private System.Windows.Forms.TextBox tbNomSeccion;
    }
}
