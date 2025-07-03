using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;

namespace WifiQrCodeGenerator
{
    public partial class Form1 : Form
    {
        private bool passwordVisible = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEncryption.Items.Add("WPA");
            cmbEncryption.Items.Add("WEP");
            cmbEncryption.Items.Add("nopass");
            cmbEncryption.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCode qrCode;
            QRCodeData qrCodeData;
            Bitmap qrBitmap;

            if (rbWifi.Checked)
            {
                // WLAN-QR-Code generieren
                string ssid = txtSSID.Text;
                string password = txtPassword.Text;
                string encryption = cmbEncryption.SelectedItem.ToString();
                bool hidden = chkHidden.Checked;

                if (string.IsNullOrWhiteSpace(ssid))
                {
                    MessageBox.Show("Bitte SSID eingeben.");
                    return;
                }

                string wifiPayload = $"WIFI:T:{encryption};S:{ssid};P:{password};H:{(hidden ? "true" : "false")};;";

                qrCodeData = qrGenerator.CreateQrCode(wifiPayload, QRCodeGenerator.ECCLevel.Q);
                qrCode = new QRCode(qrCodeData);
                qrBitmap = qrCode.GetGraphic(20);
            }
            else if (rbEmail.Checked)
            {
                // E-Mail-QR-Code generieren
                string email = txtSSID.Text;
                string subject = txtPassword.Text;
                //string body = txtBody.Text; &body={Uri.EscapeDataString(body)}

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Bitte eine E-Mail-Adresse eingeben.");
                    return;
                }

                string mailto = $"mailto:{email}?subject={Uri.EscapeDataString(subject)}";

                qrCodeData = qrGenerator.CreateQrCode(mailto, QRCodeGenerator.ECCLevel.Q);
                qrCode = new QRCode(qrCodeData);
                qrBitmap = qrCode.GetGraphic(20);
            }
            else
            {
                MessageBox.Show("Bitte einen QR-Code-Typ auswählen.");
                return;
            }

            picQRCode.Image = qrBitmap;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (picQRCode.Image == null)
            {
                MessageBox.Show("Bitte zuerst einen QR-Code generieren.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG-Datei|*.png";
            saveFileDialog.Title = "QR-Code speichern";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                picQRCode.Image.Save(saveFileDialog.FileName);
                MessageBox.Show("QR-Code gespeichert.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSSID.Clear();
            txtPassword.Clear();
            cmbEncryption.SelectedIndex = 0;
            chkHidden.Checked = false;
            picQRCode.Image = null;
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            txtPassword.UseSystemPasswordChar = !passwordVisible;
        }

        private void txtSSID_TextChanged(object sender, EventArgs e)
        {
            // Optional: dynamisches Verhalten bei SSID-Eingabe
        }
    }
}
