namespace BibliotecaJM
{
    partial class FM_Lectores
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
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label provincia_lecLabel;
            System.Windows.Forms.Label email_lecLabel;
            System.Windows.Forms.Label fecha_nacimiento_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            this.gbDatosLector = new System.Windows.Forms.GroupBox();
            this.tbNom_ProvLec_Lectores = new System.Windows.Forms.TextBox();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Provincias = new BibliotecaJM.DS_Provincias();
            this.bLookUpProvincia = new System.Windows.Forms.Button();
            this.id_lecTextBox = new System.Windows.Forms.TextBox();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.nombre_lecTextBox = new System.Windows.Forms.TextBox();
            this.domicilio_lecTextBox = new System.Windows.Forms.TextBox();
            this.tbID_ProvLec_lectores = new System.Windows.Forms.TextBox();
            this.email_lecTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacimiento_lecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_penalizacion_lecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.lectoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bBuscarNombre = new System.Windows.Forms.Button();
            this.bEliminarLec = new System.Windows.Forms.Button();
            this.bModificarLec = new System.Windows.Forms.Button();
            this.bNuevoLec = new System.Windows.Forms.Button();
            this.bBuscarID = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.provinciasTableAdapter = new BibliotecaJM.DS_ProvinciasTableAdapters.provinciasTableAdapter();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            provincia_lecLabel = new System.Windows.Forms.Label();
            email_lecLabel = new System.Windows.Forms.Label();
            fecha_nacimiento_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            this.gbDatosLector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_lecLabel.Location = new System.Drawing.Point(59, 237);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(24, 13);
            id_lecLabel.TabIndex = 2;
            id_lecLabel.Text = "ID:";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_lecLabel.Location = new System.Drawing.Point(59, 263);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(54, 13);
            nombre_lecLabel.TabIndex = 4;
            nombre_lecLabel.Text = "Nombre:";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            domicilio_lecLabel.Location = new System.Drawing.Point(59, 289);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(62, 13);
            domicilio_lecLabel.TabIndex = 6;
            domicilio_lecLabel.Text = "Domicilio:";
            // 
            // provincia_lecLabel
            // 
            provincia_lecLabel.AutoSize = true;
            provincia_lecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            provincia_lecLabel.Location = new System.Drawing.Point(59, 315);
            provincia_lecLabel.Name = "provincia_lecLabel";
            provincia_lecLabel.Size = new System.Drawing.Size(64, 13);
            provincia_lecLabel.TabIndex = 8;
            provincia_lecLabel.Text = "Provincia:";
            // 
            // email_lecLabel
            // 
            email_lecLabel.AutoSize = true;
            email_lecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            email_lecLabel.Location = new System.Drawing.Point(59, 341);
            email_lecLabel.Name = "email_lecLabel";
            email_lecLabel.Size = new System.Drawing.Size(45, 13);
            email_lecLabel.TabIndex = 10;
            email_lecLabel.Text = "E-mail:";
            // 
            // fecha_nacimiento_lecLabel
            // 
            fecha_nacimiento_lecLabel.AutoSize = true;
            fecha_nacimiento_lecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha_nacimiento_lecLabel.Location = new System.Drawing.Point(59, 368);
            fecha_nacimiento_lecLabel.Name = "fecha_nacimiento_lecLabel";
            fecha_nacimiento_lecLabel.Size = new System.Drawing.Size(129, 13);
            fecha_nacimiento_lecLabel.TabIndex = 12;
            fecha_nacimiento_lecLabel.Text = "Fecha de nacimiento:";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(59, 394);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(139, 13);
            fecha_penalizacion_lecLabel.TabIndex = 14;
            fecha_penalizacion_lecLabel.Text = "Fecha de penalizacion:";
            // 
            // gbDatosLector
            // 
            this.gbDatosLector.Controls.Add(this.tbNom_ProvLec_Lectores);
            this.gbDatosLector.Controls.Add(this.bLookUpProvincia);
            this.gbDatosLector.Controls.Add(id_lecLabel);
            this.gbDatosLector.Controls.Add(this.id_lecTextBox);
            this.gbDatosLector.Controls.Add(nombre_lecLabel);
            this.gbDatosLector.Controls.Add(this.nombre_lecTextBox);
            this.gbDatosLector.Controls.Add(domicilio_lecLabel);
            this.gbDatosLector.Controls.Add(this.domicilio_lecTextBox);
            this.gbDatosLector.Controls.Add(provincia_lecLabel);
            this.gbDatosLector.Controls.Add(this.tbID_ProvLec_lectores);
            this.gbDatosLector.Controls.Add(email_lecLabel);
            this.gbDatosLector.Controls.Add(this.email_lecTextBox);
            this.gbDatosLector.Controls.Add(fecha_nacimiento_lecLabel);
            this.gbDatosLector.Controls.Add(this.fecha_nacimiento_lecDateTimePicker);
            this.gbDatosLector.Controls.Add(fecha_penalizacion_lecLabel);
            this.gbDatosLector.Controls.Add(this.fecha_penalizacion_lecDateTimePicker);
            this.gbDatosLector.Controls.Add(this.bCancelar);
            this.gbDatosLector.Controls.Add(this.bAceptar);
            this.gbDatosLector.Location = new System.Drawing.Point(505, 4);
            this.gbDatosLector.Name = "gbDatosLector";
            this.gbDatosLector.Size = new System.Drawing.Size(507, 661);
            this.gbDatosLector.TabIndex = 4;
            this.gbDatosLector.TabStop = false;
            this.gbDatosLector.Text = "Datos del lector";
            // 
            // tbNom_ProvLec_Lectores
            // 
            this.tbNom_ProvLec_Lectores.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provinciasBindingSource, "provincia_pro", true));
            this.tbNom_ProvLec_Lectores.Location = new System.Drawing.Point(248, 312);
            this.tbNom_ProvLec_Lectores.Name = "tbNom_ProvLec_Lectores";
            this.tbNom_ProvLec_Lectores.ReadOnly = true;
            this.tbNom_ProvLec_Lectores.Size = new System.Drawing.Size(133, 20);
            this.tbNom_ProvLec_Lectores.TabIndex = 17;
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.dS_Provincias;
            // 
            // dS_Provincias
            // 
            this.dS_Provincias.DataSetName = "DS_Provincias";
            this.dS_Provincias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bLookUpProvincia
            // 
            this.bLookUpProvincia.Location = new System.Drawing.Point(378, 312);
            this.bLookUpProvincia.Name = "bLookUpProvincia";
            this.bLookUpProvincia.Size = new System.Drawing.Size(30, 20);
            this.bLookUpProvincia.TabIndex = 16;
            this.bLookUpProvincia.Text = "...";
            this.bLookUpProvincia.UseVisualStyleBackColor = true;
            this.bLookUpProvincia.Click += new System.EventHandler(this.bLookUpProvincia_Click);
            // 
            // id_lecTextBox
            // 
            this.id_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecTextBox.Location = new System.Drawing.Point(208, 234);
            this.id_lecTextBox.Name = "id_lecTextBox";
            this.id_lecTextBox.ReadOnly = true;
            this.id_lecTextBox.Size = new System.Drawing.Size(59, 20);
            this.id_lecTextBox.TabIndex = 3;
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
            // nombre_lecTextBox
            // 
            this.nombre_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecTextBox.Location = new System.Drawing.Point(208, 260);
            this.nombre_lecTextBox.Name = "nombre_lecTextBox";
            this.nombre_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombre_lecTextBox.TabIndex = 5;
            // 
            // domicilio_lecTextBox
            // 
            this.domicilio_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecTextBox.Location = new System.Drawing.Point(208, 286);
            this.domicilio_lecTextBox.Name = "domicilio_lecTextBox";
            this.domicilio_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.domicilio_lecTextBox.TabIndex = 7;
            // 
            // tbID_ProvLec_lectores
            // 
            this.tbID_ProvLec_lectores.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "provincia_lec", true));
            this.tbID_ProvLec_lectores.Location = new System.Drawing.Point(208, 312);
            this.tbID_ProvLec_lectores.Name = "tbID_ProvLec_lectores";
            this.tbID_ProvLec_lectores.ReadOnly = true;
            this.tbID_ProvLec_lectores.Size = new System.Drawing.Size(33, 20);
            this.tbID_ProvLec_lectores.TabIndex = 9;
            this.tbID_ProvLec_lectores.TextChanged += new System.EventHandler(this.tbID_ProvLec_lectores_TextChanged);
            // 
            // email_lecTextBox
            // 
            this.email_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "email_lec", true));
            this.email_lecTextBox.Location = new System.Drawing.Point(208, 338);
            this.email_lecTextBox.Name = "email_lecTextBox";
            this.email_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.email_lecTextBox.TabIndex = 11;
            // 
            // fecha_nacimiento_lecDateTimePicker
            // 
            this.fecha_nacimiento_lecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lectoresBindingSource, "fecha_nacimiento_lec", true));
            this.fecha_nacimiento_lecDateTimePicker.Location = new System.Drawing.Point(208, 364);
            this.fecha_nacimiento_lecDateTimePicker.Name = "fecha_nacimiento_lecDateTimePicker";
            this.fecha_nacimiento_lecDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_nacimiento_lecDateTimePicker.TabIndex = 13;
            // 
            // fecha_penalizacion_lecDateTimePicker
            // 
            this.fecha_penalizacion_lecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecDateTimePicker.Location = new System.Drawing.Point(208, 390);
            this.fecha_penalizacion_lecDateTimePicker.Name = "fecha_penalizacion_lecDateTimePicker";
            this.fecha_penalizacion_lecDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_penalizacion_lecDateTimePicker.TabIndex = 15;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(297, 439);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(111, 23);
            this.bCancelar.TabIndex = 1;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(156, 439);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(111, 23);
            this.bAceptar.TabIndex = 1;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.lectoresDataGridView);
            this.gbBuscar.Controls.Add(this.label3);
            this.gbBuscar.Controls.Add(this.label2);
            this.gbBuscar.Controls.Add(this.label1);
            this.gbBuscar.Controls.Add(this.bBuscarNombre);
            this.gbBuscar.Controls.Add(this.bEliminarLec);
            this.gbBuscar.Controls.Add(this.bModificarLec);
            this.gbBuscar.Controls.Add(this.bNuevoLec);
            this.gbBuscar.Controls.Add(this.bBuscarID);
            this.gbBuscar.Controls.Add(this.tbNombre);
            this.gbBuscar.Controls.Add(this.tbID);
            this.gbBuscar.Location = new System.Drawing.Point(9, 4);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(490, 661);
            this.gbBuscar.TabIndex = 3;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar Lector";
            // 
            // lectoresDataGridView
            // 
            this.lectoresDataGridView.AllowUserToAddRows = false;
            this.lectoresDataGridView.AllowUserToDeleteRows = false;
            this.lectoresDataGridView.AutoGenerateColumns = false;
            this.lectoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.lectoresDataGridView.DataSource = this.lectoresBindingSource;
            this.lectoresDataGridView.Location = new System.Drawing.Point(6, 70);
            this.lectoresDataGridView.MultiSelect = false;
            this.lectoresDataGridView.Name = "lectoresDataGridView";
            this.lectoresDataGridView.ReadOnly = true;
            this.lectoresDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lectoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lectoresDataGridView.Size = new System.Drawing.Size(478, 541);
            this.lectoresDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lec";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_lec";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "domicilio_lec";
            this.dataGridViewTextBoxColumn3.HeaderText = "Domicilio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(campo vacio = ver todos)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Location = new System.Drawing.Point(197, 42);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(111, 23);
            this.bBuscarNombre.TabIndex = 1;
            this.bBuscarNombre.Text = "Buscar por nombre";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            this.bBuscarNombre.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // bEliminarLec
            // 
            this.bEliminarLec.Location = new System.Drawing.Point(350, 623);
            this.bEliminarLec.Name = "bEliminarLec";
            this.bEliminarLec.Size = new System.Drawing.Size(111, 23);
            this.bEliminarLec.TabIndex = 1;
            this.bEliminarLec.Text = "Eliminar";
            this.bEliminarLec.UseVisualStyleBackColor = true;
            this.bEliminarLec.Click += new System.EventHandler(this.bEliminarLec_Click);
            // 
            // bModificarLec
            // 
            this.bModificarLec.Location = new System.Drawing.Point(191, 623);
            this.bModificarLec.Name = "bModificarLec";
            this.bModificarLec.Size = new System.Drawing.Size(111, 23);
            this.bModificarLec.TabIndex = 1;
            this.bModificarLec.Text = "Modificar";
            this.bModificarLec.UseVisualStyleBackColor = true;
            this.bModificarLec.Click += new System.EventHandler(this.bModificarLec_Click);
            // 
            // bNuevoLec
            // 
            this.bNuevoLec.Location = new System.Drawing.Point(32, 623);
            this.bNuevoLec.Name = "bNuevoLec";
            this.bNuevoLec.Size = new System.Drawing.Size(111, 23);
            this.bNuevoLec.TabIndex = 1;
            this.bNuevoLec.Text = "Nuevo";
            this.bNuevoLec.UseVisualStyleBackColor = true;
            this.bNuevoLec.Click += new System.EventHandler(this.bNuevoLec_Click);
            // 
            // bBuscarID
            // 
            this.bBuscarID.Location = new System.Drawing.Point(197, 16);
            this.bBuscarID.Name = "bBuscarID";
            this.bBuscarID.Size = new System.Drawing.Size(111, 23);
            this.bBuscarID.TabIndex = 1;
            this.bBuscarID.Text = "Buscar por ID";
            this.bBuscarID.UseVisualStyleBackColor = true;
            this.bBuscarID.Click += new System.EventHandler(this.bBuscarID_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(68, 44);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(123, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(68, 18);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(123, 20);
            this.tbID.TabIndex = 0;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // FM_Lectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1023, 675);
            this.Controls.Add(this.gbDatosLector);
            this.Controls.Add(this.gbBuscar);
            this.Name = "FM_Lectores";
            this.Load += new System.EventHandler(this.FM_Lectores_Load);
            this.gbDatosLector.ResumeLayout(false);
            this.gbDatosLector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private System.Windows.Forms.GroupBox gbDatosLector;
        private System.Windows.Forms.TextBox id_lecTextBox;
        private System.Windows.Forms.TextBox nombre_lecTextBox;
        private System.Windows.Forms.TextBox domicilio_lecTextBox;
        private System.Windows.Forms.TextBox tbID_ProvLec_lectores;
        private System.Windows.Forms.TextBox email_lecTextBox;
        private System.Windows.Forms.DateTimePicker fecha_nacimiento_lecDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_penalizacion_lecDateTimePicker;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBuscarNombre;
        private System.Windows.Forms.Button bEliminarLec;
        private System.Windows.Forms.Button bModificarLec;
        private System.Windows.Forms.Button bNuevoLec;
        private System.Windows.Forms.Button bBuscarID;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button bLookUpProvincia;
        private System.Windows.Forms.DataGridView lectoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox tbNom_ProvLec_Lectores;
        private DS_Provincias dS_Provincias;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private DS_ProvinciasTableAdapters.provinciasTableAdapter provinciasTableAdapter;
    }
}
