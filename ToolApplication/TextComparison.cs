using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolApplication
{
    public partial class TextComparison : Form
    {
        public TextComparison()
        {
            InitializeComponent();
        }

        private void Text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string text1 = text_A.Text;
            string text2 = text_B.Text;

            string[] lines1 = text1.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            string[] lines2 = text2.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            List<string> differences = new List<string>();

            int maxLines = Math.Max(lines1.Length, lines2.Length);

            for (int i = 0; i < maxLines; i++)
            {
                string line1 = i < lines1.Length ? lines1[i] : "";
                string line2 = i < lines2.Length ? lines2[i] : "";

                int maxLength = Math.Max(line1.Length, line2.Length);

                for (int j = 0; j < maxLength; j++)
                {
                    char char1 = j < line1.Length ? line1[j] : '-';
                    char char2 = j < line2.Length ? line2[j] : '-';

                    if (char1 != char2)
                    {
                        string message = "Linia " + (i + 1) + ", pozycja " + (j + 1) +
                                         ": '" + char1 + "' vs '" + char2 + "'";
                        differences.Add(message);
                    }
                }
            }

            if (differences.Count == 0)
            {
                labelResult.Text = "Teksty są identyczne.";
            }
            else
            {
                labelResult.Text = string.Join(Environment.NewLine, differences);
            }
        }
    }
}
