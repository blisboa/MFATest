using Google.Authenticator;
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
    public partial class GoogleAuthLogin : Form
    {
        public GoogleAuthLogin()
        {
            InitializeComponent();
        }

        private void txtOk_Click(object sender, EventArgs e)
        {
            string secretKey = User.SecretKey;
            TimeSpan timeSpan = TimeSpan.FromSeconds(30);

            var authenticator = new TwoFactorAuthenticator();
            bool isCodeValid = authenticator.ValidateTwoFactorPIN(secretKey, txtClave.Text, timeSpan, true);
            if (isCodeValid)
            {
                MessageBox.Show("Vinculado con éxito");
                FrmInicio inicio = new FrmInicio();
                inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Código no coincide",
                    "Error de inicio de sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
