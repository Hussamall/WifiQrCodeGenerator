using static QRCoder.PayloadGenerator;

namespace WifiQrCodeGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.RadioButton rbWifi;
        private System.Windows.Forms.RadioButton rbEmail;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {

            
            // Im InitializeComponent:
            this.rbWifi = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();

            // rbWifi
            this.rbWifi.Location = new System.Drawing.Point(30, 10);
            this.rbWifi.Name = "rbWifi";
            this.rbWifi.Size = new System.Drawing.Size(100, 20);
            this.rbWifi.Text = "WLAN";
            this.rbWifi.Checked = true;

            // rbEmail
            this.rbEmail.Location = new System.Drawing.Point(150, 10);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(100, 20);
            this.rbEmail.Text = "E-Mail";

            // Füge sie dem Formular hinzu
            this.Controls.Add(this.rbWifi);
            this.Controls.Add(this.rbEmail);



            this.txtSSID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbEncryption = new System.Windows.Forms.ComboBox();
            this.chkHidden = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTogglePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSSID
            // 
            this.txtSSID.Location = new System.Drawing.Point(119, 94);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(200, 22);
            this.txtSSID.TabIndex = 0;
            this.txtSSID.TextChanged += new System.EventHandler(this.txtSSID_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(119, 138);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cmbEncryption
            // 
            this.cmbEncryption.FormattingEnabled = true;
            this.cmbEncryption.Location = new System.Drawing.Point(119, 182);
            this.cmbEncryption.Name = "cmbEncryption";
            this.cmbEncryption.Size = new System.Drawing.Size(200, 24);
            this.cmbEncryption.TabIndex = 2;
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.Location = new System.Drawing.Point(119, 223);
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.Size = new System.Drawing.Size(117, 20);
            this.chkHidden.TabIndex = 3;
            this.chkHidden.Text = "SSID versteckt";
            this.chkHidden.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(119, 291);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(200, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "QR-Code erstellen";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // picQRCode
            // 
            this.picQRCode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picQRCode.Location = new System.Drawing.Point(346, 85);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(200, 200);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCode.TabIndex = 5;
            this.picQRCode.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(346, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "QR-Code speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(119, 262);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Auswahl leeren";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.Location = new System.Drawing.Point(83, 138);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(30, 22);
            this.btnTogglePassword.TabIndex = 0;
            this.btnTogglePassword.Text = "👁️";
            this.btnTogglePassword.Click += new System.EventHandler(this.btnTogglePassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTogglePassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chkHidden);
            this.Controls.Add(this.cmbEncryption);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSSID);
            this.Controls.Add(this.btnReset);
            this.Name = "Form1";
            this.Text = "WLAN-QR-Code-App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();



        }
        private System.Windows.Forms.Button btnReset;


        #endregion

        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbEncryption;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Button btnSave;
    }
}

