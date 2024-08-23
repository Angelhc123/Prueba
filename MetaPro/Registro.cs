using MetaPro.Clases;
using MetaPro.Modelo;
using MetaPro.DataClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MetaPro
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        private ClsUsuario usuarios = new ClsUsuario();
        private ClsCriaturita Criaturitas = new ClsCriaturita();
        //private void btnRegistrar_Click(object sender, EventArgs e)
        //{
        //    //// Verificar si el TextBox está vacío
        //    //if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNick.Text) || string.IsNullOrEmpty(txtContrasena.Text) || string.IsNullOrEmpty(txtCoContrasena.Text)&& string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtCelular.Text) || string.IsNullOrEmpty(txtPais.Text) || string.IsNullOrEmpty(txtCiudad.Text) || cmbSexo.Text=="")
        //    //{

        //    //    MessageBox.Show("Complete toda su información", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //}
        //    //else
        //    //{
        //    //    Usuario objUsuario = new Usuario();
        //    //    Criaturita objCriaturita = new Criaturita();

        //    //    objCriaturita.Nombre = txtNombre.Text;
        //    //    objCriaturita.Email = txtEmail.Text;
        //    //    objCriaturita.Celular = txtCelular.Text;
        //    //    objCriaturita.Pais = txtPais.Text;
        //    //    objCriaturita.Ciudad = txtCiudad.Text;
        //    //    objCriaturita.Sexo = cmbSexo.Text;


        //    //    objUsuario.Nickname = txtNick.Text;
        //    //    objUsuario.Contraseña = txtContrasena.Text;
        //    //    objUsuario.IdEstado = 2;

        //    //    if (txtContrasena.Text == txtCoContrasena.Text)
        //    //    {
        //    //        Criaturitas.Insertar(objCriaturita);
        //    //        int a = objCriaturita.IdCriaturita;
        //    //        objUsuario.IdCriaturita = a;
        //    //        usuarios.Insertar(objUsuario);
        //    //        MessageBox.Show("El registro se ha grabado correctamente..", "Gestion de Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //        Log_in login = new Log_in();
        //    //        login.Show();
        //    //        this.Hide();
        //    //        Limpiar();
        //    //    }
        //    //    else
        //    //    {
        //    //        MessageBox.Show("La contraseña y la confirmación de contraseñ no coinciden", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //        Limpiar();
        //    //    }
        //    //}




          
        //}

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    //Log_in login = new Log_in();
        //    //login.Show();
        //    //this.Hide();
        //}
        private void Limpiar()
        {
            txtNombre.Text="";
            txtEmail.Text = "";
            txtCelular.Text = "";
            txtPais.Text = "";
            txtCiudad.Text = "";
            cmbSexo.Text = "";

            txtNick.Text = "";
            txtContrasena.Text = ""; 
            txtCoContrasena.Text = "";

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btnRegistrar.PerformClick();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            // Verificar si el TextBox está vacío
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNick.Text) || string.IsNullOrEmpty(txtContrasena.Text) || string.IsNullOrEmpty(txtCoContrasena.Text) && string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtCelular.Text) || string.IsNullOrEmpty(txtPais.Text) || string.IsNullOrEmpty(txtCiudad.Text) || cmbSexo.Text == "")
            {

                MessageBox.Show("Complete toda su información", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Usuario objUsuario = new Usuario();
                Criaturita objCriaturita = new Criaturita();

                objCriaturita.Nombre = txtNombre.Text;
                objCriaturita.Email = txtEmail.Text;
                objCriaturita.Celular = txtCelular.Text;
                objCriaturita.Pais = txtPais.Text;
                objCriaturita.Ciudad = txtCiudad.Text;
                objCriaturita.Sexo = cmbSexo.Text;


                objUsuario.Nickname = txtNick.Text;
                objUsuario.Contraseña = txtContrasena.Text;
                objUsuario.IdEstado = 2;

                if (txtContrasena.Text == txtCoContrasena.Text)
                {
                    Criaturitas.Insertar(objCriaturita);
                    int a = objCriaturita.IdCriaturita;
                    objUsuario.IdCriaturita = a;
                    usuarios.Insertar(objUsuario);
                    MessageBox.Show("El registro se ha grabado correctamente..", "Gestion de Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Log_in login = new Log_in();
                    login.Show();
                    this.Hide();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("La contraseña y la confirmación de contraseñ no coinciden", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }




        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Log_in login = new Log_in();
            login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btnCancelar.PerformClick();
        }
    }
}
