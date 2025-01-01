using System.Security.Cryptography;
using System.Text;


namespace VisualAES
{
    public partial class VisualAESForm : Form
    {
        public VisualAESForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {

        }

        private string EncryptText(string plainText, string key)
        {
            using (Aes aes = Aes.Create())
            {
                // Convert key and IV to byte arrays
                aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32)); // Ensure key is 32 bytes
                aes.IV = new byte[16]; // Default IV (all zeros for simplicity)

                using (ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                    byte[] encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                    return Convert.ToBase64String(encryptedBytes);
                }
            }
        }




    }
}
