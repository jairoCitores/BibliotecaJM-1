using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Lectores : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Lectores()
        {
            InitializeComponent();
        }

        public FM_Lectores(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
        }

        private void FM_Lectores_Load(object sender, EventArgs e)
        {            
            ModoBusqueda();
        }

        //Los modos que definen como se gestionan los datos visualizados
        private void ModoBusqueda()
        {
            gbBuscar.Enabled = true;
            gbDatosLector.Enabled = false;
            bAceptar.Visible = false;
            bCancelar.Visible = false;
        }
        private void ModoEdición()
        {
            gbBuscar.Enabled = false;
            gbDatosLector.Enabled = true;
            bAceptar.Visible = true;
            bCancelar.Visible = true;
            this.nombre_lecTextBox.Focus();
        }

        //Eventos de los botones
        private void bBuscarID_Click(object sender, EventArgs e)
        {
            int n = 0;
            this.lectoresTableAdapter.FillByID(this.dS_Lectores.lectores,
                int.TryParse(tbID.Text, out n) ? n : 0);
            if (n == 0)
            {
                MessageBox.Show("El ID introducido no es correcto");
            }
            else { 
                this.provinciasTableAdapter.FillByIdProv(dS_Provincias.provincias, int.Parse(tbID_ProvLec_lectores.Text));            
            }
        }
        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            this.lectoresTableAdapter.FillByNombre(this.dS_Lectores.lectores, tbNombre.Text);
            this.provinciasTableAdapter.FillByIdProv(dS_Provincias.provincias, int.Parse(tbID_ProvLec_lectores.Text));
        }
        private void bNuevoLec_Click(object sender, EventArgs e)
        {
            this.lectoresBindingSource.AddNew();
            fecha_penalizacion_lecDateTimePicker.Hide();
            ModoEdición();
        }
        private void bModificarLec_Click(object sender, EventArgs e)
        {
            fecha_penalizacion_lecDateTimePicker.Show();
            ModoEdición();
        }
        private void bEliminarLec_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?",
                "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    lectoresBindingSource.RemoveCurrent();
                    this.lectoresTableAdapter.Update(dS_Lectores.lectores);
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
                    lectoresBindingSource.EndEdit();
                    this.lectoresTableAdapter.Update(this.dS_Lectores.lectores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la escritura de la base de datos." + ex.Message);
                }
                fecha_penalizacion_lecDateTimePicker.Show();
                ModoBusqueda();
            }
            else
            {

            }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            lectoresBindingSource.CancelEdit();
            fecha_penalizacion_lecDateTimePicker.Show();
            ModoBusqueda();
        }
        private void bLookUpProvincia_Click(object sender, EventArgs e)
        {
            LookUpProvincias lc = new LookUpProvincias();
            lc.ShowDialog();
            tbID_ProvLec_lectores.Text = lc.IdProv.ToString();           
        }              

        private void tbID_ProvLec_lectores_TextChanged(object sender, EventArgs e)
        {
            this.provinciasTableAdapter.FillByIdProv(dS_Provincias.provincias, int.Parse(tbID_ProvLec_lectores.Text));
        }
    }
}
