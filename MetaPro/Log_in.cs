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
    public partial class Log_in : Form
    {

        private StreamWriter a;
        public Log_in()
        {
            InitializeComponent();
            dgvxd.Rows.Clear();
            txtContraseña.UseSystemPasswordChar = true;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;
            usuario=txtUsuario.Text;
            contraseña = txtContraseña.Text;

            LoginUsuario(usuario, contraseña);


             
        }
        //public void ConsultaProducto2(string Busqueda)
        //{
        //    //Conexion con el origen de datos
        //    DataClassesResumenDataContext dc = new DataClassesResumenDataContext();
        //    //Sentencia Linq
        //    var query = new List<SP_Buscar_ProductoResult>();
        //    query = dc.SP_Buscar_Producto(Busqueda).ToList();
        //    //Ejecutar sentencia
        //    dgvLista.DataSource = query;
        //}
        public void LoginUsuario(string usuario, string contraseña)
        {
            int control = 0;
            //Conexion con el origen de datos
            DataClassesResumenDataContext dc = new DataClassesResumenDataContext();
            //Sentencia Linq
           
                var query = new List<SP_LoginUsuarioResult>();
                query = dc.SP_LoginUsuario(usuario,contraseña).ToList();
                dgvxd.DataSource = query;
                
                
                
                
                if (dgvxd.Rows.Count == 0)
                {
                    // El DataGridView está vacío
                    control = 0;
                }
                else
                {
                    // El DataGridView no está vacío
                    control = 1;
                   
                        // Obtiene la celda en la fila 0 y columna 0
                        DataGridViewCell cell = dgvxd.Rows[0].Cells[0];
                        
                            a = new StreamWriter(@"IdUsuario.txt");
                            // Obtiene el valor de la celda
                            string value = cell.Value.ToString();   

                           
                                
                             a.WriteLine(value);
                                a.Close();

                            // Utiliza el valor obtenido
                            Console.WriteLine("Valor de la celda (0, 0): " + value);
                        
                
                }

               

            if (control==1)
            {
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("Usuario no registrado","Error al encontrar usuario",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
            //Ejecutar sentencia
            //dgvAmigos.DataSource = query;
        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void Log_in_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Definir los puntos de inicio y fin de la línea
            Point startPoint = new Point(310, 110);
            Point endPoint = new Point(510, 110);

            //// Dibujar la línea utilizando un objeto Pen
            //Pen pen = new Pen(Color.#82D9C8, 2);
            
            Pen pen = new Pen(Color.FromArgb(130, 217, 200), 4);


            g.DrawLine(pen, startPoint, endPoint);


            // Definir los puntos de inicio y fin de la línea
            Point startPoint2 = new Point(310, 170);
            Point endPoint2 = new Point(510, 170);

            //// Dibujar la línea utilizando un objeto Pen
            //Pen pen = new Pen(Color.#82D9C8, 2);

            Pen pen2 = new Pen(Color.FromArgb(130, 217, 200), 4);


            g.DrawLine(pen2, startPoint2, endPoint2);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = true;
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btnRegistrar.PerformClick();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btnIngresar.PerformClick();
        }
    }
}
