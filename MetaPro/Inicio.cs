using MetaPro.Clases;
using MetaPro.DataClases;
using MetaPro.Modelo;
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

namespace MetaPro
{
    public partial class Inicio : Form
    {
        DCTablasDataContext dct = new DCTablasDataContext();
        DataClassesResumenDataContext dcr = new DataClassesResumenDataContext();
        private ClsAmigo amigos = new ClsAmigo();
        public int idActual = 1;
        private StreamWriter a;


        public Inicio()
        {
            InitializeComponent();
            ListaAmigos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAñadirA_Click(object sender, EventArgs e)
        {
            EncontrarAmigo(txtNick.Text);


        }
        public void EncontrarAmigo(string Nick)
        {
            //Conexion con el origen de datos
            DataClassesResumenDataContext dc = new DataClassesResumenDataContext();
            //Sentencia Linq
            var query = new List<SP_Añadir_AmigoResult>();
            query = dc.SP_Añadir_Amigo(Nick).ToList();
            dgvAgregar.DataSource = query;

            var query2 = new List<SP_Agregar_AmigoResult>();
            query2 = dc.SP_Agregar_Amigo(Nick).ToList();
            dgvAgregacion.DataSource = query2;
        }
        
        private void Inicio_Load(object sender, EventArgs e)
        {
   

        }

        private void ListaAmigos()
        {

            StreamReader fichero = new StreamReader(@"IdUsuario.txt", true);
            string linea;
            int Id;
            linea = fichero.ReadLine();
            Id = int.Parse(linea);
            DataClassesResumenDataContext dc = new DataClassesResumenDataContext();
            //Sentencia Linq

            var query = new List<SP_VerListaAmigosResult>();
            query = dc.SP_VerListaAmigos(Id).ToList();
            dgvAmigos.DataSource = query;
            fichero.Close();
            dgvAmigos.Columns[0].Visible= false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvAgregar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int control=0;
            Amigo objAmigo = new Amigo();
            DialogResult resultado = MessageBox.Show("¿Desea agregar a esta persona a su lista de amigos?", "Agregar Amigo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes) 
            {
                DataGridViewCell primeraCelda1 = dgvAgregar.Rows[0].Cells[0];
                string valorPrimeraCelda1 = primeraCelda1.Value.ToString();

                //DataGridViewCell primeraCelda2 = dgvAmigos.Rows[0].Cells[0];
                //string valorPrimeraCelda2 = primeraCelda2.Value.ToString();

                int rowCount = dgvAmigos.RowCount;
                for(int i = 0;i<rowCount; i++)
                {
                    DataGridViewCell primeraCelda2 = dgvAmigos.Rows[i].Cells[0];
                    string valorPrimeraCelda2 = primeraCelda2.Value.ToString();
                    if (valorPrimeraCelda1 == valorPrimeraCelda2)
                    {
                        control = 1; break;
                    }

                }

                if (control==1)
                {
                    MessageBox.Show("La persona que está intentado agregar ya se encuentra en su lista de amigos", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
              
                }
                else
                {
                    StreamReader fichero = new StreamReader(@"IdUsuario.txt", true);
                    string linea;
                    int paenviar;
                    linea = fichero.ReadLine();
                    paenviar = int.Parse(linea);


                    // Obtiene la celda en la fila 0 y columna 0
                    DataGridViewCell cell = dgvAgregacion.Rows[0].Cells[0];
                    string value = cell.Value.ToString();

                    objAmigo.IdUsuario = paenviar;
                    objAmigo.IdAmigoUsuario = Convert.ToInt32(value);
                    amigos.Insertar(objAmigo);
                    ListaAmigos();
                    fichero.Close();
                }

            }
        }

        private void btnObjetivo_Click(object sender, EventArgs e)
        {
            FrmObjetivos objetivos = new FrmObjetivos();
            objetivos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log_in login = new Log_in();
            login.Show();
            this.Hide();
        }

        private void dgvAgregar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAmigos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtiene la celda en la fila 0 y columna 0

            DataGridViewRow filaSeleccionada = dgvAmigos.Rows[e.RowIndex];
            DataGridViewCell primeraCelda = filaSeleccionada.Cells[0];
            string valorPrimeraCelda = primeraCelda.Value.ToString();

            a = new StreamWriter(@"IdAmigoUsuario.txt");
            // Obtiene el valor de la celda
            string value = valorPrimeraCelda;



            a.WriteLine(value);
            a.Close();

            FrmPerfilAmigocs amigo = new FrmPerfilAmigocs();
            amigo.Show();
            this.Hide();
        }
    }
}
