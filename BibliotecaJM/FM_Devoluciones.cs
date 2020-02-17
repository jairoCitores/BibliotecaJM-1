using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Devoluciones : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Devoluciones()
        {
            InitializeComponent();
        }
        public FM_Devoluciones(UsuarioActual usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void FM_Devoluciones_Load(object sender, EventArgs e)
        {            
            // TODO: esta línea de código carga datos en la tabla 'dS_Lectores.lectores' Puede moverla o quitarla según sea necesario.
            this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);
            this.prestamosTableAdapter.FillByTodo(this.dS_Prestamos.prestamos);
        }
        private void bBuscarPorID_lec_Click(object sender, EventArgs e)
        {
            int n = 0;
            this.lectoresTableAdapter.FillByID(this.dS_Lectores.lectores,
                int.TryParse(tbIDLec.Text, out n) ? n : 0);
            this.prestamosTableAdapter.FillByIdLec(this.dS_Prestamos.prestamos, int.TryParse(tbIDLec.Text, out n) ? n : 0);
            if (n == 0)
            {
                MessageBox.Show("El ID introducido no es correcto");
            }
        }


        private void bBuscarPorID_lib_Click(object sender, EventArgs e)
        {
            int n = 0;   
            this.librosTableAdapter.FillByID(this.dS_Libros.libros,
                int.TryParse(tbIDLec.Text, out n) ? n : 0);
            this.prestamosTableAdapter.FillByIdLib(this.dS_Prestamos.prestamos, int.TryParse(tbIdLib.Text, out n) ? n : 0);
            if (n == 0)
            {
                MessageBox.Show("El ID introducido no es correcto");
            }
        }

        private void bVisualizarTodos_Click(object sender, EventArgs e)
        {
            this.prestamosTableAdapter.FillByTodo(this.dS_Prestamos.prestamos);
        }

        private void prestamosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataRow devoLib = this.dS_Prestamos.prestamos[e.RowIndex];

            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("¿Desea devolver el libro " + dS_Prestamos.prestamos[prestamosBindingSource.Position].titulo_lib.Trim() + " ?", "Confirmar devolución",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    devoLib.Delete();                    
                    this.prestamosTableAdapter.Update(this.dS_Prestamos.prestamos);
                    
                }
            }

        }
    }
}
