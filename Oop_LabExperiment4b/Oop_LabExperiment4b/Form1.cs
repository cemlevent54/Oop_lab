using System.Windows.Forms;

namespace Oop_LabExperiment4b
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.White;
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.CheckedItems.Count - 1; i >= 0; i--)
            {
                var silinecek = checkedListBox1.CheckedItems[i];
                checkedListBox1.Items.Remove(silinecek);
                comboBox1.Items.Remove(silinecek);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
            {
                checkedListBox1.Items[checkedListBox1.SelectedIndex] = textBox1.Text;
                comboBox1.Items[checkedListBox1.SelectedIndex] = textBox1.Text;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int selectedNumber = Convert.ToInt32(comboBox1.SelectedItem);

            DateTime currentTime = DateTime.Now;

            DateTime resultTimeAfterAddition = currentTime.AddHours(selectedNumber);

            if (resultTimeAfterAddition.Hour > 20 || resultTimeAfterAddition.Hour < 8)
            {
                label1.BackColor = Color.Black;
            }
            else
            {
                label1.BackColor = Color.Red;
            }

            label1.Text = resultTimeAfterAddition.ToString("HH:mm:ss");
            dateTimePicker1.Value = resultTimeAfterAddition;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            int selectedItemCount = checkedListBox1.CheckedItems.Count;

            if (selectedItemCount > 0)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }
    }
}
