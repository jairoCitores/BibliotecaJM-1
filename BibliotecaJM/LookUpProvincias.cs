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
    public partial class LookUpProvincias : Form
    {
        public int IdProv { get; set; }
        public String NomProv { get; set; }

        public LookUpProvincias()
        {
            InitializeComponent();        
        }
        private void LookUpProvincias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Provincias.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.dS_Provincias.provincias);
        }

        private void provinciasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = provinciasBindingSource.Position;
            IdProv = dS_Provincias.provincias[posicion].id_pro;
            NomProv = dS_Provincias.provincias[posicion].provincia_pro;
            this.Close();
        }
    }
}
