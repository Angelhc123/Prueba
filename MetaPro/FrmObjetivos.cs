using MetaPro.Clases;
using MetaPro.DataClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MetaPro
{
    public partial class FrmObjetivos : Form
    {

        private StreamWriter a;
        public FrmObjetivos()
        {
            InitializeComponent();
            Cmbopciones();
            btnModObj.Visible= false;
            btnEliminarObjt.Visible= false;
            dgvMisObj.Visible = false;
            Modi = false;

            txtDescrip.Text=string.Empty;
        }
        private ClsObjetivo objetivos = new ClsObjetivo();
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void FrmObjetivos_Load(object sender, EventArgs e)
        {

        }
        bool Modi=false;
        bool Eli = false;
        public void Cmbopciones()
        {
            cmbDificultad.Items.Clear();
            cmbDificultad.Items.Add("Corto");
            cmbDificultad.Items.Add("Mediano");
            cmbDificultad.Items.Add("Largo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblEstadoMod.Visible = false;
            Modi = false;
            Eli = false;
            lbl.Text = "¡Añade tu nuevo objetivo! :D";
            dgvMisObj.Visible = false;
            btnModObj.Visible = false;
            btnEliminarObjt.Visible = false;
            gpbAñadirOb.Visible = true;
            dgvMisObj.Visible = false;
            txtAvance.Text = "0";
            txtAvance.Enabled = false;
            btnGuardarC.Visible = false;
            btnCancelarMod.Visible = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Objetivo objObjetivo = new Objetivo();
            DateTime fech= DateTime.Today;
            int difcat = 0;

            if (cmbDificultad.Text == "Corto")
            {
                difcat = 1;
            }
            else if (cmbDificultad.Text == "Mediano")
            {
                difcat = 2;
            }
            else if (cmbDificultad.Text == "Largo")
            {
                difcat = 3;
            }

            objObjetivo.IdCategoria = difcat;
            objObjetivo.Titulo = txtTitulo.Text;
            objObjetivo.Descripcion = txtDescripcion.Text;
            objObjetivo.Avance = 0;
            objObjetivo.FechaC = fech;
            objObjetivo.Tiempo= 0;
            txtAvance.Enabled= true;
            btnCancelarMod.Visible = true;

            objObjetivo.IdUsuario= GetId();
            objetivos.Insertar(objObjetivo);
            MessageBox.Show("Su objetivo se ha agregado satisfactoriamente :D", "Objetivo agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();


        }

        private void limpiar()
        {
            txtTitulo.Text = "";
            txtDescripcion.Text = "";
            cmbDificultad.Text = "";
        }
        public int GetId()
        {
            StreamReader fichero = new StreamReader(@"IdUsuario.txt", true);
            string linea;
            int Id;
            linea = fichero.ReadLine();
            Id = int.Parse(linea);
            fichero.Close();
            return Id;
        }

        private void btnMisObj_Click(object sender, EventArgs e)
        {
            lblEstadoMod.Visible = false;
            Modi = false;
            Eli = false;
            gpbAñadirOb.Visible = false;
            btnModObj.Visible = true;
            btnEliminarObjt.Visible = true;
            dgvMisObj.Visible = true;
            btnGuardarC.Visible = false;
            btnCancelarMod.Visible = false;

            int id=GetId();
            DataClassesResumenDataContext dc = new DataClassesResumenDataContext();
            var query = new List<SP_VerMisObjetivosResult>();
            query = dc.SP_VerMisObjetivos(id).ToList();
            dgvMisObj.DataSource = query;

            // Supongamos que queremos ajustar el ancho de la segunda columna del DataGridView

            //dgvMisObj.Columns[1].Width = 0;
            dgvMisObj.Columns[2].Width = 50;
            dgvMisObj.Columns[3].Width = 65;
            dgvMisObj.Columns[4].Width = 50;
            dgvMisObj.Columns[5].Width = 60;

            dgvMisObj.Columns[1].Visible = false;
        }

        private void btnModObj_Click(object sender, EventArgs e)
        {
            lbl.Text = "¡Modifica tu objetivo! :D";
            dgvMisObj.Visible=true;
            gpbAñadirOb.Visible=false;
            btnGuardarC.Visible=false;
            btnCancelarMod.Visible=true;
            Modi = true;
            Eli = false;
            lblEstadoMod.Text = "Seleccione el objetivo a modificar";
            lblEstadoMod.Visible = true;
            lblEstadoMod.ForeColor = Color.SkyBlue;
        }

        private void dgvMisObj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Modi == true)
            {
                cmbDificultad.Enabled = false;
                Eli = false;
                dgvMisObj.Visible = true;
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow filaSeleccionada = dgvMisObj.Rows[e.RowIndex];
                    DataGridViewCell primeraCelda = filaSeleccionada.Cells[0];
                    string valorPrimeraCelda = primeraCelda.Value.ToString();

                    DataGridViewRow filaSeleccionada2 = dgvMisObj.Rows[e.RowIndex];
                    DataGridViewCell primeraCelda2 = filaSeleccionada2.Cells[1];
                    string valorPrimeraCelda2 = primeraCelda2.Value.ToString();

                    DataGridViewRow filaSeleccionada3 = dgvMisObj.Rows[e.RowIndex];
                    DataGridViewCell primeraCelda3 = filaSeleccionada3.Cells[4];
                    string valorPrimeraCelda3 = primeraCelda3.Value.ToString();

                    DataGridViewRow filaSeleccionada4 = dgvMisObj.Rows[e.RowIndex];
                    DataGridViewCell primeraCelda4 = filaSeleccionada4.Cells[5];
                    string valorPrimeraCelda4 = primeraCelda4.Value.ToString();


                    a = new StreamWriter(@"IdObjetivo.txt");
                    // Obtiene el valor de la celda
                    DataGridViewRow filaSeleccionada5 = dgvMisObj.Rows[e.RowIndex];
                    DataGridViewCell primeraCelda5 = filaSeleccionada5.Cells[6];
                    string valorPrimeraCelda5 = primeraCelda5.Value.ToString();



                    a.WriteLine(valorPrimeraCelda5);
                    a.Close();



                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow columdescrip2 = dgvMisObj.Rows[e.RowIndex];
                    DataGridViewCell primeraCelda6 = columdescrip2.Cells[6];
                    int valorPrimeraCelda6 = Convert.ToInt32(primeraCelda6.Value);

                    // Grafico de barras
                    chartAvance.Visible = false;


                    DataClassesResumenDataContext dc = new DataClassesResumenDataContext();

                    //linq
                    var query = new List<SP_VerMiProgresoResult>();

                    query = dc.SP_VerMiProgreso(valorPrimeraCelda6).ToList();
                    chartAvance.Series["Progreso"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                    query.ForEach(usuario =>
                    {
                        //chartAvance.Series["Progreso"].Points.Clear();
                        chartAvance.Series["Progreso"].Points.AddXY(usuario.DiaProgreso, usuario.Avance);
                    });

                    Objetivo objObjetivo = new Objetivo();
                    DateTime fech = DateTime.Today;
                    
                    DataPoint ultimoPunto = chartAvance.Series["Progreso"].Points.Last();
                    
                    DateTime fechaUltimoDato = DateTime.FromOADate(ultimoPunto.XValue).Date;

                    TimeSpan diferencia = fech - fechaUltimoDato;

                    int diferenciaEnDias = diferencia.Days;
                    txtPrueba.Text = Convert.ToString(diferenciaEnDias);

                    if (diferenciaEnDias == 0)
                    {
                        txtAvance.Enabled = false;
                    }
                    else { txtAvance.Enabled = true; }







                    // Asignar el valor al texto del Label
                    txtTitulo.Text = valorPrimeraCelda;
                    txtAvance.Text = valorPrimeraCelda3;
                    cmbDificultad.Text= valorPrimeraCelda4;
                    txtDescripcion.Text= valorPrimeraCelda2;
                    dgvMisObj.Visible = false;
                    gpbAñadirOb.Visible = true;
                    btnGuardarC.Visible = true;
                    btnCancelarMod.Visible = true;
                    //txtAvance.Enabled = true;
                    txtTitulo.Enabled = false;
                    lblEstadoMod.Visible = false;
                    btnAgregar.Visible = false;
                }
            }
            else if (Eli==true)
            {
                DataGridViewRow filaSeleccionada = dgvMisObj.Rows[e.RowIndex];
                DataGridViewCell primeraCelda = filaSeleccionada.Cells[0];
                string valorPrimeraCelda = primeraCelda.Value.ToString();
                DialogResult resultado = MessageBox.Show("¿Está seguro de querer eleminar este objetivo? D:", " Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Eli = false;
                lblEstadoMod.Visible = false;
                if (resultado==DialogResult.Yes)
                {
                    objetivos.Eliminar(valorPrimeraCelda);
                    btnMisObj_Click(sender, e);

                }

            }

            if(Eli==false && Modi==false)
            {
                // Obtener el valor de la primera celda de la fila seleccionada
                DataGridViewRow columdescrip = dgvMisObj.Rows[e.RowIndex];
                DataGridViewCell primeraCelda = columdescrip.Cells[1];
                
                string valorPrimeraCelda = primeraCelda.Value.ToString();

                // Asignar el valor al texto del Label
                txtDescrip.Text = valorPrimeraCelda;


                chartAvance.Visible = true;

                
            }

        }
        

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            Objetivo objObjetivo = new Objetivo();
            Progreso ObjProgreso = new Progreso();
            int difcat = 0;



            if (cmbDificultad.Text == "Corto")
            {
                difcat = 1;
            }
            else if (cmbDificultad.Text == "Mediano")
            {
                difcat = 2;
            }
            else if (cmbDificultad.Text == "Largo")
            {
                difcat = 3;
            }


            txtTitulo.Enabled = true;
            objObjetivo.IdCategoria = difcat;
            objObjetivo.Titulo = txtTitulo.Text;
            objObjetivo.Descripcion = txtDescripcion.Text;
            objObjetivo.Avance=Convert.ToInt32(txtAvance.Text);
            objetivos.Modificar(objObjetivo);
            Modi = false;
            MessageBox.Show("Su objetivo se ha modificado satisfactoriamente :D", "Objetivo modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();

            StreamReader fichero = new StreamReader(@"IdObjetivo.txt", true);
            string linea;
            int Id;
            linea = fichero.ReadLine();
            Id = int.Parse(linea);
            DataClassesResumenDataContext dc = new DataClassesResumenDataContext();
            fichero.Close();





            ClsProgreso progreso= new ClsProgreso(); 
            Progreso objProgreso = new Progreso();
            DateTime fech = DateTime.Today;

            int idobj = objObjetivo.IdObjetivo;

            objProgreso.Avance= Convert.ToInt32(txtAvance.Text);
            objProgreso.DiaProgreso = fech;
            objProgreso.IdObjetivo = Id;
            progreso.Insertar(objProgreso);

        }

        private void btnEliminarObjt_Click(object sender, EventArgs e)
        {
            Eli = true;
            Modi = false;
            lblEstadoMod.Text = "Seleccione el objetivo a eliminar";
            lblEstadoMod.Visible = true;
            lblEstadoMod.ForeColor= Color.Red;
            gpbAñadirOb.Visible = false;
            dgvMisObj.Visible = true;

        }

        private void btnCancelarMod_Click(object sender, EventArgs e)
        {
            limpiar();
            gpbAñadirOb.Visible = false;
            dgvMisObj.Visible = true;
            Modi= false;
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            limpiar();
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void dgvMisObj_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //// Verificar si es la primera columna (índice de columna 0)
            //if (e.ColumnIndex == 1)
            //{
            //    // Obtener la celda actual
            //    DataGridViewCell cell = dgvMisObj.Rows[e.RowIndex].Cells[e.ColumnIndex];

            //    // Modificar el estilo de la celda
            //    cell.Style.BackColor = Color.Red; // Establecer el color de fondo deseado
            //    cell.Style.ForeColor = Color.White; // Establecer el color de texto deseado

            //    dgvMisObj.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.Red; // Establecer el color de fondo deseado
            //    dgvMisObj.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.White; // Establecer el color de texto deseado
            //}
        }
    }
}
