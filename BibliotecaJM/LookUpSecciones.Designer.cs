namespace BibliotecaJM
{
    partial class LookUpSecciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dS_Secciones = new BibliotecaJM.DS_Secciones();
            this.seccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seccionesTableAdapter = new BibliotecaJM.DS_SeccionesTableAdapters.seccionesTableAdapter();
            this.seccionesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Secciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dS_Secciones
            // 
            this.dS_Secciones.DataSetName = "DS_Secciones";
            this.dS_Secciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seccionesBindingSource
            // 
            this.seccionesBindingSource.DataMember = "secciones";
            this.seccionesBindingSource.DataSource = this.dS_Secciones;
            // 
            // seccionesTableAdapter
            // 
            this.seccionesTableAdapter.ClearBeforeFill = true;
            // 
            // seccionesDataGridView
            // 
            this.seccionesDataGridView.AutoGenerateColumns = false;
            this.seccionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seccionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.seccionesDataGridView.DataSource = this.seccionesBindingSource;
            this.seccionesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seccionesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.seccionesDataGridView.Name = "seccionesDataGridView";
            this.seccionesDataGridView.Size = new System.Drawing.Size(371, 584);
            this.seccionesDataGridView.TabIndex = 1;
            this.seccionesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seccionesDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_sec";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "seccion_sec";
            this.dataGridViewTextBoxColumn2.HeaderText = "SECCIÓN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // LookUpSecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 584);
            this.Controls.Add(this.seccionesDataGridView);
            this.Name = "LookUpSecciones";
            this.Text = "LookUpSecciones";
            this.Load += new System.EventHandler(this.LookUpSecciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Secciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_Secciones dS_Secciones;
        private System.Windows.Forms.BindingSource seccionesBindingSource;
        private DS_SeccionesTableAdapters.seccionesTableAdapter seccionesTableAdapter;
        private System.Windows.Forms.DataGridView seccionesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}