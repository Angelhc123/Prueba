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
    public partial class FrmPerfilAmigocs : Form
    {

        private StreamWriter a;
        string idobjetivo;
        bool comenta;
        public FrmPerfilAmigocs()
        {
            InitializeComponent();


            Obj2();
        }
        private ClsComentario comentarios = new ClsComentario();
        public void Obj2()
        {
            int id = GetId2();
            DataClassesResumenDataContext dc = new DataClassesResumenDataContext();
            var query = new List<SP_VerMisObjetivosResult>();
            query = dc.SP_VerMisObjetivos(id).ToList();
            dgvMisObj2.DataSource = query;
        }
        public int GetId2()
        {
            StreamReader fichero = new StreamReader(@"IdAmigoUsuario.txt", true);
            string linea;
            int Id;
            linea = fichero.ReadLine();
            Id = int.Parse(linea);
            fichero.Close();
            return Id;
        }
        public int GetIdUsuario()
        {
            StreamReader fichero = new StreamReader(@"IdUsuario.txt", true);
            string linea;
            int Id;
            linea = fichero.ReadLine();
            Id = int.Parse(linea);
            fichero.Close();
            return Id;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            gpbComentario.Visible = true;

        }

        private void btnGuardarComentario_Click(object sender, EventArgs e)
        {
            Comentario objComentario = new Comentario();
            DateTime fech = DateTime.Today;

            objComentario.Contenido = txtContenido.Text;
            objComentario.DiaPubli = fech;
            objComentario.IdUsuario = GetIdUsuario();
            objComentario.IdObjetivo = Convert.ToInt32(lblIdObjetivo.Text);
            gpbComentario.Visible = true;
            comentarios.Insertar(objComentario);
        }

        private void dgvMisObj2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gpbComentario.Enabled= true;
            DataGridViewRow filaSeleccionada = dgvMisObj2.Rows[e.RowIndex];
            DataGridViewCell primeraCelda = filaSeleccionada.Cells[6];
            string valorPrimeraCelda = primeraCelda.Value.ToString();

            lblIdObjetivo.Text = valorPrimeraCelda;

        }
    }
}
