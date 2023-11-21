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
using System.Security.Cryptography;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using System.IO;
using System.Drawing.Imaging;
using OtpNet;

namespace MFATest
{
    public partial class FrmRegistrarGoogleAuth : Form
    {
        public FrmRegistrarGoogleAuth()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        public Bitmap GenerateQrCode()
        {
            string appName = "MFATest";
            var authenticatorUriFormat = "otpauth://totp/{0}?secret={1}&issuer={2}";
            string data = string.Format(authenticatorUriFormat, Uri.EscapeDataString(User.Username), User.SecretKey, Uri.EscapeDataString(appName));

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(20);
            Bitmap resizedQrCodeImage = new Bitmap(qrCodeImage, 100, 100);

            return resizedQrCodeImage;
        }

        public string GenerateSecretKey()
        {
            var key = KeyGeneration.GenerateRandomKey(20); //genera una clave de 20 bytes (160 bits)
            return Google.Authenticator.Base32Encoding.ToString(key); //convierte la clave en base32
        }



        private void btnRegistrar_Click(object sender, EventArgs e)
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
                    "Error al intentar vincular",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void FrmRegistrarGoogleAuth_Load(object sender, EventArgs e)
        {
            Bitmap qrcode = GenerateQrCode();
            pictureBoxCodigoQR.Image = qrcode;
        }

        private void MostrarCodigoQR(string qrCodeBase64)
        {
            // Convertir la cadena base64 en un objeto Bitmap
            byte[] imageBytes = Convert.FromBase64String(qrCodeBase64);
            MemoryStream ms = new MemoryStream(imageBytes);
            Bitmap qrCodeImage = new Bitmap(ms);

            // Establecer la imagen del PictureBox
            pictureBoxCodigoQR.Image = qrCodeImage;
        }

    }
}
