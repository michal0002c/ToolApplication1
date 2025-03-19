using System;
using System.Linq;
using System.Windows.Forms;

namespace ToolApplication
{
    public partial class PasswordGen : Form
    {
        private bool isPasswordVisible = false;
        private string generatedPassword = string.Empty;

        public PasswordGen()
        {
            InitializeComponent();
            passBar.Minimum = 0;
            passBar.Maximum = 100;
            passBar.Value = 0;

            textBoxPasswordLen.TextChanged += UpdateProgressBar;
        }

        private void UpdateProgressBar(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxPasswordLen.Text, out int length) || length < 0)
            {
                passBar.Value = 0;
                return;
            }

            if (length <= 16)
                passBar.Value = (length * 50) / 16;
            else if (length <= 32)
                passBar.Value = 50 + ((length - 16) * 50) / 16;
            else
                passBar.Value = 100;
        }

        private void passGenButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxPasswordLen.Text, out int length) || length <= 0)
            {
                ShowError("Enter a valid password length.");
                return;
            }

            if (length > 64)
            {
                ShowError("Maximum password length is 64 characters.");
                return;
            }

            generatedPassword = GeneratePassword(length);
            UpdatePasswordLabel();
        }

        private string GeneratePassword(int length)
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            Random random = new Random();
            return new string(Enumerable.Repeat(characters, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void UpdatePasswordLabel()
        {
            passwordLabel.Text = isPasswordVisible ? generatedPassword : new string('*', generatedPassword.Length);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(generatedPassword))
            {
                ShowError("No password to copy.");
                return;
            }

            Clipboard.SetText(generatedPassword);
            MessageBox.Show("Password copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(generatedPassword))
                return;

            isPasswordVisible = !isPasswordVisible;
            UpdatePasswordLabel();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
