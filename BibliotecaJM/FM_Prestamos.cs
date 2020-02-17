using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace BibliotecaJM
{
    public partial class FM_Prestamos : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        DS_Configuracion dS_Configuracion = new DS_Configuracion();
        DS_ConfiguracionTableAdapters.configuracionTableAdapter configuracionTableAdapter = new DS_ConfiguracionTableAdapters.configuracionTableAdapter();       

        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;
        public FM_Prestamos()
        {               
            InitializeComponent();
        }

        public FM_Prestamos(UsuarioActual usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }        

        private void FM_Prestamos_Load(object sender, EventArgs e)
        {            
            this.configuracionTableAdapter.Fill(dS_Configuracion.configuracion);
        }

        private void colorearPrestados()
        {
            int contador = 0;
            foreach (var item in this.dS_Libros.libros)
            {
                if (!item.prestado_sn_lib.Trim().Equals("S"))
                {
                    librosDataGridView.Rows[contador].Cells[4].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    librosDataGridView.Rows[contador].Cells[4].Style.BackColor = Color.Pink;
                }
                contador++;
            }

            //MessageBox.Show("Test");

        }

        private void bBuscarPorID_Click(object sender, EventArgs e)
        {
            int n = 0;
            this.lectoresTableAdapter.FillByID(this.dS_Lectores.lectores,
                int.TryParse(tbID.Text, out n) ? n : 0);
            this.prestamosTableAdapter.FillByIdLec(this.dS_Prestamos.prestamos, int.TryParse(tbID.Text, out n) ? n : 0);
            colorearPrestados();
            if (n == 0)
            {
                MessageBox.Show("El ID introducido no es correcto");
            }
        }        
        private void bBuscarPorIDLib_Click(object sender, EventArgs e)
        {
            int idLib;
            this.librosTableAdapter.FillByID(this.dS_Libros.libros, int.TryParse(tbIDLib.Text, out idLib) ? idLib : 0);
            colorearPrestados();
            if (idLib == 0)
            {
                MessageBox.Show("El ID de libro introducido no es correcto");
            }
        }
        private void bBuscarPorTituloLib_Click(object sender, EventArgs e)
        {
            this.librosTableAdapter.FillByTitulo(this.dS_Libros.libros, tbTituloLib.Text);
            colorearPrestados();
        }
        private void BuscarPorAutorLib_Click(object sender, EventArgs e)
        {
            this.librosTableAdapter.FillByAutor(this.dS_Libros.libros, tbAutorLib.Text);
            colorearPrestados();
        }
        private void bRealizarPrestamo_Click(object sender, EventArgs e)
        {            
            try
            {
                int idlec = dS_Lectores.lectores[0].id_lec;
                
                if (fecha_penalizacion_lecLabel1.Text == "" || dS_Lectores.lectores[0].fecha_penalizacion_lec < DateTime.Now)
                {
                    try
                    {
                        int idLib = dS_Libros.libros[this.librosBindingSource.Position].id_lib;
                        if (dS_Libros.libros[librosBindingSource.Position].prestado_sn_lib.Trim().Equals("S"))
                        {
                            MessageBox.Show("El libro elegido no está disponible!", "Error");
                        }
                        else
                        {
                            if (MessageBox.Show("Prestar el libro: " + dS_Libros.libros[librosBindingSource.Position].titulo_lib +
                            "\nal lector: " + dS_Lectores.lectores[0].nombre_lec, "Confirmar prestamo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                //tituloLib = dS_Libros.libros[librosBindingSource.Position].titulo_lib;
                                fechaPrestamo = DateTime.Now;
                                fechaDevolucion = fechaPrestamo.AddDays(double.Parse(this.dS_Configuracion.configuracion[0].dias_prestamo_cnf.ToString()));

                                //MessageBox.Show(fechaDevolucion.ToString("dd/MM/yyyy HH:mm"));
                                //MessageBox.Show(this.dS_Configuracion.configuracion[0].dias_prestamo_cnf.ToString());
                                DataRow nuevoPrestamo = this.dS_Prestamos.prestamos.NewRow();
                                nuevoPrestamo["id_lec_pre"] = idlec;
                                nuevoPrestamo["id_lib_pre"] = idLib;
                                nuevoPrestamo["fecha_presta_pre"] = fechaPrestamo;
                                nuevoPrestamo["fecha_devol_pre"] = fechaDevolucion;
                                this.dS_Prestamos.prestamos.Rows.Add(nuevoPrestamo);

                                this.prestamosTableAdapter.Update(this.dS_Prestamos.prestamos);
                                this.prestamosTableAdapter.FillByIdLec(this.dS_Prestamos.prestamos, int.Parse(tbID.Text));

                                dS_Libros.libros[librosBindingSource.Position].prestado_sn_lib = "S";
                                librosTableAdapter.Update(this.dS_Libros.libros);

                                dS_Lectores.lectores[lectoresBindingSource.Position].Setfecha_penalizacion_lecNull();
                                lectoresTableAdapter.Update(this.dS_Lectores.lectores);
                                colorearPrestados();
                                MessageBox.Show("PRESTADO");
                            }
                        }
                    }
                    catch (Exception errr)
                    {
                        MessageBox.Show("Elige el libro a prestar");
                    }
                }
                else {
                    MessageBox.Show("El lector está penalizado");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Elige un lector primero");

            }
        }
    }
}
