using OtpNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFATest
{
    public partial class FrmRegisterUser : Form
    {
        public FrmRegisterUser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public string GenerateSecretKey()
        {
            var key = KeyGeneration.GenerateRandomKey(20); //genera una clave de 20 bytes (160 bits)
            return Google.Authenticator.Base32Encoding.ToString(key); //convierte la clave en base32
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (txtPass.Text == txtConfirmarPass.Text)
            {
                string secretKey = GenerateSecretKey();
                User.Username = txtUsuario.Text;
                User.SecretKey = secretKey;
                if (UsuarioDAL.CrearCuenta(txtUsuario.Text, txtPass.Text, secretKey) > 0)
                {
                    FrmRegistrarGoogleAuth google = new FrmRegistrarGoogleAuth();
                    google.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("No se pudo crear la cuenta");
            }
        }
    }
}
