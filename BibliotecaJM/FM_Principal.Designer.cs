namespace BibliotecaJM
{
    partial class FM_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FM_Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbLectores = new System.Windows.Forms.ToolStripButton();
            this.tsbLibros = new System.Windows.Forms.ToolStripButton();
            this.tsbPréstamos = new System.Windows.Forms.ToolStripButton();
            this.tsbDevoluciones = new System.Windows.Forms.ToolStripButton();
            this.tsbListados = new System.Windows.Forms.ToolStripButton();
            this.tsbGráficos = new System.Windows.Forms.ToolStripButton();
            this.tsbConfiguración = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLectores,
            this.tsbLibros,
            this.tsbPréstamos,
            this.tsbDevoluciones,
            this.tsbListados,
            this.tsbGráficos,
            this.tsbConfiguración});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 54);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbLectores
            // 
            this.tsbLectores.CheckOnClick = true;
            this.tsbLectores.Image = ((System.Drawing.Image)(resources.GetObject("tsbLectores.Image")));
            this.tsbLectores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLectores.Name = "tsbLectores";
            this.tsbLectores.Size = new System.Drawing.Size(55, 51);
            this.tsbLectores.Text = "Lectores";
            this.tsbLectores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLectores.Click += new System.EventHandler(this.tsbLectores_Click);
            // 
            // tsbLibros
            // 
            this.tsbLibros.CheckOnClick = true;
            this.tsbLibros.Image = ((System.Drawing.Image)(resources.GetObject("tsbLibros.Image")));
            this.tsbLibros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLibros.Name = "tsbLibros";
            this.tsbLibros.Size = new System.Drawing.Size(43, 51);
            this.tsbLibros.Text = "Libros";
            this.tsbLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLibros.Click += new System.EventHandler(this.tsbLibros_Click);
            // 
            // tsbPréstamos
            // 
            this.tsbPréstamos.CheckOnClick = true;
            this.tsbPréstamos.Image = ((System.Drawing.Image)(resources.GetObject("tsbPréstamos.Image")));
            this.tsbPréstamos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPréstamos.Name = "tsbPréstamos";
            this.tsbPréstamos.Size = new System.Drawing.Size(66, 51);
            this.tsbPréstamos.Text = "Préstamos";
            this.tsbPréstamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPréstamos.Click += new System.EventHandler(this.tsbPréstamos_Click);
            // 
            // tsbDevoluciones
            // 
            this.tsbDevoluciones.CheckOnClick = true;
            this.tsbDevoluciones.Image = ((System.Drawing.Image)(resources.GetObject("tsbDevoluciones.Image")));
            this.tsbDevoluciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDevoluciones.Name = "tsbDevoluciones";
            this.tsbDevoluciones.Size = new System.Drawing.Size(82, 51);
            this.tsbDevoluciones.Text = "Devoluciones";
            this.tsbDevoluciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDevoluciones.Click += new System.EventHandler(this.tsbDevoluciones_Click);
            // 
            // tsbListados
            // 
            this.tsbListados.CheckOnClick = true;
            this.tsbListados.Image = ((System.Drawing.Image)(resources.GetObject("tsbListados.Image")));
            this.tsbListados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbListados.Name = "tsbListados";
            this.tsbListados.Size = new System.Drawing.Size(54, 51);
            this.tsbListados.Text = "Listados";
            this.tsbListados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbListados.Click += new System.EventHandler(this.tsbListados_Click);
            // 
            // tsbGráficos
            // 
            this.tsbGráficos.CheckOnClick = true;
            this.tsbGráficos.Image = ((System.Drawing.Image)(resources.GetObject("tsbGráficos.Image")));
            this.tsbGráficos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGráficos.Name = "tsbGráficos";
            this.tsbGráficos.Size = new System.Drawing.Size(54, 51);
            this.tsbGráficos.Text = "Gráficos";
            this.tsbGráficos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGráficos.Click += new System.EventHandler(this.tsbGráficos_Click);
            // 
            // tsbConfiguración
            // 
            this.tsbConfiguración.CheckOnClick = true;
            this.tsbConfiguración.Image = ((System.Drawing.Image)(resources.GetObject("tsbConfiguración.Image")));
            this.tsbConfiguración.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfiguración.Name = "tsbConfiguración";
            this.tsbConfiguración.Size = new System.Drawing.Size(87, 51);
            this.tsbConfiguración.Text = "Configuración";
            this.tsbConfiguración.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbConfiguración.Click += new System.EventHandler(this.tsbConfiguración_Click);
            // 
            // FM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsMdiContainer = true;
            this.Name = "FM_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BibliotecaJM";
            this.Load += new System.EventHandler(this.FM_Principal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbLectores;
        private System.Windows.Forms.ToolStripButton tsbLibros;
        private System.Windows.Forms.ToolStripButton tsbPréstamos;
        private System.Windows.Forms.ToolStripButton tsbDevoluciones;
        private System.Windows.Forms.ToolStripButton tsbListados;
        private System.Windows.Forms.ToolStripButton tsbGráficos;
        private System.Windows.Forms.ToolStripButton tsbConfiguración;
    }
}

