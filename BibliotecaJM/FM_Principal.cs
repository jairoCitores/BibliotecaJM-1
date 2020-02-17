using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Principal : Form
    {
        UsuarioActual usuarioActual = new UsuarioActual();
        public FM_Principal()
        {
            InitializeComponent();
        }

        private void FM_Principal_Load(object sender, EventArgs e)
        {
            FM_Login login = new FM_Login();
            login.ShowDialog();
            if(!login.correcto)
            {
                this.Close();
            }
            usuarioActual.Nombre = login.usuario;
            usuarioActual.TipoUsuario = login.tipo;
        }
        
        private void tsbLectores_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario == "A" || usuarioActual.TipoUsuario == "O")
            {
                VisualizarFormularioYTítulo(new FM_Lectores(), "Mantenimiento lectores");
            }
            else 
            {
                MessageBox.Show("Acceso denegado");
            }
        }
        private void tsbLibros_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario == "A" || usuarioActual.TipoUsuario == "O")
            {
                VisualizarFormularioYTítulo(new FM_Libros(), "Mantenimiento libros");
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }


        }
        private void tsbPréstamos_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario == "A" || usuarioActual.TipoUsuario == "O")
            {
                VisualizarFormularioYTítulo(new FM_Prestamos(), "Préstamos");
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
        }
        private void tsbDevoluciones_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario == "A" || usuarioActual.TipoUsuario == "O")
            {
                VisualizarFormularioYTítulo(new FM_Devoluciones(), "Devoluciones");
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
        }
        private void tsbListados_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario == "A" || usuarioActual.TipoUsuario == "O")
            {
                VisualizarFormularioYTítulo(new FM_Listados(usuarioActual), "Listados");
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
        }
        private void tsbGráficos_Click(object sender, EventArgs e)
        {
            VisualizarFormularioYTítulo(new FM_Graficos(usuarioActual), "Gráficos");
        }
        private void tsbConfiguración_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario == "A")
            {
                VisualizarFormularioYTítulo(new FM_Configuracion(), "Configuración");
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
        }
        private void VisualizarFormularioYTítulo(Form formulario, string título)
        {
            if (MdiChildren.Count() == 1)
                MdiChildren[0].Close();

            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
            this.Text = título;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripButton boton in toolStrip1.Items)
                boton.CheckState = CheckState.Unchecked;
        }
    }
}
