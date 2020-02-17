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
    public partial class LookUpSecciones : Form
    {
        public int idSeccion { get; set; }
        public String nomSec { get; set; }

        public LookUpSecciones()
        {
            InitializeComponent();
        }


        private void LookUpSecciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Secciones.secciones' Puede moverla o quitarla según sea necesario.
            this.seccionesTableAdapter.Fill(this.dS_Secciones.secciones);

        }

        private void seccionesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = seccionesBindingSource.Position;
            idSeccion = dS_Secciones.secciones[posicion].id_sec;
            nomSec = dS_Secciones.secciones[posicion].seccion_sec;
            this.Close();
        }
    }
}
