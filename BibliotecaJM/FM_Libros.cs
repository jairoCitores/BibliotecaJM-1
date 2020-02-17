using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Libros : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Libros()
        {
            InitializeComponent();
        }

        public FM_Libros(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
        }        

        private void FM_Libros_Load(object sender, EventArgs e)
        {
            ModoBusqueda();
        }
        private void ModoBusqueda()
        {
            gbBuscarLib.Enabled = true;
            gbDatosLib.Enabled = false;
            bAceptar_lib.Visible = false;
            bCancelar_lib.Visible = false;
        }
        private void ModoEdición()
        {
            gbBuscarLib.Enabled = false;
            gbDatosLib.Enabled = true;
            id_libTextBox.Enabled = false;
            bAceptar_lib.Visible = true;
            bCancelar_lib.Visible = true;
            this.titulo_libTextBox.Focus();
        }

        private void colorearPrestados() {
            int contador = 0;
            foreach (var item in this.dS_Libros.libros)
            {
                if (!item.prestado_sn_lib.Trim().Equals("S"))
                {
                    librosDataGridView.Rows[contador].Cells[2].Style.BackColor = Color.LightGreen;
                }
                else {
                    librosDataGridView.Rows[contador].Cells[2].Style.BackColor = Color.Pink;
                }
                contador++; 
            }
        }

        //Eventos de los botones
        private void bBuscarID_Lib_Click(object sender, EventArgs e)
        {
            int n = 0;
            this.librosTableAdapter.FillByID(this.dS_Libros.libros,
                int.TryParse(tbID_Lib.Text, out n) ? n : 0);
            if (n == 0)
            {
                MessageBox.Show("El ID introducido no es correcto");
            }
        }
        private void bBuscarTitulo_Lib_Click(object sender, EventArgs e)
        {
            this.librosTableAdapter.FillByTitulo(this.dS_Libros.libros, tbNombre_Lib.Text);
            colorearPrestados();
        }
        private void bNuevoLib_Click(object sender, EventArgs e)
        {
            this.librosBindingSource.AddNew();
            ModoEdición();
        }
        private void bModificarLib_Click(object sender, EventArgs e)
        {            
            ModoEdición();
        }
        private void bEliminarLib_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el libro seleccionado?",
                "Eliminar del registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    librosBindingSource.RemoveCurrent();
                    this.librosTableAdapter.Update(this.dS_Libros.libros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar el registro:\nCodigo de error: " + ex.Message);
                }
        }
        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    librosBindingSource.EndEdit();
                    this.librosTableAdapter.Update(this.dS_Libros.libros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la escritura de la base de datos.\n Error: " + ex.Message);
                }                
                ModoBusqueda();
            }
            else
            {

            }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            librosBindingSource.CancelEdit();
            ModoBusqueda();
        }
        private void bLookUpSeccion_Click(object sender, EventArgs e)
        {
            LookUpSecciones ls = new LookUpSecciones();
            ls.ShowDialog();
            seccion_libTextBox.Text = ls.idSeccion.ToString();
            tbNomSeccion.Text = ls.nomSec;
        }

        private void librosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            colorearPrestados();
        }
    }
}
