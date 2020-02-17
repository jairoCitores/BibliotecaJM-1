namespace BibliotecaJM
{
    partial class FM_Configuracion
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
            System.Windows.Forms.Label nombre_biblioteca_cnfLabel;
            System.Windows.Forms.Label direccion_cnfLabel;
            System.Windows.Forms.Label provincia_cnfLabel;
            System.Windows.Forms.Label dias_prestamo_cnfLabel;
            System.Windows.Forms.Label dias_penalizacion_cnfLabel;
            this.dS_Configuracion = new BibliotecaJM.DS_Configuracion();
            this.configuracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configuracionTableAdapter = new BibliotecaJM.DS_ConfiguracionTableAdapters.configuracionTableAdapter();
            this.nombre_biblioteca_cnfTextBox = new System.Windows.Forms.TextBox();
            this.direccion_cnfTextBox = new System.Windows.Forms.TextBox();
            this.tbID_Prov_conf = new System.Windows.Forms.TextBox();
            this.dias_prestamo_cnfTextBox = new System.Windows.Forms.TextBox();
            this.dias_penalizacion_cnfTextBox = new System.Windows.Forms.TextBox();
            this.gbConfiguración = new System.Windows.Forms.GroupBox();
            this.bLookUpProv = new System.Windows.Forms.Button();
            this.tbNombre_Prov_Conf = new System.Windows.Forms.TextBox();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Provincias = new BibliotecaJM.DS_Provincias();
            this.bModificar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.provinciasTableAdapter = new BibliotecaJM.DS_ProvinciasTableAdapters.provinciasTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_ProvinciasTableAdapters.TableAdapterManager();
            nombre_biblioteca_cnfLabel = new System.Windows.Forms.Label();
            direccion_cnfLabel = new System.Windows.Forms.Label();
            provincia_cnfLabel = new System.Windows.Forms.Label();
            dias_prestamo_cnfLabel = new System.Windows.Forms.Label();
            dias_penalizacion_cnfLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Configuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionBindingSource)).BeginInit();
            this.gbConfiguración.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_biblioteca_cnfLabel
            // 
            nombre_biblioteca_cnfLabel.AutoSize = true;
            nombre_biblioteca_cnfLabel.Location = new System.Drawing.Point(26, 32);
            nombre_biblioteca_cnfLabel.Name = "nombre_biblioteca_cnfLabel";
            nombre_biblioteca_cnfLabel.Size = new System.Drawing.Size(118, 13);
            nombre_biblioteca_cnfLabel.TabIndex = 1;
            nombre_biblioteca_cnfLabel.Text = "Nombre de la biblioteca";
            // 
            // direccion_cnfLabel
            // 
            direccion_cnfLabel.AutoSize = true;
            direccion_cnfLabel.Location = new System.Drawing.Point(28, 58);
            direccion_cnfLabel.Name = "direccion_cnfLabel";
            direccion_cnfLabel.Size = new System.Drawing.Size(52, 13);
            direccion_cnfLabel.TabIndex = 3;
            direccion_cnfLabel.Text = "Dirección";
            // 
            // provincia_cnfLabel
            // 
            provincia_cnfLabel.AutoSize = true;
            provincia_cnfLabel.Location = new System.Drawing.Point(28, 84);
            provincia_cnfLabel.Name = "provincia_cnfLabel";
            provincia_cnfLabel.Size = new System.Drawing.Size(51, 13);
            provincia_cnfLabel.TabIndex = 5;
            provincia_cnfLabel.Text = "Provincia";
            // 
            // dias_prestamo_cnfLabel
            // 
            dias_prestamo_cnfLabel.AutoSize = true;
            dias_prestamo_cnfLabel.Location = new System.Drawing.Point(28, 110);
            dias_prestamo_cnfLabel.Name = "dias_prestamo_cnfLabel";
            dias_prestamo_cnfLabel.Size = new System.Drawing.Size(137, 13);
            dias_prestamo_cnfLabel.TabIndex = 7;
            dias_prestamo_cnfLabel.Text = "Dias maximos de prestamos";
            // 
            // dias_penalizacion_cnfLabel
            // 
            dias_penalizacion_cnfLabel.AutoSize = true;
            dias_penalizacion_cnfLabel.Location = new System.Drawing.Point(28, 136);
            dias_penalizacion_cnfLabel.Name = "dias_penalizacion_cnfLabel";
            dias_penalizacion_cnfLabel.Size = new System.Drawing.Size(107, 13);
            dias_penalizacion_cnfLabel.TabIndex = 9;
            dias_penalizacion_cnfLabel.Text = "Días de penalizacion";
            // 
            // dS_Configuracion
            // 
            this.dS_Configuracion.DataSetName = "DS_Configuracion";
            this.dS_Configuracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configuracionBindingSource
            // 
            this.configuracionBindingSource.DataMember = "configuracion";
            this.configuracionBindingSource.DataSource = this.dS_Configuracion;
            // 
            // configuracionTableAdapter
            // 
            this.configuracionTableAdapter.ClearBeforeFill = true;
            // 
            // nombre_biblioteca_cnfTextBox
            // 
            this.nombre_biblioteca_cnfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuracionBindingSource, "nombre_biblioteca_cnf", true));
            this.nombre_biblioteca_cnfTextBox.Location = new System.Drawing.Point(171, 25);
            this.nombre_biblioteca_cnfTextBox.Name = "nombre_biblioteca_cnfTextBox";
            this.nombre_biblioteca_cnfTextBox.Size = new System.Drawing.Size(316, 20);
            this.nombre_biblioteca_cnfTextBox.TabIndex = 2;
            // 
            // direccion_cnfTextBox
            // 
            this.direccion_cnfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuracionBindingSource, "direccion_cnf", true));
            this.direccion_cnfTextBox.Location = new System.Drawing.Point(171, 51);
            this.direccion_cnfTextBox.Name = "direccion_cnfTextBox";
            this.direccion_cnfTextBox.Size = new System.Drawing.Size(316, 20);
            this.direccion_cnfTextBox.TabIndex = 4;
            // 
            // tbID_Prov_conf
            // 
            this.tbID_Prov_conf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuracionBindingSource, "provincia_cnf", true));
            this.tbID_Prov_conf.Location = new System.Drawing.Point(171, 77);
            this.tbID_Prov_conf.Name = "tbID_Prov_conf";
            this.tbID_Prov_conf.ReadOnly = true;
            this.tbID_Prov_conf.Size = new System.Drawing.Size(49, 20);
            this.tbID_Prov_conf.TabIndex = 6;
            // 
            // dias_prestamo_cnfTextBox
            // 
            this.dias_prestamo_cnfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuracionBindingSource, "dias_prestamo_cnf", true));
            this.dias_prestamo_cnfTextBox.Location = new System.Drawing.Point(171, 107);
            this.dias_prestamo_cnfTextBox.Name = "dias_prestamo_cnfTextBox";
            this.dias_prestamo_cnfTextBox.Size = new System.Drawing.Size(49, 20);
            this.dias_prestamo_cnfTextBox.TabIndex = 8;
            // 
            // dias_penalizacion_cnfTextBox
            // 
            this.dias_penalizacion_cnfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuracionBindingSource, "dias_penalizacion_cnf", true));
            this.dias_penalizacion_cnfTextBox.Location = new System.Drawing.Point(171, 133);
            this.dias_penalizacion_cnfTextBox.Name = "dias_penalizacion_cnfTextBox";
            this.dias_penalizacion_cnfTextBox.Size = new System.Drawing.Size(49, 20);
            this.dias_penalizacion_cnfTextBox.TabIndex = 10;
            // 
            // gbConfiguración
            // 
            this.gbConfiguración.Controls.Add(this.bLookUpProv);
            this.gbConfiguración.Controls.Add(nombre_biblioteca_cnfLabel);
            this.gbConfiguración.Controls.Add(this.dias_penalizacion_cnfTextBox);
            this.gbConfiguración.Controls.Add(this.nombre_biblioteca_cnfTextBox);
            this.gbConfiguración.Controls.Add(this.tbNombre_Prov_Conf);
            this.gbConfiguración.Controls.Add(dias_penalizacion_cnfLabel);
            this.gbConfiguración.Controls.Add(direccion_cnfLabel);
            this.gbConfiguración.Controls.Add(this.dias_prestamo_cnfTextBox);
            this.gbConfiguración.Controls.Add(this.direccion_cnfTextBox);
            this.gbConfiguración.Controls.Add(dias_prestamo_cnfLabel);
            this.gbConfiguración.Controls.Add(provincia_cnfLabel);
            this.gbConfiguración.Controls.Add(this.tbID_Prov_conf);
            this.gbConfiguración.Location = new System.Drawing.Point(246, 229);
            this.gbConfiguración.Name = "gbConfiguración";
            this.gbConfiguración.Size = new System.Drawing.Size(513, 175);
            this.gbConfiguración.TabIndex = 11;
            this.gbConfiguración.TabStop = false;
            this.gbConfiguración.Text = "Configuración";
            // 
            // bLookUpProv
            // 
            this.bLookUpProv.Location = new System.Drawing.Point(450, 77);
            this.bLookUpProv.Name = "bLookUpProv";
            this.bLookUpProv.Size = new System.Drawing.Size(37, 20);
            this.bLookUpProv.TabIndex = 17;
            this.bLookUpProv.Text = "...";
            this.bLookUpProv.UseVisualStyleBackColor = true;
            this.bLookUpProv.Click += new System.EventHandler(this.bLookUpProv_Click);
            // 
            // tbNombre_Prov_Conf
            // 
            this.tbNombre_Prov_Conf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provinciasBindingSource, "provincia_pro", true));
            this.tbNombre_Prov_Conf.Location = new System.Drawing.Point(226, 77);
            this.tbNombre_Prov_Conf.Name = "tbNombre_Prov_Conf";
            this.tbNombre_Prov_Conf.ReadOnly = true;
            this.tbNombre_Prov_Conf.Size = new System.Drawing.Size(226, 20);
            this.tbNombre_Prov_Conf.TabIndex = 16;
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
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(447, 200);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(123, 23);
            this.bModificar.TabIndex = 12;
            this.bModificar.Text = "↓↓↓   Modificar   ↓↓↓";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(541, 410);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 13;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(391, 410);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 13;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Visible = false;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.provinciasTableAdapter = this.provinciasTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_ProvinciasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FM_Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.gbConfiguración);
            this.Name = "FM_Configuracion";
            this.Load += new System.EventHandler(this.FM_Configuracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Configuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionBindingSource)).EndInit();
            this.gbConfiguración.ResumeLayout(false);
            this.gbConfiguración.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_Configuracion dS_Configuracion;
        private System.Windows.Forms.BindingSource configuracionBindingSource;
        private DS_ConfiguracionTableAdapters.configuracionTableAdapter configuracionTableAdapter;
        private System.Windows.Forms.TextBox nombre_biblioteca_cnfTextBox;
        private System.Windows.Forms.TextBox direccion_cnfTextBox;
        private System.Windows.Forms.TextBox tbID_Prov_conf;
        private System.Windows.Forms.TextBox dias_prestamo_cnfTextBox;
        private System.Windows.Forms.TextBox dias_penalizacion_cnfTextBox;
        private System.Windows.Forms.GroupBox gbConfiguración;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private DS_Provincias dS_Provincias;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private DS_ProvinciasTableAdapters.provinciasTableAdapter provinciasTableAdapter;
        private System.Windows.Forms.TextBox tbNombre_Prov_Conf;
        private DS_ProvinciasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button bLookUpProv;
    }
}
