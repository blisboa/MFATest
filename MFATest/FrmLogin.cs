using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using Google.Authenticator;

namespace MFATest
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(UsuarioDAL.Autenticar(txtUsuario.Text, txtPass.Text))
            {
                MessageBox.Show("Inicio de sesión correcto");
                GoogleAuthLogin google = new GoogleAuthLogin();
                google.Show();

                // f.FormClosed += Logout;
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Nombre de usuario o contraseña incorrectos", 
                    "Error de inicio de sesión", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }


        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPass.Clear();
            txtUsuario.Clear();
            this.Show();
            txtUsuario.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegisterUser ru = new FrmRegisterUser();
            ru.Show();
        }
    }
}
