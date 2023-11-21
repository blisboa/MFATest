
namespace MFATest
{
    partial class GoogleAuthLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa el código que ves en la app de Google Authenticator";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(118, 84);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 26);
            this.txtClave.TabIndex = 1;
            // 
            // txtOk
            // 
            this.txtOk.Location = new System.Drawing.Point(273, 79);
            this.txtOk.Name = "txtOk";
            this.txtOk.Size = new System.Drawing.Size(99, 37);
            this.txtOk.TabIndex = 2;
            this.txtOk.Text = "ok";
            this.txtOk.UseVisualStyleBackColor = true;
            this.txtOk.Click += new System.EventHandler(this.txtOk_Click);
            // 
            // GoogleAuthLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 178);
            this.Controls.Add(this.txtOk);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label1);
            this.Name = "GoogleAuthLogin";
            this.Text = "GoogleAuthLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button txtOk;
    }
}