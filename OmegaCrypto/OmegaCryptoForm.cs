using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmegaCrypto
{
    public partial class OmegaCryptoForm : Form
    {
        public OmegaCryptoForm()
        {
            InitializeComponent();

            //Load default public/private keys if present
            String filePath = @"C:\Users\User\Documents\projects\arcade\LaunchBox\OmegaSettingsMenu\rsa\private.txt";
            if (File.Exists(filePath))
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(File.ReadAllText(filePath));

                this.Public_textbox.Text = rsa.ToXmlString(false);
                this.Private_textbox.Text = rsa.ToXmlString(true);
            }
        }

        private void genkeys_button_Click(object sender, EventArgs e)
        {
            //Generate a public/private key pair.  
            RSA rsa = RSA.Create();

            this.Public_textbox.Text = rsa.ToXmlString(false);
            this.Private_textbox.Text = rsa.ToXmlString(true);


        }

        private void sign_button_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(Private_textbox.Text);

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                String filePath = openFileDialog.FileName;

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File not found.");
                    return;
                }

                //Hash the file
                byte[] hashValue;
                byte[] signedHashValue;
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    using (SHA1Managed sha1 = new SHA1Managed())
                    {
                        hashValue = sha1.ComputeHash(bs);
                    }
                }

                //Sign the hash using the private key:

                //Create an RSAPKCS1SignatureFormatter object and pass it the
                //RSA instance to transfer the private key.
                RSAPKCS1SignatureFormatter rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);

                //Set the hash algorithm to SHA1.
                rsaFormatter.SetHashAlgorithm("SHA1");

                //Create a signature for hashValue and assign it to
                //signedHashValue.
                signedHashValue = rsaFormatter.CreateSignature(hashValue);

                //Write the signature to a file
                if (File.Exists(filePath + ".signature"))
                    File.Delete(filePath + ".signature");
                File.WriteAllBytes(filePath + ".signature", signedHashValue);

                MessageBox.Show("Signature written to " + filePath + ".signature");
            }
        }

        private void verify_button_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(Public_textbox.Text);

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                String filePath = openFileDialog.FileName;

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File not found.");
                    return;
                }

                if (!File.Exists(filePath + ".signature"))
                {
                    MessageBox.Show("Signature not found.");
                    return;
                }


                //Hash the file
                byte[] hashValue;
                byte[] signedHashValue = File.ReadAllBytes(filePath + ".signature");
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    using (SHA1Managed sha1 = new SHA1Managed())
                    {
                        hashValue = sha1.ComputeHash(bs);
                    }
                }

                //Verify the hash using the public key:

                //Create an RSAPKCS1SignatureDeformatter object and pass it the
                //RSA instance to transfer the public key.
                RSAPKCS1SignatureDeformatter rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);

                //Set the hash algorithm to SHA1.
                rsaDeformatter.SetHashAlgorithm("SHA1");

                if (rsaDeformatter.VerifySignature(hashValue, signedHashValue))
                {
                    MessageBox.Show("The signature is valid.");
                }
                else
                {
                    MessageBox.Show("The signature is not valid!!!");
                }
            }
        }

        private void loadkeys_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                String filePath = openFileDialog.FileName;

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File not found.");
                    return;
                }

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(File.ReadAllText(filePath));

                this.Public_textbox.Text = rsa.ToXmlString(false);
                this.Private_textbox.Text = rsa.ToXmlString(true);

            }
        }
    }
}
