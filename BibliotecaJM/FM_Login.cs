using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BibliotecaJM
{
    public partial class FM_Login : Form
    {
        
        public String usuario { get; set; }
        public String clave { get; set; }
        public String tipo { get; set; }
        public Boolean correcto { get; set; }

        int nIntentos = 0;

        public FM_Login()
        {   
            InitializeComponent();
        }        

        private void bCancelar_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void bAcceder_Click(object sender, EventArgs e)
        {               
            if (nIntentos == 3)
            {
                MessageBox.Show("Número de intentos erróneos superados.");
                this.Close();
            }
            else if (tbUsuario.Text == "" || tbPass.Text == "")
            {
                nIntentos++;
                MessageBox.Show("Por favor, rellene todos los campos");
            }
            else
            {
                usuario = tbUsuario.Text;
                clave = tbPass.Text;
                this.usuariosTableAdapter.FillByUsuPass(this.dS_Usuarios.usuarios, usuario, clave);
                if (dS_Usuarios.usuarios.Rows.Count==1)
                {
                    tipo = dS_Usuarios.usuarios[0].tipo_usu;
                    correcto = true;
                    this.Close();
                }
                else {
                    nIntentos++;
                    MessageBox.Show("DATOS INCORRECTOS");
                }
            }
        }
    }
}
