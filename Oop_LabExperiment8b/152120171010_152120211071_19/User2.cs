using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120171010_152120211071_19
{
    public partial class User2 : Form
    {
        public User2()
        {
            InitializeComponent();
        }

        public int user2point;
        public int[] user2guess;

        private void btn_submit_Click(object sender, EventArgs e)
        {
            int countofstar = int.Parse(textBox1.Text.ToString());
            int countofo = int.Parse(textBox2.Text.ToString());
            int countof_ = int.Parse(textBox3.Text.ToString());

            user2guess = new int[3];
            user2guess[0] = countofstar;
            user2guess[1] = countofo;
            user2guess[2] = countof_;

            MessageBox.Show("Seçimleriniz kaydedildi.");
        }
    }
}
