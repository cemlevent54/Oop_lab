using System.Security.Authentication;
using System.Windows.Forms;

namespace _152120211071_152120171010_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label2.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                label2.Visible = false;
                textBox2.Visible = false;
            }
        }

        public static void Encipher(ref char[] input, int key, out bool success, ref Label successlabel, out string encryptedMessage)
        {
            encryptedMessage = string.Empty;
            if (input.Length < 2)
            {
                success = false;
                successlabel.Text = "FAIL";
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                Cipher(ref ch, key);
                encryptedMessage += ch;
            }

            success = true;
            successlabel.Text = "SUCCESS";
        }

        public static void Cipher(ref char ch, int key)
        {
            if (char.IsLetter(ch))
            {
                char d = char.IsUpper(ch) ? 'A' : 'a';
                ch = (char)((((ch + key) - d) % 26) + d);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool success;
            string encyrptedMessage;

            if (radioButton2.Checked)
            {
                int key;
                if(string.IsNullOrEmpty(textBox2.Text))
                {
                    key = 4;
                }

                else if (!int.TryParse(textBox2.Text, out key))
                {
                    MessageBox.Show("Please enter a valid integer key for Ceaser Cipher.");
                    return;
                }

                char[] password = textBox1.Text.ToCharArray();
                Encipher(ref password, key, out success, ref label3, out encyrptedMessage);
            }

            else if (radioButton1.Checked)
            {
                char[] password = textBox1.Text.ToCharArray();
                Encipher(ref password, 3, out success, ref label3, out encyrptedMessage);
            }

            else
            {
                MessageBox.Show("Please select a cipher method.");
                return;
            }

            if (success)
            {
                label3.Visible = true;
                label4.Visible = true;
                label3.BackColor = System.Drawing.Color.Green;
                label4.Text = "CIPHER: " + encyrptedMessage;
            }
            else
            {
                label3.Visible = true;
                label4.Visible = false;
                label3.BackColor = System.Drawing.Color.Red;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; 
                MessageBox.Show("Please enter only letters !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        
    }
}
