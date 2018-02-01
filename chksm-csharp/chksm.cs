using System;
using System.Windows.Forms;


namespace chksm_csharp
{
    public partial class Chksm : Form
    {
        public Chksm()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Any File|*";
            openFileDialog.Title = "Select a file to checksum";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = openFileDialog.FileName;    
            }
        }

        public string GetFilename()
        {
            return txtFilename.Text;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // clear what ever is occupying the box
            txtResults.Clear();

            // get state of all checkboxes
            bool md5 = chkMd5.Checked;
            bool sha1 = chkSha1.Checked;
            bool sha256 = chkSha256.Checked;

            // get the path from the textbox
            string filename = txtFilename.Text;

            if (md5 && sha1 && sha256)
            {
                txtResults.Text += "MD5:\r\n";
                txtResults.Text += Hash.ToString(Hash.Md5(filename));
                txtResults.Text += "\r\nSHA1:\r\n";
                txtResults.Text += Hash.ToString(Hash.Sha1(filename));
                txtResults.Text += "\r\nSHA256:\r\n";
                txtResults.Text += Hash.ToString(Hash.Sha256(filename));
            }
            else if (md5 && sha1)
            {
                txtResults.Text += "MD5:\r\n";
                txtResults.Text += Hash.ToString(Hash.Md5(filename));
                txtResults.Text += "\r\nSHA1:\r\n";
                txtResults.Text += Hash.ToString(Hash.Sha1(filename));
            }
            else if (md5 && sha256)
            {
                txtResults.Text += "MD5:\r\n";
                txtResults.Text += Hash.ToString(Hash.Md5(filename));
                txtResults.Text += "\r\nSHA256:\r\n";
                txtResults.Text += Hash.ToString(Hash.Sha256(filename));
            }
            else if (sha1 && sha256)
            {
                txtResults.Text += "SHA1:\r\n";
                txtResults.Text += Hash.ToString(Hash.Sha1(filename));
                txtResults.Text += "\r\nSHA256:\r\n";
                txtResults.Text += Hash.ToString(Hash.Sha256(filename));
            }
            else if (md5)
            {
                txtResults.Text += "MD5:\r\n";
                txtResults.Text += Hash.ToString(Hash.Md5(filename));
            }
            else if (sha1)
            {
                txtResults.Text += "SHA1:\r\n";
                txtResults.Text += Hash.ToString(Hash.Sha1(filename));
            }
            else if (sha256)
            {
                txtResults.Text += "SHA256:\r\n";
                txtResults.Text += Hash.ToString(Hash.Sha256(filename));
            }
        }
    }
}
