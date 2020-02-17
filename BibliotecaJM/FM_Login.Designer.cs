namespace BibliotecaJM
{
    partial class FM_Login
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
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bAcceder = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.dS_Usuarios = new BibliotecaJM.DS_Usuarios();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new BibliotecaJM.DS_UsuariosTableAdapters.usuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(84, 26);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(132, 20);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Text = "admin";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(84, 52);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '♪';
            this.tbPass.Size = new System.Drawing.Size(132, 20);
            this.tbPass.TabIndex = 1;
            this.tbPass.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // bAcceder
            // 
            this.bAcceder.Location = new System.Drawing.Point(26, 91);
            this.bAcceder.Name = "bAcceder";
            this.bAcceder.Size = new System.Drawing.Size(75, 23);
            this.bAcceder.TabIndex = 2;
            this.bAcceder.Text = "Acceder";
            this.bAcceder.UseVisualStyleBackColor = true;
            this.bAcceder.Click += new System.EventHandler(this.bAcceder_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(128, 92);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 3;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // dS_Usuarios
            // 
            this.dS_Usuarios.DataSetName = "DS_Usuarios";
            this.dS_Usuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.dS_Usuarios;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // FM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 148);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAcceder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUsuario);
            this.Name = "FM_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FM_Login";
            ((System.ComponentModel.ISupportInitialize)(this.dS_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAcceder;
        private System.Windows.Forms.Button bCancelar;
        private DS_Usuarios dS_Usuarios;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DS_UsuariosTableAdapters.usuariosTableAdapter usuariosTableAdapter;
    }
}