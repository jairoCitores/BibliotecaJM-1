using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Configuracion : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Configuracion()
        {
            InitializeComponent();
        }

        public FM_Configuracion(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
        }
        private void FM_Configuracion_Load(object sender, EventArgs e)
        {
            this.configuracionTableAdapter.Fill(this.dS_Configuracion.configuracion);
            this.provinciasTableAdapter.FillByIdProv(this.dS_Provincias.provincias, int.Parse(tbID_Prov_conf.Text));
            ModoMostrar();
        }

        public void ModoMostrar()
        {
            gbConfiguración.Enabled = false;
            bModificar.Visible = true;
            bAceptar.Visible = false;
            bCancelar.Visible = false;
        }
        public void ModoModificar()
        {
            gbConfiguración.Enabled = true;
            bModificar.Visible = false;
            bAceptar.Visible = true;
            bCancelar.Visible = true;
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            ModoModificar();
        }
        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.configuracionBindingSource.EndEdit();

                    this.configuracionTableAdapter.UpdatePropio(nombre_biblioteca_cnfTextBox.Text,
                                                                direccion_cnfTextBox.Text, int.Parse(tbID_Prov_conf.Text), int.Parse(dias_prestamo_cnfTextBox.Text),
                                                                int.Parse(dias_penalizacion_cnfTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la escritura de la base de datos." + ex.Message);
                }
                ModoMostrar();
            }
            else
            {

            }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.configuracionTableAdapter.Fill(this.dS_Configuracion.configuracion);
            this.provinciasTableAdapter.FillByIdProv(this.dS_Provincias.provincias, int.Parse(tbID_Prov_conf.Text));
            ModoMostrar();
        }
        private void bLookUpProv_Click(object sender, EventArgs e)
        {
            LookUpProvincias lookUpProv = new LookUpProvincias();
            lookUpProv.ShowDialog();
            tbID_Prov_conf.Text = lookUpProv.IdProv.ToString();
            tbNombre_Prov_Conf.Text = lookUpProv.NomProv;
        }
    }
}
