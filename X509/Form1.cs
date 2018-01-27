using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X509
{
    public partial class Form1 : Form
    {
        string file = "";
        byte[] encoded;
        public Form1()
        {
            InitializeComponent();
        }

        private void selectCertFile_Click(object sender, EventArgs e)
        {
            openCertDialog.Filter = "Certificate .p12 (*.p12)|*.p12";
            if (openCertDialog.ShowDialog() == DialogResult.OK)
            {
                file = openCertDialog.FileName;
            }
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            //if certfile and password specified
            if (file != "" && certPassword.Text != "")
            {
                try
                {
                    X509Certificate2 cert = new X509Certificate2(file, certPassword.Text, X509KeyStorageFlags.Exportable | X509KeyStorageFlags.PersistKeySet);

                    var publicKey = cert.PublicKey.Key as RSACryptoServiceProvider;
                    byte[] encryptedData = publicKey.Encrypt(Encoding.ASCII.GetBytes(orginalText.Text), false);
                    encoded = encryptedData;
                    
                    encryptedText.Text = Convert.ToBase64String(encryptedData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else if (file != "" && certPassword.Text == "")
            {
                MessageBox.Show("You don't specify certificate password. Please fill a textbox");
            }
            else
            {
                MessageBox.Show("Cert file not selected");
            }
            
            
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            //if certfile and password specified
            if (file != "" && certPassword.Text != "")
            {
                try
                {
                    X509Certificate2 cert = new X509Certificate2(file, certPassword.Text, X509KeyStorageFlags.Exportable | X509KeyStorageFlags.PersistKeySet);


                    var privateKey = cert.PrivateKey as RSACryptoServiceProvider;
                    var data = privateKey.Decrypt(Convert.FromBase64String(encryptedText.Text), false);

                    orginalText.Text = Encoding.ASCII.GetString(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
