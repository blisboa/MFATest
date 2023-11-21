
namespace MFATest
{
    partial class FrmRegistrarGoogleAuth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxCodigoQR = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodigoQR)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(56, 354);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(126, 26);
            this.txtClave.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Paso 2: Ingresa la clave que indica la aplicación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Activar Google Authenticator usando la cámara";
            // 
            // pictureBoxCodigoQR
            // 
            this.pictureBoxCodigoQR.Location = new System.Drawing.Point(119, 88);
            this.pictureBoxCodigoQR.Name = "pictureBoxCodigoQR";
            this.pictureBoxCodigoQR.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxCodigoQR.TabIndex = 15;
            this.pictureBoxCodigoQR.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Paso 1: Registrar dispositivo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(282, 349);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(122, 37);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmRegistrarGoogleAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 426);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxCodigoQR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "FrmRegistrarGoogleAuth";
            this.Text = "FrmRegistrarGoogleAuth";
            this.Load += new System.EventHandler(this.FrmRegistrarGoogleAuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodigoQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxCodigoQR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrar;
    }
}