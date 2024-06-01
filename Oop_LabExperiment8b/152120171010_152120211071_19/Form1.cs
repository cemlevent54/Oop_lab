using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _152120171010_152120211071_19
{
    public partial class labeluser1 : Form
    {
        public labeluser1()
        {
            InitializeComponent();           
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            
            GameForm gameForm = new GameForm(this);
            gameForm.Show();
        }
    }
}
