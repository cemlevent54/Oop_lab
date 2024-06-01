using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120171010_152120211071_19
{
    public partial class User1 : Form
    {
        public User1()
        {
            InitializeComponent();
        }

        public int user1point;
        public int[] user1guess;

        private void btn_submit_Click(object sender, EventArgs e)
        {
            int countofstar = int.Parse(textBox1.Text.ToString());
            int countofo = int.Parse(textBox2.Text.ToString());
            int countof_ = int.Parse(textBox3.Text.ToString());

            user1guess = new int[3];
            user1guess[0] = countofstar;
            user1guess[1] = countofo;
            user1guess[2] = countof_;
            MessageBox.Show("Seçimleriniz kaydedildi.");

        }

        
    }
}
