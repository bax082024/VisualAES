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
            string plainText = txtPlainText.Text;
            string key = txtKey.Text;

            if (string.IsNullOrWhiteSpace(plainText) || string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Please enter both the plain text and the key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                txtEncryptedText.Text = EncryptText(plainText, key);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private string DecryptText(string encryptedText, string key)
        {
            using (Aes aes = Aes.Create())
            {
                // Convert key and IV to byte arrays
                aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32)); // Ensure key is 32 bytes
                aes.IV = new byte[16]; // Default IV (all zeros for simplicity)

                using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                    byte[] plainBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                    return Encoding.UTF8.GetString(plainBytes);
                }
            }
        }





    }
}
